using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Nrtwnd.Entities.Concrete;

namespace Abc.Nrtwnd.BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
