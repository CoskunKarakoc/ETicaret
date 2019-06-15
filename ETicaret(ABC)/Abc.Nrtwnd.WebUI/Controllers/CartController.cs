using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abc.BusinessLayer.Abstract;
using Abc.Entities.Concrete;
using Abc.Nrtwnd.BusinessLayer.Abstract;
using Abc.Nrtwnd.WebUI.Models.Cart;
using Abc.Nrtwnd.WebUI.Services;

namespace Abc.Nrtwnd.WebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        // GET: Cart
        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Your product, {0}, was successfully added to the cart!", productToBeAdded.ProductName));
            return RedirectToAction("Index", "Product");
        }

        public ActionResult CartSummary()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return PartialView("_PartialCartSummaryView", model);
        }

        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            var model = new CartSummaryViewModel
            {
                Cart = cart
            };
            return View(model);
        }


        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", "Your product was successfully removed from the cart!");
            return RedirectToAction("List");

        }

        public ActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                shippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", $"Thank you {shippingDetails.FirstName}, you order is in process");
            return View();
        }

    }
}