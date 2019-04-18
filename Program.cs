using System;

namespace myApp
{
    class Program
    {
        static void WorkingWithStrings()
        {
            Console.WriteLine("[Strings] Hello World!");
            Console.WriteLine("[Strings] The current time is " + DateTime.Now);
        }
        static void WorkingWithIntgers()
        {
            int a = 15;
            int b = 10;
            int c = a + b;
            System.Console.WriteLine($"[Integers] {c}");
            System.Console.WriteLine($"[Integers] Hello, this is my template literal {c}");


        }
        static void IntegerLimits()
        {
            int min = int.MinValue;
            int max = int.MaxValue;
            int what = max + 3;
            int wat = min + 2;

            System.Console.WriteLine($"[Integer Limits] The minimum value is {min} and the maximum value is {max}.");
            System.Console.WriteLine($"[Integer Limits] What is this {what}?");
            System.Console.WriteLine($"[Integer Limits] Waaaaat {wat}");
            System.Console.WriteLine($"[Integer Limits] {what == wat}");
        }

        static void Double()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine($"[Double] {d}");

            double e = 19;
            double f = 23;
            double g = 9;
            double h = (e + f) / g;
            Console.WriteLine($"[Double] {h}");

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        static void Decimal()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        static void AreaOfACircle()
        {
            double radius = 2.5;
            double area = Math.PI * radius * radius;
            System.Console.WriteLine(area);
        }
        
        static void Main(string[] args)
        {
            WorkingWithIntgers();
            WorkingWithStrings();
            IntegerLimits();
            Double();
            Decimal();
            AreaOfACircle();
        }
    }
}
