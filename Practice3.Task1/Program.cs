using System;

namespace Practice3.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Student student = new Student()
      {
        Name = "Volodya",
        Age = 33
      };      string name = student.Name;
      int age = student.Age;
      student.GetStudentInfo(name, age);
      Console.ReadKey();
    }
  }
}
