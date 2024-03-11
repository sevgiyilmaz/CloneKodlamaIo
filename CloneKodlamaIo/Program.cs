using CloneKodlamaIo.Business.Concretes;
using CloneKodlamaIo.DataAccess.Concretes;
using CloneKodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaIo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome KOdlamaIo!");


            Category category = new Category() { CategoryID = 2, CategoryName = "Mobil Uygulama Geliştirme" };
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            categoryManager.CategoryAdd(category);
            categoryManager.GetAllCategory();

            Console.WriteLine("------------------------------------------------------------------------");

            Course course = new Course() { CourseId = 6, CourseName = "Flutter ile Mobil Uygulama Geliştirme", CourseDescription = "Kursumuz her cumartesi saat 20:00 da başlayacaktır", InstructorId = 1, CategoryId = 2 };
            CourseManager courseManager = new CourseManager(new CourseDal());
            courseManager.CourseAdd(course);
            courseManager.GetAllCourse();

            Console.WriteLine("------------------------------------------------------------------------");

            Instructor Instructor = new Instructor { InstructorId = 3, InstructorFullname = "Sevgi Yılmaz" };
            InstructorManager ınstructorManager = new InstructorManager(new InstructorDal());
            ınstructorManager.InstructorAdd(Instructor);
            Console.WriteLine("Yeni eğitmen eklendi.");
            ınstructorManager.GetAllInstructor();


            Console.ReadLine();
        }
    }
}
