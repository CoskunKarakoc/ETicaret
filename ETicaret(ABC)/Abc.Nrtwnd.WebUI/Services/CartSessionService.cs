using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Abc.BusinessLayer.Abstract;
using Abc.Entities.Concrete;
using Abc.Nrtwnd.Entities.Concrete;
using Abc.Nrtwnd.WebUI.ExtensionMethod;

namespace Abc.Nrtwnd.WebUI.Services
{
    public class CartSessionService : ICartSessionService
    {

        public Cart GetCart()
        {
            Cart cartToCheck = CurrentSession.Get<Cart>("cart");
            if (cartToCheck == null)
            {
                CurrentSession.Set("cart", new Cart());
                cartToCheck = CurrentSession.Get<Cart>("cart");
            }
            return cartToCheck;
        }

        public void SetCart(Cart cart)
        {
            CurrentSession.Set("cart", cart);
        }
    }
}