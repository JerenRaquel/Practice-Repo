using System;

namespace TestRepo
{
    class Program
    {
        public static float difficultyModifier = 1f;

        public static void Main(string[] args)
        {
            float somemath = 1f; // Pretend some math happened 

            float result = somemath * Program.difficultyModifier;

            Console.WriteLine("Hello World! " + result);
        }
    }
}
