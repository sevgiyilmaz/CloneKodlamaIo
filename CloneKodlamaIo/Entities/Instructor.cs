using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaIo.Entities
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string InstructorFullname { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
