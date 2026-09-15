using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ModelCarManager : IModelCarService
    {
        IModelCarDal _modelCarDal;
        public ModelCarManager(IModelCarDal modercaldal)
        {
            _modelCarDal = modercaldal;
        }

        public void Add(ModelCar modelCar)
        {
            if (modelCar.ModelName.Length < 2)
            {
                throw new Exception("Model name must be at least 2 characters long.");
            }

            if (modelCar.Price < 0)
            {
                throw new Exception("Price cannot be negative.");
            }

            if (modelCar.ModelColor is null)
            {
                throw new Exception("Model color cannot be null.");
            }

            Console.WriteLine("Başarıyla Eklenmiştir.");
            _modelCarDal.Add(modelCar);
        }

        public void Delete(ModelCar modelCar)
        {
            // KURAL: Eğer arabanın stoğu varsa sistemden silinmesini engelle.
            if (modelCar.Stock > 0)
            {
                throw new Exception("Stoğu bulunan bir aracı silemezsiniz. Lütfen önce stoğu sıfırlayın.");
            }

            Console.WriteLine("Başarıyla Silinmiştir.");
            // Kuraldan başarıyla geçerse veri tabanından (DataAccess) sil
            _modelCarDal.Delete(modelCar);
        }

        public List<ModelCar> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                throw new Exception("Sistem bakımda. Lütfen daha sonra tekrar deneyin.");
            }

            return _modelCarDal.GetAll();
        }

        public List<ModelCar> GetById(string id)
        {
            if (id is null)
            {
                throw new Exception("ID cannot be null.");
            }
            return _modelCarDal.GetById(id);
        }

        public void Update(ModelCar modelCar)
        {
            if (modelCar.ModelName.Length < 2)
            {
                throw new Exception("Model name must be at least 2 characters long.");
            }
            if (modelCar.Price < 0)
            {
                throw new Exception("Price cannot be negative.");
            }
            if (modelCar.ModelColor is null)
            {
                throw new Exception("Model color cannot be null.");
            }
            if (modelCar.Stock < 0)
            {
                throw new Exception("Stock cannot be negative.");
            }

            Console.WriteLine("Başarıyla güncellenmiştir.");

            _modelCarDal.Update(modelCar);
        }
    }
}
