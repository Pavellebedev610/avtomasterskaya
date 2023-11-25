using Microsoft.AspNetCore.Mvc;
using TimeTable207.Context.Contracts;

namespace automasterskaya1.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : ControllerBase
    {

        private readonly IAutomasterskayaContext context;

        public ServiceController(IAutomasterskayaContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var servicelist = context.Services.ToList();

            return Ok(servicelist);

        }
        [HttpGet("{id:Guid}")]
        public IActionResult Get(Guid id) 
        {
            var servicelist = context.Services.FirstOrDefault(x => x.id == id);
            return Ok(servicelist);

        }

    }
}
