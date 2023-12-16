using Microsoft.AspNetCore.Mvc;
using TimeTable207.Context.Contracts;

namespace automasterskaya1.api.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CarController : ControllerBase
    {

        private readonly IAutomasterskayaContext context;

        public CarController(IAutomasterskayaContext context)
        {
            this.context = context;
        }


        /// <summary>
        /// 
        /// </summary>
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var carlist = context.Cars.ToList();

            return Ok(carlist);

        }

        [HttpGet("{id:Guid}")]
        public IActionResult Get(Guid id)
        {
            var carlist = context.Cars.FirstOrDefault(x => x.id == id);
            return Ok(carlist);

        }

    }
}
