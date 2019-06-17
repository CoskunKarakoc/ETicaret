using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.BusinessLayer.Abstract;
using Abc.BusinessLayer.Concrete;
using Abc.DataAccessLayer.Abstract;
using Abc.Nrtwnd.BusinessLayer.Abstract;
using Abc.Nrtwnd.BusinessLayer.Concrete;
using Abc.Nrtwnd.DataAccessLayer.Concrete;
using Ninject.Modules;

namespace Abc.BusinessLayer.DependencyResolver
{
  public  class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
            Bind<ICartService>().To<CartService>().InSingletonScope();

        }
    }
}
