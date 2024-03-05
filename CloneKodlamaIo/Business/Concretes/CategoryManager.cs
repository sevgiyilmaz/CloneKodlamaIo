using CloneKodlamaIo.Business.Abstracts;
using CloneKodlamaIo.DataAccess.Abstracts;
using CloneKodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaIo.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal) 
        {
            _categoryDal = categoryDal;
        }
        public void CategoryAdd(Category item)
        {
            _categoryDal.CategoryAdd(item);
        }

        public void CategoryDelete(Category item)
        {
            _categoryDal.CategoryDelete(item);
        }

        public void CategoryUpdate(Category item)
        {
            _categoryDal.CategoryUpdate(item);
        }

        public List<Category> GetAllCategory()
        {
            return _categoryDal.GetAllCategory();
        }
    }
}
