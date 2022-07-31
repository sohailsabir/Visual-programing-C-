using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace argument_and_return_type
{
    class Program
    {
        public string nameDisply(string name)
        {
            string n;
            n = name;
            return n;
        }
        public int max(int n1, int n2)
        {
            int a, b;
            a = n1;
            b = n2;
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public bool leapyear(int year)
        {
            int y = year;
            if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool findEvenOdd(int e)
        {
            int a = e;
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool prime(int p )
        {
            
            int n=p, a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;

            }
            else
            {
                return false;
            }


        }
        static void Main(string[] args)
        {
            Program ob = new Program();

            string name;
            Console.WriteLine("Enter your Name:");
            name = Console.ReadLine();
            Console.WriteLine(ob.nameDisply(name));
            Console.ReadLine();

            int a1, a2;
            Console.WriteLine("To check which number is Greater");
            Console.WriteLine("Enter first number");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The Greater Number is: " + ob.max(a1, a2));
            Console.ReadLine();

            int year;
            Console.WriteLine("Enter year to check is leap year or not");
            year = int.Parse(Console.ReadLine());
            bool a3 = ob.leapyear(year);
            if (a3 == true)
            {
                Console.WriteLine("Leap year");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Not Leap year");
                Console.ReadLine();
            }

            int a4;
            Console.WriteLine("Enter number to check it is even or not:");
            a4 = int.Parse(Console.ReadLine());
            bool a5 = ob.findEvenOdd(a4);
            if (a5 == true)
            {
                Console.WriteLine("Even Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Odd Number");
                Console.ReadLine();
            }


            int a6;
            Console.WriteLine("Enter number to check it is prime or not:");
            a6= int.Parse(Console.ReadLine());
            bool a7 = ob.findEvenOdd(a6);
            if (a7 == true)
            {
                Console.WriteLine("prime Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" prime Number");
                Console.ReadLine();
            }


            



        }
    }
}
