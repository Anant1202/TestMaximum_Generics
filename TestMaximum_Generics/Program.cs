using System;

namespace TestMaximum_Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Program");
            FindMax ob1 = new FindMax();
            Console.WriteLine("Maximum number is : "+ob1.IntMax(5, 8, 2));
        }

    }
}

