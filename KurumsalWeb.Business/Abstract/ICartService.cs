using KurumsalWeb.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KurumsalWeb.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart,Product products);
        void RemoveCart(Cart cart,  int productId);
        List<CartLine> List(Cart cart);
    }
}
