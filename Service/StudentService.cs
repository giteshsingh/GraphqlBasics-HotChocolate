using GraphqlBasics.IService;
using GraphqlBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlBasics.Service
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            for (int i = 1; i <= 9; i++)
            {
                students.Add(new Student()
                {
                    StudentId = i,
                    StudentName = "Student" + i,
                    SchoolDetails = new School() { SchoolAddress = "Bangalore", SchooldName = "NPS", SchoolId = i },
                    StudentSection = i
                }); ;
            }
            return students;
        }
    }
}
