using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_01_Que_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number :");
            int num1=int.Parse(Console.ReadLine());
            //int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1st number :");
            int num2 = int.Parse(Console.ReadLine());
            //int num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose Operator {+,-,*,/} :");
            char choice = Console.ReadKey().KeyChar;

            switch (choice) {
                case '+':
                    { 
                        int x=num1 + num2;
                        Console.WriteLine("Addition :"+x);
                        break;
                    }
                case '-':
                    {
                        int x = num1 - num2;
                        Console.WriteLine("Subtractiom :" + x);
                        break;
                    }
                case '*':
                    {
                        int x = num1 * num2;
                        Console.WriteLine("Multiplication :" + x);
                        break;
                    }
                case '/':
                    {
                        int x = num1 / num2;
                        Console.WriteLine("Division :" + x);
                        break;
                    }


            }
        }
    }
}
