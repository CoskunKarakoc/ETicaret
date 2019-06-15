using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abc.Nrtwnd.BusinessLayer.Abstract;
using Abc.Nrtwnd.WebUI.Models.Category;

namespace Abc.Nrtwnd.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: Category
        public ActionResult Index()
        {
            var model = new CategoryListViewModal
            {
                Categories = _categoryService.GetAll(),
                CurrenCategory = Convert.ToInt32(HttpContext.Request.QueryString["category"])
            };
            return PartialView("_PartialCategoriesView",model);
        }
    }
}