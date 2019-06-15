using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abc.Nrtwnd.BusinessLayer.Abstract;
using Abc.Nrtwnd.Entities.Concrete;
using Abc.Nrtwnd.WebUI.Models.Product;

namespace Abc.Nrtwnd.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        // GET: Admin
        public ActionResult Index()
        {
            var productListViewModel = new ProductListViewModal
            {
                Products = _productService.GetAll()
            };
            return View(productListViewModel);
        }
        [HttpGet]
        public ActionResult Add()
        {
            var model = new ProductAddViewModal
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                TempData.Add("message", "Product was successfully added");
                return RedirectToAction("Index", "Admin");
            }

            return RedirectToAction("Add");
        }

        public ActionResult Update(int productId)
        {
            var model = new ProductUpdateViewModel
            {
                Product = _productService.GetById(productId),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                TempData.Add("message", "Product was successfully updated");
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int productId)
        {
            _productService.Delete(new Product { ProductId = productId });
            TempData.Add("message", "Product was successfully deleted");
            return RedirectToAction("Index");
        }
    }
}