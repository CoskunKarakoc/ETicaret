using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Nrtwnd.Entities.Concrete;

namespace Abc.Nrtwnd.BusinessLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int categoryId);
        void Add(Product entity);
        void Delete(Product entity);
        void Update(Product entity);
        Product GetById(int productId);
    }
}
