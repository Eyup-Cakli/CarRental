using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<CarDetailDto> GetCarDetails();
        List<Car> GetAll();
        List<Car> GetByDailiyPrice(decimal min, decimal max);
        public void Add(Car car);
        public void Delete(Car car);
        public void Update(Car car);
    }
}
