using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { CarId = 6, BrandId = 2, ColorId = 1, CarModelYear = 2022, CarDailyPrice = 940, CarDescription = "F30" });
            Console.WriteLine("DTO Test\n");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Car ID : "+car.CarId+"  Marka : "+car.BrandName+"  Model : "+car.CarDescription+"  Yıl : "+car.CarModelYear+"  Ücret : "+car.CarDailyPrice+"  Renk : "+car.ColorName);
            }
        }
    }
}
