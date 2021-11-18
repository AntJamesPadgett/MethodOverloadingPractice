using System;

namespace MethodOverloadingPractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Add(5, 6);
            Add(5, 6, 7);
            Add("Hello", "World");
            Add(5.5, 6.7);
            Console.ReadLine();
           
        }

        public static void Add(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }
        public static void Add(string x, string y)
        {
            string answer = x +  y;
            Console.WriteLine(answer);
        }
        public static void Add(double x, double y)
        {
            double answer = x + y;
            Console.WriteLine(answer);
        }
        public static void Add( int x, int y, int z)
        {
            int answer = x + y + z;
            Console.WriteLine(answer);
        }
        

















    }
}
