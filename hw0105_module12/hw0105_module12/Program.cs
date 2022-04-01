using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw0105_module12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car carData = new Car();
            carData.brand="Toyota";
            carData.speed=60;
            carData.age=6;
            Console.WriteLine(carData.age);
           

        }
    }
    class Car
    {
        public string brand;
        public int speed;
        private int _age = 50;
        public int age
        {
            get // 把return _age; 傳回給 age
            {
                return _age;
            }
            set // 把_age = value;傳回給age
            {
                _age = value;
            }
        }
       
    }
}
