using Abc.DataAccessLayer.Abstract;
using Abc.Nrtwnd.Core.DataAccess.EntityFramework;
using Abc.Nrtwnd.DataAccessLayer.Concrete.EntityFramework;
using Abc.Nrtwnd.Entities.Concrete;

namespace Abc.Nrtwnd.DataAccessLayer.Concrete
{
    public class EfCategoryDal : EfRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
