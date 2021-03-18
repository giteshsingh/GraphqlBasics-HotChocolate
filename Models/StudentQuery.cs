using GraphqlBasics.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlBasics.Models
{
    public class StudentQuery
    {
        IStudentService studentService = null;

        public StudentQuery(IStudentService st)
        {
            studentService = st;
        }

        public List<Student> students => studentService.GetStudents();
    }
}
