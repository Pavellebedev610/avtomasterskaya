using Automasterskaya.Context.Contracts.Models;
using Microsoft.AspNetCore.Mvc;
using TimeTable207.Context.Contracts;
using TimeTable207.Context.Contracts.Models;

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

        [HttpPost]
        public IActionResult Create(Service model)
        {
            var item3 = new Service
            {
                id = Guid.NewGuid(),
                Kod = model.Kod,
                Name = model.Name,
                ServiceType = model.ServiceType,
                Money = model.Money,
  
            };
            context.Services.Add(item3);
            context.SaveChanges();
            return Ok(item3);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var service = context.Services.FirstOrDefault(x => x.id == id);
            if (service != null)
            {
                context.Services.Remove(service);
                context.SaveChanges();
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Edit(Guid id, Service model)
        {
            var serviceed = context.Services.FirstOrDefault(x => x.id == id);
            if (serviceed == null)
            {
                return NotFound();
            }
            serviceed.Kod = model.Kod;
            serviceed.Name = model.Name;
            serviceed.ServiceType = model.ServiceType;
            serviceed.Money = model.Money;
            context.SaveChanges();
            return Ok(serviceed);
        }
    }
}
