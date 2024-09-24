using System;

namespace Practice3.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Student student = new Student();
      Console.WriteLine("Имя студента");
      student.Name = Console.ReadLine();
      Console.WriteLine("Возраст");
      student.Age = int.Parse(Console.ReadLine());
      Console.WriteLine("Средний балл");
      student.AverageScore = int.Parse(Console.ReadLine());
      Console.WriteLine();


      string studentName = student.Name;
      int age = student.Age;
      int averageScore = student.AverageScore;
      student.GetStudentInfo(studentName, age, averageScore);
      Console.ReadKey();
    }
  }
}
