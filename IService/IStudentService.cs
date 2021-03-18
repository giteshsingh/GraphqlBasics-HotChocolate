using GraphqlBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlBasics.IService
{
   public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
