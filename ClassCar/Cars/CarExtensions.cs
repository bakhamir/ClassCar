using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCar.Cars
{
    public partial class Car
    {
        public void Honk()
        {
            Console.WriteLine("Бип-бип! Поднимите ваши окна.");
        }
        public static void CreateCar(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                {
                    Console.Write("Введите марку автомобиля: ");
                    string make = Console.ReadLine();
                    Console.Write("Введите модель автомобиля: ");
                    string model = Console.ReadLine();
                    Console.Write("Введите год выпуска: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.Write("Введите объем двигателя: ");
                    double engineSize = double.Parse(Console.ReadLine());
                    cars[i] = new Car(make, model, year, engineSize);
                    Console.WriteLine("Автомобиль создан.");
                }
            }

            Menu.firstMenu(cars.Length,cars);
        }

        public static void StartCar(Car[] cars)
        {
            Console.Write("Введите номер автомобиля, который вы хотите запустить: ");
            int carNumber = int.Parse(Console.ReadLine());

            if (carNumber >= 0 && carNumber < cars.Length && cars[carNumber] != null)
            {
                cars[carNumber].Start();
            }
            else
            {
                Console.WriteLine("Неверный номер автомобиля.");
            }
        }

        public static void StopCar(Car[] cars)
        {
            Console.Write("Введите номер автомобиля, который вы хотите остановить: ");
            int carNumber = int.Parse(Console.ReadLine());

            if (carNumber >= 0 && carNumber < cars.Length && cars[carNumber] != null)
            {
                cars[carNumber].Stop();
            }
            else
            {
                Console.WriteLine("Неверный номер автомобиля.");
            }
        }

        public static void DriveCar(Car[] cars)
        {
            Console.Write("Введите номер автомобиля, на котором вы хотите двигаться: ");
            int carNumber = int.Parse(Console.ReadLine());

            if (carNumber >= 0 && carNumber < cars.Length && cars[carNumber] != null)
            {
                cars[carNumber].Drive();
            }
            else
            {
                Console.WriteLine("Неверный номер автомобиля.");
            }
        }

        public static void CarInfo(Car[] cars)
        {
            Console.Write("Введите номер машины о которой хотели бы узнать");
            int carNumber = int.Parse(Console.ReadLine());

            if (carNumber >= 0 && carNumber < cars.Length && cars[carNumber] != null)
            {
                Console.WriteLine("модель - {0} марка - {1}, год выпуска - {2}, обьем двигателя - {3}",
                    cars[carNumber].GetMake(), cars[carNumber].GetModel(), cars[carNumber].GetYear(), cars[carNumber].GetEngineSize());
            }
            else
            {
                Console.WriteLine("Неверный номер автомобиля.");
            }
        }
        public static void AllCars(Car[] cars)
        {
            if(cars.Length > 0){
                for (int i = 0; i < cars.Length; i++)
                {
                    Console.WriteLine("{4}) модель - {0} марка - {1}, год выпуска - {2}, обьем двигателя - {3}",cars[i].GetMake(), cars[i].GetModel(),
                        cars[i].GetYear(), cars[i].GetEngineSize(),i);
                }

            }
            else
            {
                Console.WriteLine("Неверный номер автомобиля.");
            }
        }
    }
}
