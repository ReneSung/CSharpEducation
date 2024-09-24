using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task9
{
  internal class Student
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public Student ChangeName(Student student)
    {
      student.Name = "Аноним";
      return student;
    }
    public void PrintStudent()
    {
      Console.WriteLine($"Студент: {this.Name}\n" +
                        $"Возраст: {this.Age}");
    }
  }
}
