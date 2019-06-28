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

        public void Create(Product products)
        {
            _productDal.Add(products);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId == 0);
        }

        public Product GetById(int productId)
        {
           return _productDal.Get(p => p.ProductId == productId);
        }

        public void Update(Product products)
        {
            _productDal.Update(products);
        }
    }
}
