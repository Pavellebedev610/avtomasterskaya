using Microsoft.AspNetCore.Mvc;

namespace automasterskaya1.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var context = new AutomasterskayaContext.AutomasterskayaContext();
            var customerlist=context.Customers.ToList();

            return Ok(customerlist);

        }
    }
}
