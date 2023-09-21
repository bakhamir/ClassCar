using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassCar.Cars
{
    public class Menu
    {

        public static void firstMenu(int capacity, Car[] cars)
        {
            
            Console.Clear();
            Console.WriteLine("Меню:");
            Console.WriteLine("Количество мест в Автопарке {0}", cars.Length);
            Console.WriteLine("1. Заполнить Автопарк");
            Console.WriteLine("2. Запустить автомобиль");
            Console.WriteLine("3. Остановить автомобиль");
            Console.WriteLine("4. Двигаться на автомобиле");
            Console.WriteLine("5. Информация об автомобиле");
            Console.WriteLine("6. Информация о всех автомобилях");
            Console.WriteLine("7. Выйти");

            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Car.CreateCar(cars);
                    break;
                case "2":
                    Car.StartCar(cars);
                    break;

                case "3":
                    Car.StopCar(cars);
                    break;

                case "4":
                    Car.DriveCar(cars);
                    break;

                case "5":
                    Car.CarInfo(cars);
                    break;
                case "6":
                    Car.AllCars(cars);
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    break;
                case "7":
                    Environment.Exit(0);
                    break;


            }

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }

}
    