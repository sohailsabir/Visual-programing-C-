using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec_no_3
{
  public  class car
    {
      public string name;
     public string color;
     public int model;

     public void car_info()
      {
          Console.WriteLine(" Enter Name of car:");
          name = Console.ReadLine();
          Console.WriteLine(" Enter color of car:");
          color = Console.ReadLine();
          Console.WriteLine(" Enter model of car:");
          model = int.Parse(Console.ReadLine());
      }
    }
  class honda : car
  {
      public int mileage;
      public void input1()
      {
          Console.WriteLine(" Enter Mileage of car:");
          mileage = int.Parse(Console.ReadLine());
      }
    public  void honda_dis()
      {
          Console.WriteLine("Mileage of honda:" + mileage);
      }
  }
  class BMW : car
  {
      public int mileage;
      public void input2()
      {
          Console.WriteLine(" Enter Mileage of car:");
          mileage = int.Parse(Console.ReadLine());
      }
      public void bmw_dis()
      {
          Console.WriteLine("Mileage of BMW:" + mileage);
      }
  }
  class Toyota : car
  {
      public int mileage;
      public void input3()
      {
          Console.WriteLine(" Enter Mileage of car:");
          mileage = int.Parse(Console.ReadLine());
      }
      public void toyota_dis()
      {
          Console.WriteLine("Mileage of Toyota:" + mileage);
      }
  }
  class Suzuki : car
  {
      public int mileage;
      public void input4()
      {
          Console.WriteLine(" Enter Mileage of car:");
          mileage = int.Parse(Console.ReadLine());
      }
      public void suzuki_dis()
      {
          Console.WriteLine("Mileage of Suzuki:" + mileage);
      }
  }
}
