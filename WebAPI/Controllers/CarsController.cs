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
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public List<Car> Get()
        {
          //  ICarService _carServices = new CarManager(new EfCarDal());
           var result= _carService.GetAll();
            return result.Data;
        }

    }
}
