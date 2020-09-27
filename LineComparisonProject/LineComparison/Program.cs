using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            double x1 = R.Next(-100,100);
            double y1 = R.Next(-100, 100);
            double x2 = R.Next(-100, 100);
            double y2 = R.Next(-100, 100);

            double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            Console.WriteLine("length of the line is " + length);
        }
    }
}
