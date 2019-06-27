using KurumsalWeb.Business.Abstract;
using KurumsalWeb.DataAccess.Abstract;
using KurumsalWeb.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KurumsalWeb.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        
        public List<Categories> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
