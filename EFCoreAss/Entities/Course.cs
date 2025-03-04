using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAss.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Duration { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
        public ICollection<InstructorCourse> InstructorCourses { get; set; } = new HashSet<InstructorCourse>();
    }
}
