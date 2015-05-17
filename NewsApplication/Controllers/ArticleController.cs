using NewsApplication.Infrastructure.Concrete;
using NewsApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsApplication.Controllers
{
    public class ArticleController : Controller
    {
        private IArticleRepository articleRepository;
        public ArticleController(IArticleRepository r)
        {
            articleRepository = r;
        }
        //
        // GET: /Article/

        public ActionResult Index()
        {
            var result = new List<Article>();
            result = articleRepository.GetAll().ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var result = new Article();
            result.Thumbnail = "4.jpg";
            return View(result);
        }

        [HttpPost]
        public ActionResult Add(Article model)
        {
            if (ModelState.IsValid)
            {
                model.CreateAt = DateTime.Now;
                articleRepository.Add(model);
                return RedirectToIndex();
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var result = new Article();
            result = articleRepository.GetByID(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(Article model)
        {
            if (ModelState.IsValid)
            {
                model.CreateAt = DateTime.Now;
                articleRepository.Update(model);
                return RedirectToIndex();
            }
            return View(model);
        }

        public ActionResult Details(int id)
        {
            return RedirectToView(id);
        }

        public ActionResult Delete(int id)
        {
            var entry = articleRepository.GetByID(id);
            if (entry != null)
                articleRepository.Delete(entry);
            return RedirectToIndex();
        }

        private ActionResult RedirectToIndex()
        {
            return RedirectToAction("Index");
        }

        private ActionResult RedirectToView(int id)
        {
            return RedirectToAction("View", "Home", new { id = id });
        }

    }
}
