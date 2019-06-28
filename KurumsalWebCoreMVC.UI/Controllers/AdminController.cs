using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KurumsalWeb.Business.Abstract;
using KurumsalWeb.Business.Concrete;
using KurumsalWeb.DataAccess.Concrete;
using KurumsalWeb.DataAccess.Abstract;
using Microsoft.AspNetCore.Http;
using KurumsalWebCoreMVC.UI.Models;
using KurumsalWeb.Entities;
using Microsoft.AspNetCore.Authorization;

namespace KurumsalWebCoreMVC.UI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public AdminController(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var productListViewModel = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(productListViewModel);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Create(product);
                TempData.Add("message", "Ürün Başarıyla Eklendi.");
            }

            return RedirectToAction("AddProduct");
        }
        [HttpGet]
        public ActionResult UpdateProduct(int productId)
        {
            var model = new ProductUpdateViewModel
            {
                Product = _productService.GetById(productId),
                Categories = _categoryService.GetAll()
            };

            return View(model);

        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                TempData.Add("message", "Ürün Başarıyla Güncellendi");
            }

            return RedirectToAction("UpdateProduct");
        }

        public ActionResult Delete(int productId)
        {
            _productService.Delete(productId);
            TempData.Add("message", "Ürün Başarıyla Silindi");
            return RedirectToAction("Index");
        }
    }
}