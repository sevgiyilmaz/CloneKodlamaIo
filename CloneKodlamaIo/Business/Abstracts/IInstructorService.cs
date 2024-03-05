using CloneKodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaIo.Business.Abstracts
{
    public interface IInstructorService
    {
        List<Instructor> GetAllInstructor();
        void InstructorAdd(Instructor item);
        void InstructorDelete(Instructor item);
        void InstructorUpdate(Instructor item);
    }
}
