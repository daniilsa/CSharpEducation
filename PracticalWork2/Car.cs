using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    class Car
    {
        string brand;
        public Car(string brand)
        {
            this.brand = brand;
        }
        /// <summary>
        /// Информация о автомобиле
        /// </summary>
        /// <param name="car"></param>
        public void GetInfo(Car car)
        {
            Console.WriteLine("Информация о автомобиле \"" + car.brand + "\": Информация отсутсвует");
        }
    }
}
