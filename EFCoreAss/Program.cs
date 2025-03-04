using EFCoreAss.Contexts;
using EFCoreAss.Entities;

namespace EFCoreAss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext context = new ITIDbContext();

            #region Add Instructor
            //Instructor Ins1 = new Instructor()
            //{
            //    Name = "Moaz",
            //    Salary = 10000,
            //    Bonus = 10,
            //    Address = "Giza",
            //    HourRate = 2
            //};
            //Instructor Ins2 = new Instructor()
            //{
            //    Name = "Marwan",
            //    Salary = 20000,
            //    Bonus = 20,
            //    Address = "Cairo",
            //    HourRate = 3
            //};

            //Console.WriteLine(context.Entry(Ins1).State);
            //context.Add(Ins1);
            //context.Add(Ins2);
            //Console.WriteLine(context.Entry(Ins1).State);
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Ins1).State);
            #endregion

            #region Add Student
            //Student std1 = new Student()
            //{
            //    FName = "Mohamed",
            //    LName = "Gamal",
            //    Address = "Alex",
            //    Age = 20
            //};
            //Student std2 = new Student()
            //{
            //    FName = "Omar",
            //    LName = "Tarek",
            //    Address = "Cairo",
            //    Age = 23
            //};

            //Console.WriteLine(context.Entry(std1).State);
            //context.Add(std1);
            //context.Add(std2);
            //Console.WriteLine(context.Entry(std1).State);
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(std1).State);
            #endregion

            #region Add Course
            //Course course1 = new Course()
            //{
            //    Name = "CS",
            //    Description = "cs 111",
            //    Duration = 20
            //};
            //Course course2 = new Course()
            //{
            //    Name = "AI",
            //    Description = "cs 122",
            //    Duration = 30
            //};

            //Console.WriteLine(context.Entry(course1).State);
            //context.Add(course1);
            //context.Add(course2);
            //Console.WriteLine(context.Entry(course1).State);
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(course1).State);
            #endregion

            #region Add Department
            //Department dept1 = new Department()
            //{
            //    Name = "IS",
            //    HiringDate = DateTime.Now,
            //};
            //Department dept2 = new Department()
            //{
            //    Name = "IT",
            //    HiringDate = DateTime.Now,
            //};

            //Console.WriteLine(context.Entry(dept1).State);
            //context.Add(dept1);
            //context.Add(dept2);
            //Console.WriteLine(context.Entry(dept1).State);
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(dept1).State);
            #endregion

            #region Add Topic
            //Topic topic1 = new Topic()
            //{
            //    Name = "IntroToProgramming"
            //};

            //Console.WriteLine(context.Entry(topic1).State);
            //context.Add(topic1);
            //Console.WriteLine(context.Entry(topic1).State);
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(topic1).State);
            #endregion

            #region Select
            //var instructor = (from Ins in context.Instructors
            //                  where Ins.Id == 1
            //                  select Ins).FirstOrDefault();
            //Console.WriteLine(instructor?.Name ?? "N/A");
            #endregion

            #region Update
            //instructor.Name = "Ali";
            //Console.WriteLine(context.Entry(instructor).State);
            //context.SaveChanges();
            #endregion

            #region Remove
            //Console.WriteLine(context.Entry(instructor).State);
            //context.Remove(instructor);
            //Console.WriteLine(context.Entry(instructor).State);
            //context.SaveChanges();

            #endregion
        }
    }
}
