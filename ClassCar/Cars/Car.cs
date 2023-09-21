using System;
using ClassCar.Cars;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCar.Cars
{
    public partial class Car
    {
        private string make;
        private string model;
        private int year;
        private double engineSize;
        private bool isRunning;

        private static int numberOfCars;
        private static string company = "MyCarCompany";


        public Car()
        {
            numberOfCars++;
        }

        public Car(string make, string model, int year, double engineSize)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.engineSize = engineSize;
            numberOfCars++;
        }
        static Car()
        {
            numberOfCars = 0;
        }
        public string GetMake()
        {
            return make;
        }

        public void SetMake(string make)
        {
            this.make = make;
        }

        public string GetModel()
        {
            return model;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public int GetYear()
        {
            return year;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

        public double GetEngineSize()
        {
            return engineSize;
        }

        public void SetEngineSize(double engineSize)
        {
            this.engineSize = engineSize;
        }
        public void Start()
        {
            isRunning = true;
            Console.WriteLine("Автомобиль запущен.");
        }

        public void Stop()
        {
            isRunning = false;
            Console.WriteLine("Автомобиль остановлен.");
        }

        public void Drive()
        {
            if (isRunning)
            {
                Console.WriteLine("Автомобиль двигается.");
            }
            else
            {
                Console.WriteLine("Сначала запустите автомобиль.");
            }
        }

        public static int GetNumberOfCars()
        {
            return numberOfCars;
        }

        public static string GetCompany()
        {
            return company;
        }
    }

}
