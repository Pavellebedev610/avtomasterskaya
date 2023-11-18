using Automasterskaya.Context.Contracts.Models;
using System.Runtime.CompilerServices;
using TimeTable207.Context.Contracts;
using TimeTable207.Context.Contracts.Models;

namespace AutomasterskayaContext
{
    public class AutomasterskayaContext : IAutomasterskayaContext
    {
        private ICollection<Car> cars { get; set; }
        private ICollection<Customer> customers { get; set; }
        
        private ICollection<Service> services { get; set; }

        public ICollection<Car> Cars => cars;

        public ICollection<Customer> Customers => customers;

        public ICollection<Service> Services => services;

        public AutomasterskayaContext()
        {
            cars = new HashSet<Car>();
            customers = new HashSet<Customer>();
            services = new HashSet<Service>();
            Seed();
        }

        private void Seed() 
        {
            Customers.Add(new Customer
            {
                id = Guid.NewGuid(),
                FIO = "Павленко Илья Евгеньевич",
                Adress = "улица Пушкина дом грибоедова",
                Iphone = "89912980850"
            }) ;
            Cars.Add(new Car
            {
                id= Guid.NewGuid(),
                Automobil = "Mitsubishi Luncer",
                VIN = "21312312123231",
                Body= "213123312",
                Engine ="312123123",
                TypeBody= "Сидан",
                Number = "в777ор777",
                CarPassport = "321123123",
                Year = 2000,
                Mileage="30250",
                Color= "Черный",

            });
            Services.Add(new Service
            {
                id = Guid.NewGuid(),
                Kod = "422",
                Name= "Палировка кузова",
                Money=100000,
                ServiceType = Automasterskaya.Context.Contracts.Models.Enums.ServiceTypes.Service,
                
            });
        }



    }
}