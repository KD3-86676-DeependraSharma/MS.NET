using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign02_Que_01
{
    internal struct  Students
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }


        public char Div
        {
            get { return div; }
            set { div = value; }
        }


        public int Std
        {
            get { return std; }
            set { std = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Students(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Student Name :");
            string name=Console.ReadLine();

            Console.WriteLine("Enter Student Gender :");
            bool gender = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter Student Age :");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Standered :");
            int std = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Div :");
            char div=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Student Marks :");
            double marks = Convert.ToDouble(Console.ReadLine());

        }

        public void PrintDetails()
        {
            Console.WriteLine(name.ToString() + " " + gender.ToString() + " " + age.ToString() + " " + std.ToString() + " " + div.ToString() + " " + marks.ToString());  
        }

    }


        internal class Program
        {

            #region this are the four static methods which will get the ref of the local variable list 
            public static void CreateArray(ref Students[] list)
            {
                Console.WriteLine("enter the size of array ");
                int size = Convert.ToInt32(Console.ReadLine());
                list = new Students[size];
            }

            public static void AcceptInfo(ref Students[] list)
            {
                int size = list.Length;
                for (int i = 0; i < size; i++)
                {
                    Students st = new Students();
                    st.AcceptDetails();
                    list[i] = st;
                }

            }

            public static void PrintArray(ref Students[] list)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    Console.WriteLine(list[i].PrintDetails());
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

            public static void ReverseArray(ref Students[] list)
            {
                Students[] Reversed = new Students[list.Length];
                int count = 0;
                for (int i = list.Length - 1; i > -1; i--)
                {
                    Reversed[count++] = list[i];
                }

                for (int j = 0; j < list.Length; j++)
                {
                    list[j] = Reversed[j];
                }
            }
            #endregion



            static void Main(string[] args)
            {
                Students [] StudentList = null;

                CreateArray(ref StudentList); // to pass the reference of the local vairable created inside the main method 
                                              // we need to pass it with  the ref key word means we are passing the reference of hte 
                                              // studentlist 
                Console.WriteLine("array created");
                AcceptInfo(ref StudentList);
                Console.WriteLine("info accepted");
                PrintArray(ref StudentList);

                ReverseArray(ref StudentList);
                Console.WriteLine("Array reversed ");
                PrintArray(ref StudentList);
                Console.ReadLine();

            }
        }

    }
