using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Nrtwnd.Core.DataAccess;
using Abc.Nrtwnd.Entities.Concrete;

namespace Abc.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
