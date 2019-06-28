using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KurumsalWeb.Business.Abstract;
using KurumsalWeb.Entities;
using KurumsalWebCoreMVC.UI.Models;
using KurumsalWebCoreMVC.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace KurumsalWebCoreMVC.UI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionServices _cartSessionServices;
        private ICartService _cartService;
        private IProductService _productService;
        public CartController(ICartSessionServices cartSessionServices, ICartService cartService, IProductService productService)
        {
            _cartSessionServices = cartSessionServices;
            _cartService = cartService;
            _productService = productService;
        }
        public IActionResult AddToCart(int productId)
        {
            var prooductToAdded = _productService.GetById(productId);
            var cart = _cartSessionServices.GetCart();

            _cartService.AddToCart(cart,prooductToAdded);
            _cartSessionServices.SetCart(cart);

            TempData.Add("message", String.Format("Ürününüz sepete ,{0}, başarıyla eklenmiştir.",prooductToAdded.ProductName));

            return RedirectToAction("Index","Product");
        }

        public IActionResult List()
        {
            var cart = _cartSessionServices.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }

        public IActionResult Remove(int productId)
        {
            var cart = _cartSessionServices.GetCart();
            _cartService.RemoveFromCart(cart,productId);
            _cartSessionServices.SetCart(cart);

            TempData.Add("message", String.Format("Ürününüz sepete başarıyla silinmiştir."));

            return RedirectToAction("List");
        }

        public IActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails=new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }
        [HttpPost]
        public IActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", String.Format("Teşekkürler ,{0}, Siparişiniz İşleme Alınmıştır. ", shippingDetails.Ad));
            return View();
        }
    }
}