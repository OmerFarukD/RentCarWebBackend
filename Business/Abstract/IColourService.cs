using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
public interface IColourService
    {
        IResult Add(Colour colour);
        IDataResult<List<Colour>> GetAllColours();
        IResult RemoveColour(Colour colour);

    }
}
