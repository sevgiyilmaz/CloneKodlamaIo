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
            new Course() {CourseId=1, CourseName="2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", CourseDescription="2024 C# Yazılım Geliştirici Kampını takip etmeyi unutmayın...", InstructorId=1, CategoryId=1 },
            new Course() {CourseId=2, CourseName="2022 JAVA Yazılım Geliştirici Kampı", CourseDescription="2022 JAVA Yazılım Geliştirici Kampını takip etmeyi unutmayın...", InstructorId=1, CategoryId=1 },
            new Course() {CourseId=3, CourseName="(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium", CourseDescription="Pyton&Selenyum Yazılım Geliştirici Yetiştirme Kampını takip etmeyi unutmayın...", InstructorId=2, CategoryId=1 }
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
            else
            {
                Console.WriteLine("Girdiğiniz id numaralı kurs mevcut olmadığı için güncelleme işlemi gerçekleştirilemedi!");
            }
        }

        public List<Course> GetAllCourse()
        {
            foreach (var course in _courses)
            {
                Console.WriteLine($"Kurs adı: {course.CourseName}, Açıklama: {course.CourseDescription} Eğitmen: {course.InstructorId} Kategori: {course.CategoryId}");
            }
            return _courses;
        }
    }
}
