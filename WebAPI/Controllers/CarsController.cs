using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]//nasıl ulaşsın adres
    [ApiController]
    public class CarsController : ControllerBase
    {
        //IoC Inversion of Control 
        ICarService _carService;
        public  CarsController(ICarService carService)//Constractor Gevsek baglılık (loosely coupled
            //Bir baglılıgı var ama soyuta baglı ileride managerı degıstırsen sorun cıkmaz 
        {
            _carService = carService;
        }
        [HttpGet("getall")]
        public  IActionResult  GetAll()
        {
          //  ICarService _carServices = new CarManager(new EfCarDal());
           var result= _carService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
                return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result= _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

    }
}
