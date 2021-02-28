using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }


        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetImagesById")]
        public IActionResult GetImagesById(int id)
        {
            var result = _carImageService.GetImagesByCarId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImage carImage)
        {
            if (file != null)
            {
                var result = _carImageService.Add(file, carImage);
                if (result.Success && file != null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            return BadRequest();
        }

        [HttpPost("Delete")]
        public IActionResult Delete( [FromForm] CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImage carImage)
        {
            if (file != null)
            {
                var result = _carImageService.Add(file, carImage);
                if (result.Success && file != null)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            return BadRequest();
        }




    }
}
