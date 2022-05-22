using System;

namespace TestMaximum_Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Program");
            FindMax ob1 = new FindMax();
            Console.WriteLine("Maximum Integer Number is : " + ob1.IntMax(5, 8, 2));
            Console.WriteLine("Maximum Float Number is :" + ob1.FloatMax(3.25f, 5.67f, 8.12f));
            Console.WriteLine("Maximum String Value is :" + ob1.StringMax("Apple","Peach","Banana"));
        }

    }
}

