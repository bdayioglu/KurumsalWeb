using KurumsalWeb.Entities;
using KurumsalWebCoreMVC.UI.Models;
using KurumsalWebCoreMVC.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalWebCoreMVC.UI.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {
        ICartSessionServices _cartSessionServices;

        public CartSummaryViewComponent(ICartSessionServices cartSessionServices)
        {
            _cartSessionServices = cartSessionServices;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionServices.GetCart()
            };
            return View(model);
        }
    }
}
