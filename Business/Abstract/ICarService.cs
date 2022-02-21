using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult AddCar(Car car);
        IDataResult<List<Car>>GetAllCars();
        IDataResult<List<Car>> GetAllCarsByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetDetails();
        IResult RemoveCar(Car car);
        IResult UpdateCar(Car car);




    }
}
