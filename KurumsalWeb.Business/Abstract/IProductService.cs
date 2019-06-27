using KurumsalWeb.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KurumsalWeb.Business.Abstract
{
    public interface IProductService
    {
        List<Products> GetAll();
        List<Products> GetByCategory(int categoryId);
        void Create(Products products);
        void Update(Products products);
        void Delete(int productId);
    }
}
