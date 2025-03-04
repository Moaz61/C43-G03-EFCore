using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAss.Entities
{
    internal class InstructorCourse
    {
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string? Evaluation { get; set; }
    }
}
