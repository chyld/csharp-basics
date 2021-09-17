using System;

namespace Basics
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 3;
      string b = "2";
      var c = Int32.Parse(b);
      var product = a * c;
      Console.WriteLine($"The product of {a} and {c} is {product}");

      var d1 = new Dog("floppy");
      d1.Age = 4;
      var d2 = new Dog();
      var d3 = new Dog("lassy") { Name = "fido", Age = 3 };

      d1.Play(PlayType.Run);
      d2.Play(PlayType.Jump, 40);

      var dogs = new Dog[] { d1, d2, d3 };
      foreach (var dog in dogs)
      {
        Console.WriteLine($"{dog.Name} is {dog.Age} years old, with health {dog.Health}");
      }
    }
  }
}
