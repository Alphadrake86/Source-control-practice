using System;

namespace Source_control_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1(3);
            Class1 b = new Class1(123456789);
            Console.WriteLine("Hello!" + a.number + " " + b.number);
        }
    }
}
