using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01_Que_3
{
    internal class Program
    {
        //public static int Menu()//it also run
        //private static int Menu()
        //private int Menu()
        public static int Menu()
        {
            Console.WriteLine("0. EXIT");
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. SUB");
            Console.WriteLine("3. MUL");
            Console.WriteLine("4. Div");
            Console.WriteLine("Enter your Choice :");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int choice=Menu();
                if (choice == 0)
                {
                    Console.WriteLine("Thank you for using our Application");
                    break;
                }
                Console.WriteLine("Enter 1st Number :");
                int x= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number :");
                int y = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            int add = x + y;
                            Console.WriteLine("Addtion :"+add);
                            break;  
                        }
                    case 2:
                        {
                            int add = x - y;
                            Console.WriteLine("Subtraction :" + add);
                            break;
                        }
                    case 3:
                        {
                            int add = x * y;
                            Console.WriteLine("Multiplication :" + add);
                            break;
                        }
                    case 4:
                        {
                            int add = x / y;
                            Console.WriteLine("Division :" + add);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong Choice ...");
                            break;
                        }
                }
            }
        }
    }
}
