﻿using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            double x1 = R.Next(-100, 100);
            double y1 = R.Next(-100, 100);
            double x2 = R.Next(-100, 100);
            double y2 = R.Next(-100, 100);

            double x3 = R.Next(-100, 100);
            double y3 = R.Next(-100, 100);
            double x4 = R.Next(-100, 100);
            double y4 = R.Next(-100, 100);

            double length1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            Console.WriteLine("length of line1 = " + length1);
            double length2 = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));
            Console.WriteLine("length of line2 = " + length2);
            if (length1.CompareTo(length2) == 0) Console.WriteLine("length of the lines are equal ");
            else if (length1.CompareTo(length2) > 0) Console.WriteLine("length of the line1 is greater than line2 ");
            else Console.WriteLine("length of the line1 is less than line2 ");
        }




    }
}

