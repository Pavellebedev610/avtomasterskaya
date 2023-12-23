using Microsoft.AspNetCore.Mvc;
using TimeTable207.Context.Contracts;
using TimeTable207.Context.Contracts.Models;

namespace automasterskaya1.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IAutomasterskayaContext context;

        public CustomerController(IAutomasterskayaContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var customerlist = context.Customers.ToList();

            return Ok(customerlist);

        }

        [HttpGet("{id:Guid}")]
        public IActionResult Get(Guid id)
        {
            var customerlist = context.Customers.FirstOrDefault(x => x.id == id);
            return Ok(customerlist);

        }

        [HttpPost]
        public IActionResult Create(CustomerModel model)
        {
            var item = new Customer
            {
                id = Guid.NewGuid(),
                FIO = model.FIO,
                Adress = model.Adress,
                Iphone = model.Iphone,
                CreateAt = DateTime.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Я",
            };
            context.Customers.Add(item);
            context.SaveChanges();
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var customer = context.Customers.FirstOrDefault(x => x.id == id);
            if (customer != null)
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Edit(Guid id, Customer model)
        {
            var customered = context.Customers.FirstOrDefault(x => x.id == id);
            if (customered == null)
            {
                return NotFound();
            }
            customered.FIO = model.FIO;
            customered.Adress = model.Adress;
            customered.Iphone = model.Iphone;
            context.SaveChanges();
            return Ok(customered);
        }

    }
}
