using KurumsalWeb.Core.DataAccess;
using KurumsalWeb.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KurumsalWeb.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Custom Operations
    }
}
