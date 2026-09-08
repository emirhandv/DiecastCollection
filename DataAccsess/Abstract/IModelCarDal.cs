using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Abstract
{
    public interface IModelCarDal
    {
        public List<ModelCar> GetAll();
        public List<ModelCar> GetById(string id);
        public void Add(ModelCar car);
        public void Delete(ModelCar car);
        public void Update(ModelCar car);
    }
}
