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
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> GetAllInstructor()
        {
            return _instructorDal.GetAllInstructor();
        }

        public void InstructorAdd(Instructor item)
        {
            _instructorDal.InstructorAdd(item);
        }

        public void InstructorDelete(Instructor item)
        {
            _instructorDal.InstructorDelete(item);
        }

        public void InstructorUpdate(Instructor item)
        {
            _instructorDal.InstructorUpdate(item);
        }
    }
}
