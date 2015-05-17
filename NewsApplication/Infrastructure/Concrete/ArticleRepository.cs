using NewsApplication.Infrastructure.Abstract;
using NewsApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApplication.Infrastructure.Concrete
{
    public class ArticleRepository: RepositoryBase<Article>, IArticleRepository
    {
    }

    public interface IArticleRepository : IRepository<Article> { }
}