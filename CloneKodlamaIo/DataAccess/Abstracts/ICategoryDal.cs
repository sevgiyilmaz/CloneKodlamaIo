using CloneKodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaIo.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        List<Category> GetAllCategory();
        void CategoryAdd(Category item);
        void CategoryDelete(Category item);
        void CategoryUpdate(Category item);
    }
}
