using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult AddBrand(Brand brand);
        IDataResult<List<Brand>> GetAllBrands();
        IDataResult<Brand> GetByBrandId(int id);
        IResult DeleteBrand(Brand brand);
        IResult UpdateBrand(Brand brand);
    }
}
