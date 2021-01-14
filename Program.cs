using System;

namespace TestRepo
{
  public delegate void Function();

  class Program
  {
    public static float difficultyModifier = 1f;

    public static void Main(string[] args)
    {
      float somemath = 1f; // Pretend some math happened 

      float result = somemath * Program.difficultyModifier;

      Console.WriteLine("Hello World! " + result);
      FooBar(() => {Console.WriteLine("Hi");});
    }

    public static void FooBar(Function func)
    {
        Console.WriteLine("Calling Function now");
         func();
    }
  }
}
