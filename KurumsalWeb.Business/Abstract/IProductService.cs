using KurumsalWeb.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KurumsalWeb.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Create(Product products);
        void Update(Product products);
        void Delete(int productId);
        Product GetById(int productId);
    }
}
