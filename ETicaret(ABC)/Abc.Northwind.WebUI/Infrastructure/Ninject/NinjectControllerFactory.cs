using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Abc.BusinessLayer.Abstract;
using Abc.BusinessLayer.Concrete;
using Abc.DataAccessLayer.Abstract;
using Abc.DataAccessLayer.Concrete;
using Ninject;

namespace Abc.Northwind.WebUI.Infrastructure.Ninject
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;
        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IProductService>().To<ProductManager>();
            _kernel.Bind<IProductDal>().To<EfProductDal>();
            _kernel.Bind<ICategoryService>().To<CategoryManager>();
            _kernel.Bind<ICategoryDal>().To<EfCategoryDal>();

        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
            //return base.GetControllerInstance(requestContext, controllerType);
        }
    }
}