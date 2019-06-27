using KurumsalWeb.Core.DataAccess.EfCore;
using KurumsalWeb.DataAccess.Abstract;
using KurumsalWeb.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KurumsalWeb.DataAccess.Concrete.EfCore
{
    public class EfCategoryDal:EfEntityRepositoryBase<Categories, KurumsalWebContext>,ICategoryDal
    {
    }
}
