using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        private int _maxSpeed=240;
        //protected int HorsePower;
        //public readonly int HorsePower=2000;
        private readonly int HorsePower = 2000;

        //public void SetHp(int hp)
        //{
        //    HorsePower = hp;
        //}
        //encapsulation
        //property
        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if (value > 0 && value <= 400)
                {
                    _maxSpeed = value;
                }
                else
                {
                    Console.WriteLine("Dogru suret daxil edin!!!");
                }
            }
        }

        //public void SetMaxSpeed(int speed)
        //{
        //    if(speed>0 && speed <= 400)
        //    {
        //        _maxSpeed = speed;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Dogru suret daxil edin!!!");
        //    }
        //}

        //public int GetMaxSpeed()
        //{
        //    return _maxSpeed;
        //}

        public Car()
        {
            Console.WriteLine("Modifiers Car");
        }

        public Car(string brand,string model)
        {
            Brand = brand;
            Model = model;
        }

        public Car(string brand, string model,string color,int speed,int hp):this(brand,model)
        {
            Color = color;
            _maxSpeed = speed;
            HorsePower = hp;
        }

        public virtual string Info()
        {
            return $"{Brand} {Model} {Color} {_maxSpeed} {HorsePower}";
        }

        protected void testMethod()
        {

        }
    }
}
