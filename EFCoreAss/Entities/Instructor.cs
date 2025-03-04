using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAss.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }
        public string? Address { get; set; }
        public int HourRate { get; set; }
        public Department? ManagedDepartment { get; set; }
        public int WorksInDepartmentId { get; set; }
        public Department WorksInDepartment { get; set; }
        public ICollection<InstructorCourse> InstructorCourses { get; set; } = new HashSet<InstructorCourse>(); 
    }
}
