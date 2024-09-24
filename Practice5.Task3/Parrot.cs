﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
  internal class Parrot : Animal, IFlyable
  {
    public string Color {  get; set; }
    public new void MakeSound()
    {
      Console.WriteLine("Parrot is talking.");
    }
    public void MakeSound(string words)
    {
      Console.WriteLine(words);
    }
    public void Fly()
    {
      Console.WriteLine("Parrot is flying");
    }

    public Parrot(string name, int age, string color) :
      base(name, age)
    {
      this.Color = color;
    }
  }
}
