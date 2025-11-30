using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory
{
   public class AbstractFactory
   {
       abstract class Car
       {
           public abstract void Info();
       }


       class Ford : Car
       {
           public override void Info()
           {
               Console.WriteLine("Ford");
           }
       }


       class Toyota : Car
       {
           public override void Info()
           {
               Console.WriteLine("Toyota");
           }
       }


       class Mersedes : Car
       {
           public override void Info()
           {
               Console.WriteLine("Mersedes");
           }
       }


       abstract class Engine
       {
           public virtual void GetPower()
           {
           }
       }


       class FordEngine : Engine
       {
           public override void GetPower()
           {
               Console.WriteLine("Ford Engine 4.4");
           }
       }


       class ToyotaEngine : Engine
       {
           public override void GetPower()
           {
               Console.WriteLine("Toyota Engine 3.2");
           }
       }


       class MersedesEngine : Engine
       {
           public override void GetPower()
           {
               Console.WriteLine("Mersedes engine");
           }
       }


       interface ICarFactory
       {
           Car CreateCar();
           Engine CreateEngine();
       }


       class FordFactory : ICarFactory
       {
           Car ICarFactory.CreateCar()
           {
               return new Ford();
           }
           Engine ICarFactory.CreateEngine()
           {
               return new FordEngine();
           }
       }


       class ToyotaFactory : ICarFactory
       {
           Car ICarFactory.CreateCar()
           {
               return new Toyota();
           }
           Engine ICarFactory.CreateEngine()
           {
               return new ToyotaEngine();
           }
       }


       class MersedesFactory : ICarFactory
       {
           Car ICarFactory.CreateCar()
           {
               return new Mersedes();
           }
           Engine ICarFactory.CreateEngine()
           {
               return new MersedesEngine();
           }
       }


       static void Main(string[] args)
       {
           ICarFactory carFactory = new ToyotaFactory();
           Car myCar = carFactory.CreateCar();
           myCar.Info();
           Engine myEngine = carFactory.CreateEngine();
           myEngine.GetPower();


           carFactory = new FordFactory();
           myCar = carFactory.CreateCar();
           myCar.Info();
           myEngine = carFactory.CreateEngine();
           myEngine.GetPower();


           carFactory = new MersedesFactory();
           myCar = carFactory.CreateCar();
           myCar.Info();
           myEngine = carFactory.CreateEngine();
           myEngine.GetPower();


           Console.ReadKey();
       }}
}
