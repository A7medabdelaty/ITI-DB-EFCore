using ITI_DB.Context;
using ITI_DB.Models;

namespace ITI_DB
{
    public class Program
    {
        static void Main(string[] args)
        {
            ITIContext context = new ITIContext();


            var departments = new List<Department>
            {
                new Department
                {
                    DeptName = "CS"
                },
                new Department
                {
                    DeptName = "IS"
                },
                new Department
                {
                    DeptName = "IT"
                }
            };

            var students = new List<Student>
            {
                new Student
                {
                    StFname = "Ahmed",StLname = "Ali",StAddress = "Cairo",StAge = 22,DeptId = 1,StSuper = null
                },
                new Student
                {
                    StFname = "Mona",StLname = "Hassan",StAddress = "Giza",StAge = 24,DeptId = 1,StSuper = 1
                },
                new Student
                {
                    StFname = "Omar",StLname = "Khaled",StAddress = "Alex",StAge = 23,DeptId = 2,StSuper = 1
                },
                new Student
                {
                    StFname = "Sara",StLname = "Ibrahim",StAddress = "Mansoura",StAge = 21,DeptId = 2,StSuper = 2
                },
                new Student
                {
                    StFname = "Mostafa",StLname = "Adel",StAddress = "Cairo",StAge = 25,DeptId = 3,StSuper = 3
                }
            };

            // add departments
            //context.Departments.AddRange(departments);

            // CRUD Operations
            // add students
            //context.Students.AddRange(students);

            //context.SaveChanges();

            //remove student
            Student std = context.Students.Where(s => s.StId == 6).FirstOrDefault();

            if(std!=null) context.Students.Remove(std);

            context.SaveChanges();


            //update student
            Student std2 = context.Students.Where(s => s.StId == 8).FirstOrDefault();

            std2.StAddress = "Menofia";
            std2.StAge = 26;

            if (std2 != null)
                context.Students.Update(std2);

            context.SaveChanges();

            //display all students
            foreach (var s in context.Students)
            {
                Console.WriteLine($"ID: {s.StId}, Name: {s.StFname} {s.StLname}, Address: {s.StAddress}, Age: {s.StAge}, DeptId: {s.DeptId}, StSuper: {s.StSuper}");

            }
        }
    }
}
