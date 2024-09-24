using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task1
{
  internal class Student
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public void GetStudentInfo(string name, int age)
    {
      Console.WriteLine($"Студент: {name}\n" +
                        $"Возраст: {age}");
    }
  }
}
