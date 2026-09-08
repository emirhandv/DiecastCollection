using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete
{
    public class InMemoryModelCarDal : IModelCarDal
    {
        List<ModelCar> _modelCars;
        public InMemoryModelCarDal()
        {
            _modelCars = new List<ModelCar> {
               new ModelCar{ModelId="1",ModelName="A3",ModelColor="Red",BrandId="1"},
                new ModelCar{ModelId="2",ModelName="A4",ModelColor="Blue",BrandId="1"},
                new ModelCar{ModelId="3",ModelName="Civic",ModelColor="Black",BrandId="2"},
                new ModelCar{ModelId="4",ModelName="Accord",ModelColor="White",BrandId="2"},
                new ModelCar{ModelId="5",ModelName="Corolla",ModelColor="Silver",BrandId="3"},
                new ModelCar{ModelId="6",ModelName="Camry",ModelColor="Gray",BrandId="3"},
                new ModelCar{ModelId="7",ModelName="Mustang",ModelColor="Yellow",BrandId="4"},
                 new ModelCar{ModelId="8",ModelName="F30",ModelColor="Green",BrandId="4"},
             };
        }

        public void Add(ModelCar car)
        {
            _modelCars.Add(car);
        }

        public void Delete(ModelCar car)
        {
            ModelCar carToDelete = _modelCars.SingleOrDefault(c => c.ModelId == car.ModelId);
            _modelCars.Remove(carToDelete);
        }

        public List<ModelCar> GetAll()
        {
            return _modelCars;
        }

        public List<ModelCar> GetById(string id)
        {
            return _modelCars.Where(c => c.ModelId == id).ToList();
        }

        public void Update(ModelCar car)
        {
            ModelCar carToUpdate = _modelCars.SingleOrDefault(c => c.ModelId == car.ModelId);
            carToUpdate .ModelName = car.ModelName;
            carToUpdate.ModelColor = car.ModelColor;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
