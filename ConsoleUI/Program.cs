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

            ModelCar car1 = new ModelCar { ModelId = "10", ModelName = "m4", ModelColor = "Grey", Price = 100000000, Stock = 0 };
            ModelCar car2 = new ModelCar { ModelId = "11", ModelName = "m3", ModelColor = "Black", Price = 80000000, Stock = 0 };
            ModelCar car3 = new ModelCar { ModelId = "12", ModelName = "m2", ModelColor = "White", Price = 60000000, Stock = 10 };

            Console.WriteLine("--------------------------");

            Console.WriteLine("İŞLEMLER");
            try
            {
                modelCarManager.Add(car1);
                Console.WriteLine("--------");
                modelCarManager.Add(car2);
                Console.WriteLine("--------");
                modelCarManager.Delete(car2);
                Console.WriteLine("--------");
               


            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }





            Console.WriteLine("--------------------------");

            Console.WriteLine("                 ");
            Console.WriteLine("-----GÜNCEL KOLEKSİYON ARAÇLARI-----");
            foreach (var modelcar in modelCarManager.GetAll())
            {
                Console.WriteLine("Model Name: " + modelcar.ModelName + "   Model Rengi: " + modelcar.ModelColor + "   Stok Adedi: " + modelcar.Stock + "   Fiyati: " + modelcar.Price);
            }

            Console.WriteLine("--------------------------");



            Console.ReadLine();

        }
    }
}
