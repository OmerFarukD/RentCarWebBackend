using Business.Abstract;
using Business.Costants;
using Core.Helpers;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService    
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;
        public CarImageManager(ICarImageDal carImageDal,IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }
        public IResult Add(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Message.ImageUploaded);
        }

        public IResult Delete(CarImage carImage)
        {
            _fileHelper.Delete(PathConstants.ImagesPath+carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Message.ImageRemoved);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(),Message.ImagesListed);
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int id)
        {
            var result = BusinessRules.Run(CheckImage(id));
            if (result!=null)
            {
                return new ErrorDataResult<List<CarImage>>(GetDefaultImage(id).Data);
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(i=>i.CarId==id));
        }

        public IDataResult<CarImage> GetByImageId(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(i=>i.Id==id));
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + carImage.ImagePath, PathConstants.ImagesPath);
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }
        private IResult CheckImage(int id)
        {
            var result = _carImageDal.GetAll(i=>i.CarId==id).Count;
            if (result>0)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }
        private IDataResult<List<CarImage>> GetDefaultImage(int id)
        {
            List<CarImage> images = new List<CarImage>();
            images.Add(new CarImage { CarId=id,Date=DateTime.Now,ImagePath="DefaultImage.jpg"});
            return new SuccessDataResult<List<CarImage>>(images);
        }
        private IResult CheckImageLimit(int id)
        {
            var result = _carImageDal.GetAll(i=>i.CarId==id).Count;
            if (result>5)
            {
                return new ErrorResult(Message.ImageLimit);
            }
            return new SuccessResult();
        }
    }
}
