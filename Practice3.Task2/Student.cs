using System;

namespace Practice3.Task2
{
  internal class Student
  {
    private int averageScore;
    public string Name { get; set; }
    public int Age { get; set; }
    public int AverageScore
    {
      get
      {
        return this.averageScore;
      }
      set
      {
        if (value < 0)
        {
          throw new ArgumentException("Средний балл не может быть отрицательным.");
        }
        else if (value > 5)
        {
          throw new ArgumentException("Средний балл не может быть больше чем 5.");
        }
        this.averageScore = value;
      }
    }
    public void GetStudentInfo(string name, int age, int averageScore)
    {
      Console.WriteLine($"Студент: {name}\n" +
                        $"Возраст: {age}\n" +
                        $"Средний балл: {averageScore}");
    }
  }
}
