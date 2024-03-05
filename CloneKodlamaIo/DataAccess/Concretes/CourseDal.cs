using CloneKodlamaIo.DataAccess.Abstracts;
using CloneKodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaIo.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>()
        {
            new Course() {CourseId=1, CourseName="2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", CourseDescription="Kursumuz her pazartesi saat 20:00 da başlayacaktır.", InstructorId=1, CategoryId=1 },
            new Course() {CourseId=2, CourseName="Yazılım Geliştirici Yetiştirme Kampı (JavaScript)", CourseDescription="Kursumuz her salı saat 20:00 da başlayacaktır.", InstructorId=1, CategoryId=1 },
            new Course() {CourseId=3, CourseName="(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium", CourseDescription="Kursumuz her çarşamba saat 20:00 da başlayacaktır.", InstructorId=2, CategoryId=1 },
           new Course() {CourseId=4, CourseName="Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)", CourseDescription="Kursumuz her perşembe saat 20:00 da başlayacaktır.", InstructorId=1, CategoryId=1 },
            new Course() {CourseId=5, CourseName="Programlamaya Giriş için Temel Kurs", CourseDescription="Kursumuz her cuma saat 20:00 da başlayacaktır.", InstructorId=1, CategoryId=1 }
        };
        }

        public void CourseAdd(Course item)
        {
            _courses.Add(item);
        }

        public void CourseDelete(Course item)
        {
            _courses.Remove(item);
        }

        public void CourseUpdate(Course item)
        {
            var courseId = _courses.FirstOrDefault(x => x.CourseId == item.CourseId);
            if (courseId != null)
            {
                courseId.CourseName = item.CourseName;
                courseId.CourseDescription = item.CourseDescription;
                courseId.InstructorId = item.InstructorId;
                courseId.CategoryId = item.CategoryId;
            }
        }

        public List<Course> GetAllCourse()
        {
            foreach (var course in _courses)
            {
                Console.WriteLine("Kurs bilgileri: {0} / {1} / {2} / {3}", course.CourseName, course.CourseDescription, course.InstructorId, course.CategoryId);
            }
            return _courses;
        }
    }
}
