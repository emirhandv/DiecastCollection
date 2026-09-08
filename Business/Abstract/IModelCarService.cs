using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IModelCarService
    {
        public List<ModelCar> GetAll();
        public List<ModelCar> GetById(string id);
        public void Add(ModelCar modelCar);
        public void Update(ModelCar modelCar);
        public void Delete(ModelCar modelCar);


    }
}
