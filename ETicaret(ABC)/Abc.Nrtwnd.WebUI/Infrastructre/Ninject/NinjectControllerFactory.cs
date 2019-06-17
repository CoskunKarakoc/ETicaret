using Abc.Nrtwnd.BusinessLayer.Concrete;
using Abc.Nrtwnd.BusinessLayer.Abstract;
using Abc.Nrtwnd.DataAccessLayer.Concrete;
using Ninject;
using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;
using Abc.BusinessLayer.Abstract;
using Abc.BusinessLayer.Concrete;
using Abc.DataAccessLayer.Abstract;
using Abc.Nrtwnd.WebUI.Services;
using Ninject.Modules;

namespace Abc.Nrtwnd.WebUI.Infrastructre.Ninject
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;
        public NinjectControllerFactory(INinjectModule ninjectModule)
        {
            _kernel = new StandardKernel(ninjectModule);
            _kernel.Bind<ICartSessionService>().To<CartSessionService>().InSingletonScope();
        }


        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {

            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
            //return base.GetControllerInstance(requestContext, controllerType);
        }

    }
}