using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFCoreAss.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime HiringDate { get; set; }
        public int DepartmentsManagerId { get; set; }
        public Instructor Manager { get; set; }
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
