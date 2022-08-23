using System;

namespace SimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum is: {MathFunc.Sum(1, 2)}");
        } 
    }

    public class MathFunc
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
