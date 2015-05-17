using NewsApplication.Infrastructure;
using NewsApplication.Infrastructure.Concrete;
using NewsApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNETI.FIT.Models.ViewModels;

namespace NewsApplication.Controllers
{
    public class HomeController : Controller
    {
        private IArticleRepository articleRepository;
        public HomeController(IArticleRepository r)
        {
            articleRepository = r;
        }
        //
        // GET: /Home/

        public ActionResult Index(FilterModel model)
        {
            var result = new List<Article>();
            var entities = articleRepository
                .GetMany(a => a.Title.Contains(model.SearchString));
            if (model.StateName.Length > 0)
                entities = entities
                    .Where(a => a.State.Name.Contains(model.StateName));
            if (model.CategoryName.Length > 0)
                entities = entities
                    .Where(a => a.Category.Name.Contains(model.CategoryName));
            result = entities.OrderByDescending(a => a.CreateAt).ToList();
            return View(result);
        }

        public ActionResult View(int id)
        {
            var result = new Article();
            result = articleRepository.GetByID(id);
            return View(result);
        }

        public ActionResult Nav()
        {
            return PartialView();
        }

        public ActionResult Hot()
        {
            var result = new List<Article>();
            result = articleRepository
                .GetAll()
                .OrderByDescending(s => s.View)
                .ToList();
            return PartialView(result);
        }

    }
}
