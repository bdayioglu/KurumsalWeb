using KurumsalWeb.Business.Abstract;
using KurumsalWeb.DataAccess.Abstract;
using KurumsalWeb.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KurumsalWeb.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Create(Products products)
        {
            _productDal.Add(products);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Products { ProductId = productId });
        }

        public List<Products> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Products> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId == 0);
        }

        public void Update(Products products)
        {
            _productDal.Update(products);
        }
    }
}
