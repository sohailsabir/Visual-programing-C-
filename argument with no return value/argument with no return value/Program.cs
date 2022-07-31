using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace argument_with_no_return_value
{
   public class Program
    {
       public void nameDisply(string name)
       {
           string n;
           n = name;
           Console.WriteLine(n);
           Console.ReadLine();
       }
       public void swap(int a, int b)
       {
           int n1, n2;
           n1 = a;
           n2 = b;
           Console.WriteLine("Before Swapping");
           Console.WriteLine("n1=" + n1);
           Console.WriteLine("n2=" + n2);
           n1 = n1 + n2;
           n2 = n1 - n2;
           n1 = n1 - n2;
           Console.WriteLine("After Swapping");
           Console.WriteLine("n1=" + n1);
           Console.WriteLine("n2=" + n2);
           Console.ReadLine();
       }
       public void printlist(int start,int end)
       {
           int i;
           int n = end;
           Console.WriteLine("Value 0 to 20:");
           for (i=start; i <= n; i++)
           {
               Console.Write(i + " ");
           }
           Console.ReadLine();
       }
       public void max(int n1,int n2)
       {
           int a, b;
           a = n1;
           b=n2;
           if (a > b)
           {
               Console.WriteLine("The Greater number is :" + a);
               Console.ReadLine();
           }
           else
           {
               Console.WriteLine("The Greater number is :" + b);
               Console.ReadLine();
           }
       }
       public void leapyear(int year)
       {
           int y = year;
           if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
           {
               Console.WriteLine(y + " is leap year");
               Console.ReadLine();
           }
           else
           {
               Console.WriteLine(y + " is not leap year");
               Console.ReadLine();
           }
       }
       public void findEvenOdd(int e)
       {
           int a = e;
           if (a % 2 == 0)
           {
               Console.WriteLine(a + " is Even Number.");
               Console.ReadLine();
           }
           else
           {
               Console.WriteLine(a + " is Odd Number.");
               Console.ReadLine();
           }
          
       }
        static void Main(string[] args)
        {
            Program ob1 = new Program();
            ob1.nameDisply("Muhammad Sohail Sabir");

            int a, b;
            Console.WriteLine("Enter first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b = int.Parse(Console.ReadLine());
            ob1.swap(a, b);

            Console.WriteLine("List Show");
            int st, en;
            Console.WriteLine("Enter starting  number:");
            st = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending  number:");
            en= int.Parse(Console.ReadLine());
            ob1.printlist(st, en);

            Console.WriteLine("To Check Which Number is Greater");
            int a1, b1;
            Console.WriteLine("Enter first number:");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b1 = int.Parse(Console.ReadLine());
            ob1.max(a1,b1);

            int year;
            Console.WriteLine("Enter year to check is leap year or not");
            year = int.Parse(Console.ReadLine());
            ob1.leapyear(year);

            int a3;
            Console.WriteLine("Enter number to check it is even or not:");
            a3 = int.Parse(Console.ReadLine());
            ob1.findEvenOdd(a3);
 
        }
    }
}
