using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KurumsalWeb.Business.Abstract;
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

            return RedirectToAction("List","Product");
        }
    }
}