using CloneKodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaIo.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAllCourse();
        void CourseAdd(Course item);
        void CourseDelete(Course item);
        void CourseUpdate(Course item);
    }
}
