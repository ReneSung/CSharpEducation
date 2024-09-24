using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task9
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Student student = new Student()
      {
        Name = "Steve Jobs",
        Age = 33
      };
      student.PrintStudent();
      student.ChangeName(student);
      student.PrintStudent();
      Console.ReadKey();
    }
  }
}
