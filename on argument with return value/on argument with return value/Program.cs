using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_argument_with_return_value
{
    class Program
    {
        int a, b, r;
        public void input()
        {
            Console.WriteLine("Enter First Number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            b = int.Parse(Console.ReadLine());
        }
        public int add()
        {
           
            r = a + b;
            return r;
        }
       
        public int max()
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public bool leapyear()
        {
            int y;
            Console.WriteLine("Enter a year to check it is leap year or not:");
            y = int.Parse(Console.ReadLine());
            if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Mod()
        {
            int n1, n2;
            Console.WriteLine("To find mod of two number");
            Console.WriteLine("Enter first number:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            n2 = int.Parse(Console.ReadLine());
            int rem = n1 % n2;
            return rem;
        }
        public bool prime()
        {
            Console.WriteLine("To chek Prime Number");
            Console.WriteLine("Enter a number");
            int n, a = 0;
            n = int.Parse(Console.ReadLine());
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
            ob.input();
            
            int a1=ob.add();
            Console.WriteLine("The result is "+a1);
            Console.ReadLine();

            int a2 = ob.max();
            Console.WriteLine("The max number is  " + a2);
            Console.ReadLine();

           bool a3 = ob.leapyear();
            if (a3==true)
            {
                Console.WriteLine("Leap year");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Not Leap year");
                Console.ReadLine();
            }

            int a4 = ob.Mod();
            Console.WriteLine("The result is " + a4);
            Console.ReadLine();
           bool a5= ob.prime();
            if(a5==true)
            {
                Console.WriteLine("Prime Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not prime number");
                Console.ReadLine();
            }
        }
    }
}
