using Business.Concrete;
using DataAccsess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ModelCarManager modelCarManager = new ModelCarManager(new InMemoryModelCarDal());

            Console.WriteLine("--------------------------");

            Console.WriteLine("Yeni Araç Ekleme");
            try
            {
                ModelCar car1 = new ModelCar { ModelName = "M4", ModelColor = "Grey", Price = 100000, Stock = 0 };
                modelCarManager.Add(car1);
                Console.WriteLine("Arabanız başarıyla eklenmiştir.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("--------------------------");

            
            Console.WriteLine("-----KOLEKSİYON ARAÇLARI-----");
            foreach (var modelcar in modelCarManager.GetAll())
            {
                Console.WriteLine("Model Name: " + modelcar.ModelName + "   Model Rengi: " + modelcar.ModelColor + "   Stok Adedi: " + modelcar.Stock + "   Fiyati: " + modelcar.Price);
            }

            Console.WriteLine("--------------------------");

            

            Console.ReadLine();

        }
    }
}
