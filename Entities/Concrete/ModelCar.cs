using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ModelCar: IEntity
    {
        public string ModelId { get; set; }
        public string ModelName { get; set; }
        public string ModelColor { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string BrandId { get; set; }
    }
}
