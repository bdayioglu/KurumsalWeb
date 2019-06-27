using KurumsalWeb.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KurumsalWeb.Business.Abstract
{
    public interface ICategoryService
    {
        List<Categories> GetAll();
    }
}
