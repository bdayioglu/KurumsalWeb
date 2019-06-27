using System;
using System.Collections.Generic;
using System.Text;

namespace KurumsalWeb.Entities
{
    public class CartLine
    {
        public Products Product { get; set; }
        public int Quantity { get; set; }
    }
}
