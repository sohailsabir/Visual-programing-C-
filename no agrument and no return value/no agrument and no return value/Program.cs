using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no_agrument_and_no_return_value
{
   public class Program1
    {
       int a, b, r;
       public void nameDisply()
       {
           Console.WriteLine("Muhammad Sohail Sabir");
           Console.ReadLine();
       }
       public void input()
       {
           Console.WriteLine("Enter First Number:");
           a = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter Second Number:");
           b = int.Parse(Console.ReadLine());
       }
       public void add()
       {
           r = a + b;
           Console.WriteLine("The Sum of Two number is :" + r);
           Console.ReadLine();
       }
       public void max()
       {
           if(a>b)
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
      
      
       public void findEvenOdd()
       {
           if(a%2==0)
           {
               Console.WriteLine(a+" is Even Number.");
               Console.ReadLine();
           }
           else
           {
               Console.WriteLine(a+" is Odd Number.");
               Console.ReadLine();
           }
           if(b%2==0)
           {
               Console.WriteLine(b+" is Even Number.");
               Console.ReadLine();

           }
           else
           {
               Console.WriteLine(b+" is Odd Number.");
               Console.ReadLine();
           }
       }
       public void swap()
       {
            Console.WriteLine("Before Swapping");
               Console.WriteLine("a="+a);
           Console.WriteLine("b="+b);
           a = a + b;
           b = a - b;
           a = a - b;
           Console.WriteLine("After Swapping");
               Console.WriteLine("a="+a);
           Console.WriteLine("b="+b);
           Console.ReadLine();
       }
       public void printline()
       {
           Console.WriteLine("Value 0 to 20:");
           int i;
           for(i=0;i<=20;i++)
           {
               Console.Write(i+" ");
           }
           Console.ReadLine();
       }
       static void Main(string[] args)
       {
           Program1 ob1= new Program1();
           ob1.nameDisply();
           ob1.input();
           ob1.add();
           ob1.max();
            ob1.findEvenOdd();
           ob1.swap();
           ob1.printline();

       }
        
    }
    
}
