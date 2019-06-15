using Abc.DataAccessLayer.Abstract;
using Abc.Nrtwnd.BusinessLayer.Abstract;
using Abc.Nrtwnd.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.Nrtwnd.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product entity)
        {
            _productDal.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId || categoryId==0);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
