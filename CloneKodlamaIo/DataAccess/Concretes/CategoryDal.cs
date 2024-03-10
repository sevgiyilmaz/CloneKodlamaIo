using CloneKodlamaIo.DataAccess.Abstracts;
using CloneKodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaIo.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>
       {
           new Category{CategoryID=1, CategoryName="Programlama" }
        };

        }
        public void CategoryAdd(Category item)
        {
            _categories.Add(item);
        }

        public void CategoryDelete(Category item)
        {
            var categoryId = _categories.FirstOrDefault(x => x.CategoryID == item.CategoryID);
            if (categoryId != null) 
            {
                _categories.Remove(categoryId); 
            }
                
        }

        public void CategoryUpdate(Category item)
        {
            var categoryId = _categories.FirstOrDefault(x => x.CategoryID == item.CategoryID);
            if (categoryId != null)
            {
                categoryId.CategoryName = item.CategoryName;
            }
            else
            {
                Console.WriteLine("Girdiğiniz id numaralı kategori mevcut olmadığı için güncelleme işlemi gerçekleştirilemedi!");
            }
        }

        public List<Category> GetAllCategory()
        {
            foreach (var item in _categories)
            {
                Console.WriteLine(item.CategoryName);
            }
            return _categories;
        }
    }
}
