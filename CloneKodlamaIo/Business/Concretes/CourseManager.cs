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
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void CourseAdd(Course item)
        {
            _courseDal.CourseAdd(item);
        }

        public void CourseDelete(Course item)
        {
            _courseDal.CourseDelete(item);
        }

        public void CourseUpdate(Course item)
        {
            _courseDal.CourseUpdate(item);
        }

        public List<Course> GetAllCourse()
        {
            return _courseDal.GetAllCourse();
        }
    }
}
