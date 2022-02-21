using Business.Abstract;
using Business.Costants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColourManager: IColourService
    {
        IColourDal _colourDal;
        public ColourManager(IColourDal colourDal)
        {
            _colourDal = colourDal;
        }

        public IResult Add(Colour colour)
        {
            _colourDal.Add(colour);
            return new SuccessResult(Message.AddColour);
        }

        public IDataResult<List<Colour>> GetAllColours()
        {
            return new SuccessDataResult<List<Colour>>(_colourDal.GetAll(),Message.GetAllColoursMessage);
        }

        public IResult RemoveColour(Colour colour)
        {
            _colourDal.Delete(colour);
            return new SuccessResult(Message.RemoveColour);
        }
    }
}
