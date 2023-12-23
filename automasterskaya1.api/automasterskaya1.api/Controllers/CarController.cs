using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Text.RegularExpressions;
using TimeTable207.Context.Contracts;
using TimeTable207.Context.Contracts.Models;

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
        [HttpPost]
        public IActionResult Create(Car model)
        {
            var item2 = new Car
            {
                id = Guid.NewGuid(),
                Automobil = model.Automobil,
                VIN = model.VIN,
                Body = model.Body,
                Engine = model.Engine,
                TypeBody = model.TypeBody,
                Number = model.Number,
                CarPassport = model.CarPassport,
                Year = model.Year,
                Mileage = model.Mileage,
                Color = model.Color,
            };
            context.Cars.Add(item2);
            context.SaveChanges();
            return Ok(item2);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var car = context.Cars.FirstOrDefault(x => x.id == id);
            if (car != null)
            {
                context.Cars.Remove(car);
                context.SaveChanges();
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Edit(Guid id, Car model)
        {
            var cared = context.Cars.FirstOrDefault(x => x.id == id);
            if (cared == null)
            {
                return NotFound();
            }
            cared.Automobil = model.Automobil;
            cared.VIN = model.VIN;
            cared.Body = model.Body;
            cared.Engine = model.Engine;
            cared.TypeBody = model.TypeBody;
            cared.Number = model.Number;
            cared.CarPassport = model.CarPassport;
            cared.Year = model.Year;
            cared.Mileage = model.Mileage;
            cared.Color = model.Color;
            cared.UpdatedAt = DateTimeOffset.Now;
            context.SaveChanges();
            return Ok(cared);


        }

    }
}
