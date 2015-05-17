using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using NewsApplication.Infrastructure.Concrete;

namespace NewsApplication.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel kernel;

        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }

        private void AddBindings()
        {
            kernel.Bind<IArticleRepository>().To<ArticleRepository>();
            ////    kernel.Bind<IContactProcessor>().To<EmailContactProcessor>();
        }
    }
}