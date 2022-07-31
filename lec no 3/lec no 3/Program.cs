using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec_no_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            honda h = new honda();
            BMW b = new BMW();
            Toyota t = new Toyota();
            Suzuki s = new Suzuki();

            h.car_info();
            h.input1();
            h.honda_dis();

            b.car_info();
            b.input2();
            b.bmw_dis();

            t.car_info();
            t.input3();
            t.toyota_dis();

            s.car_info();
            s.input4();
            s.suzuki_dis();


            
            Console.ReadLine();
        }
    }
}
