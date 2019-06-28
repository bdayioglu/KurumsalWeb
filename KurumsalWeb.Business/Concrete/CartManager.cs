using KurumsalWeb.Business.Abstract;
using KurumsalWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KurumsalWeb.Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product products)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == products.ProductId);
            if (cartLine!=null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine { Product = products });
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));
        }
    }
}
