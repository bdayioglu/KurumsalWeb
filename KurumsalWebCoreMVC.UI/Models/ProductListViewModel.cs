using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KurumsalWeb.Entities;

namespace KurumsalWebCoreMVC.UI.Models
{
    public class ProductListViewModel
    {
        public List<Products> Products { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int PageSize { get; internal set; }
        public int CurrentPage { get; internal set; }
        public int PageCount { get; internal set; }
    }
}
