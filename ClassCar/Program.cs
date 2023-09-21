using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCar.Cars
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество мест в Автопарке");
            int capacity = Int32.Parse(Console.ReadLine());
            Car[] cars = new Car[capacity];
            Menu.firstMenu(capacity,cars);
        }
    }
}
