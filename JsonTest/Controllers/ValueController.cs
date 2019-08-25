using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace JsonTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {

        [HttpGet]
        public ActionResult<ValueViewModel> Get()
        {
            var car = new Car
            {
                Speed = 120,
                HorsePower = 130
            };

            var bus = new Bus
            {
                Speed = 90,
                HumanCapacity = 50
            };

            var vm = new ValueViewModel
            {
                Transportations = new List<Transportation> { car, bus }
            };

            return Ok(vm);
        }
    }

    public class ValueViewModel
    {
        public List<Transportation> Transportations { get; set; }
    }

    public abstract class Transportation
    {
        public int Speed { get; set; }
    }

    public class Car: Transportation
    {
        public int HorsePower { get; set; }
    }

    public class Bus: Transportation
    {
        public int HumanCapacity { get; set; }
    }
}
