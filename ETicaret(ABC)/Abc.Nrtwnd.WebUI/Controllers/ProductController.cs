using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abc.Nrtwnd.BusinessLayer.Abstract;
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
        public ActionResult Index()
        {
            ProductListViewModal modal=new ProductListViewModal();
            modal.Products=_productService.GetAll();
            return View(modal);
        }
    }
}