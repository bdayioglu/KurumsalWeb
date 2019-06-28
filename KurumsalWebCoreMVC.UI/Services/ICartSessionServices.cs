using KurumsalWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalWebCoreMVC.UI.Services
{
    public interface ICartSessionServices
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
