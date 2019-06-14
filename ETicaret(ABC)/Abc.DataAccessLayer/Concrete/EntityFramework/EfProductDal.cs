using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Nrtwnd.Core.DataAccess.EntityFramework;
using Abc.DataAccessLayer.Abstract;
using Abc.Nrtwnd.DataAccessLayer.Concrete.EntityFramework;
using Abc.Nrtwnd.Entities.Concrete;

namespace Abc.Nrtwnd.DataAccessLayer.Concrete
{
    public class EfProductDal : EfRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
