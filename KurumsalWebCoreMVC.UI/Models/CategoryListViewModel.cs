using KurumsalWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalWebCoreMVC.UI.Models
{
    public class CategoryListViewModel
    {
        public List<Categories> Categories { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}
