using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abc.Nrtwnd.BusinessLayer.Abstract;
using Abc.Nrtwnd.WebUI.ExtensionMethod;
using Abc.Nrtwnd.WebUI.Models.Product;

namespace Abc.Nrtwnd.WebUI.Controllers
{
    public class ProductController : Controller
    {


        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Product
        public ActionResult Index(int page = 1, int category = 0)
        {
            int pageSize = 10;
            var products = _productService.GetByCategoryId(category);
            var model = new ProductListViewModal
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)(Math.Ceiling(products.Count / (double)pageSize)),
                PageSize = pageSize,
                CurrenCategory = category,
                CurrenPage = page
            };


            return View(model);
        }


    }
}