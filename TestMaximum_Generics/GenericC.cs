﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum_Generics
{
    //Refactor2- Generic Class
    public class GenericC<T> where T: IComparable
    {
        public T num1;
        public T num2;
        public T num3;
        //parameter constructor
        public GenericC(T num1, T num2, T num3) 
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        public static T Value(T num1, T num2, T num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        public T TestMaxiumum() 
        {
            T obj = GenericC<T>.Value(this.num1, this.num2, this.num3);
            return obj;

        }
    }
}
