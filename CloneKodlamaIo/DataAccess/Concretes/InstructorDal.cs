using CloneKodlamaIo.DataAccess.Abstracts;
using CloneKodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaIo.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>()
        {
            new Instructor{InstructorId=1, InstructorFullname="Engin Demiroğ"},
            new Instructor{InstructorId=2, InstructorFullname="Halit Enes Kalaycı"}
        };
        }
        public List<Instructor> GetAllInstructor()
        {
            foreach (var item in _instructors)
            {
                Console.WriteLine(item.InstructorFullname);
            }
            return _instructors;
        }

        public void InstructorAdd(Instructor item)
        {
            _instructors.Add(item);
        }

        public void InstructorDelete(Instructor item)
        {
            _instructors.Remove(item);
        }

        public void InstructorUpdate(Instructor item)
        {
            var instructorId = _instructors.FirstOrDefault(x => x.InstructorId == item.InstructorId);
            if (instructorId != null)
            {
                instructorId.InstructorFullname = item.InstructorFullname;
            }
        }
    }
}
