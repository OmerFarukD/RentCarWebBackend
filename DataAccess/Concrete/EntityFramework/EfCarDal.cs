using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entity.Concrete;
using Entity.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityDal<Car, RentContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentContext context=new RentContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join r in context.Colours on c.ColourId equals r.ColourId
                             
                             select new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName,ColourName=r.ColourName,DailyPrice=c.DailyPrice};
                return result.ToList();
            }
        }
    }
}
