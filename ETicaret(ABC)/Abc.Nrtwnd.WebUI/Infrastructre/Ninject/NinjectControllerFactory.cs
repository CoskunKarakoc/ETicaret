﻿using Abc.Nrtwnd.BusinessLayer.Concrete;
using Abc.Nrtwnd.BusinessLayer.Abstract;
using Abc.Nrtwnd.DataAccessLayer.Concrete;
using Ninject;
using System;
using System.Web.Mvc;
using System.Web.Routing;
using Abc.BusinessLayer.Concrete;
using Abc.DataAccessLayer.Abstract;

namespace Abc.Nrtwnd.WebUI.Infrastructre.Ninject
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