using DemoNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Access Modifiers
            #region public - class,class all members

            //Car bmw = new Car("BMW", "X5", "black", 240);
            //bmw.MaxSpeed = 300;
            //Console.WriteLine(bmw.Info());
            #endregion

            #region private - all class members
            //Car car = new Car("BMW", "X5");
            //car.MaxSpeed = -200;
            //Console.WriteLine(car.Brand);

            //car.SetMaxSpeed(-200);
            //Console.WriteLine(car.GetMaxSpeed());

            #endregion

            #region protected - all class memmbers
            //Car car = new Car("BMW", "X5", "black", 240,1000);
            //Console.WriteLine(car.Info());
            #endregion

            #region public readonly - field
            //Car car = new Car("BMW", "X5", "black", 240, 1000);
            //Console.WriteLine(car.HorsePower);
            #endregion

            #region private readonly - field
            //Car car = new Car("BMW", "X5", "black", 240, 1000);
            //Console.WriteLine(car.Info());
            #endregion
            #endregion

            #region Namespace
            //Car car1 = new Car();
            //Test.Car car2 = new Test.Car();
            //DemoNS.Car car = new DemoNS.Car();
            //DemoNS.Student stu = new DemoNS.Student();
            //Student stu = new Student();
            #endregion
        }
    }
}

namespace Test
{
    class Car { }
}
