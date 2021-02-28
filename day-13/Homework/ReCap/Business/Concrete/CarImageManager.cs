using Business.Abstract;
using Business.Contants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckCountOfImage(carImage.CarId));

            if (result != null)
            {
                return result;
            }

            carImage.ImagePath = FileHelper.AddAsync(file);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile file, CarImage image)
        {
            var oldpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @".E:\Github\Step-by-Step-Bootcamp\day-13\Homework\ReCap\WebAPI\wwwroot\images")) +
            _carImageDal.Get(p => p.CarImageId == image.CarImageId).ImagePath;
            image.ImagePath = FileHelper.UpdateAsync(oldpath, file);
            image.Date = DateTime.Now;
            _carImageDal.Update(image);
            return new SuccessResult(Messages.ImageUpdated);

        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Delete(CarImage image)
        {
            var oldpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"E:\Github\Step-by-Step-Bootcamp\day-13\Homework\ReCap\WebAPI\wwwroot\images")) +
                _carImageDal.Get(p => p.CarImageId == image.CarImageId).ImagePath;

            IResult result = BusinessRules.Run(
                FileHelper.DeleteAsync(oldpath));

            if (result != null)
            {
                return result;
            }

            _carImageDal.Delete(image);
            return new SuccessResult(Messages.ImageDeleted);
        }


        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        
        public IDataResult<List<CarImage>> GetImagesByCarId(int carId)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageNull(carId));

            if (result != null)
            {
                return new ErrorDataResult<List<CarImage>>(result.Message);
            }

            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(carId).Data);
        }


        private IDataResult<List<CarImage>> CheckIfCarImageNull(int id)
        {
            try
            {
                string path = @"E:\Github\Step-by-Step-Bootcamp\day-13\Homework\ReCap\WebAPI\wwwroot\images";
                var result = _carImageDal.GetAll(c => c.CarId == id).Any();
                if (!result)
                {
                    List<CarImage> carimage = new List<CarImage>();
                    carimage.Add(new CarImage { CarId = id, ImagePath = path, Date = DateTime.Now });
                    return new SuccessDataResult<List<CarImage>>(carimage);
                }
            }
            catch (Exception exception)
            {

                return new ErrorDataResult<List<CarImage>>(exception.Message);
            }

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(p => p.CarId == id).ToList());
        }


        private IResult CheckCountOfImage(int carId)
        {
            var carImagecount = _carImageDal.GetAll(p => p.CarId == carId).Count;
            if (carImagecount >= 5)
            {
                return new ErrorResult(Messages.AddImageOperationFailed);
            }

            return new SuccessResult();
        }
    }
}
