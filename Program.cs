using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boxing 
            int num1 = 2020;
            object obj = num1;
            num1 = 200;
            Console.WriteLine("Boxing: ");
            Console.WriteLine("Value-type of num is: "+num1);
            Console.WriteLine("Ref-type of num is: " + obj+'\n');

            //unboxing
            Console.WriteLine("UnBoxing: ");
            int num2 = 23;
            Object obj2 = num2;
            int i=(int)obj2;
            Console.WriteLine("Value-type of i is: " + num2);
            Console.WriteLine("Ref-type of obj2 is: " + obj2);
        }
    }
}
