using System.Runtime.CompilerServices;
using TimeTable207.Context.Contracts;
using TimeTable207.Context.Contracts.Models;

namespace AutomasterskayaContext
{
    public class AutomasterskayaContext : IAutomasterskayaContext
    {
        private ICollection<Car> cars { get; set; }
        private ICollection<Customer> customers { get; set; }
        public ICollection<Car> Cars => cars;

        public ICollection<Customer> Customers => customers;

        public AutomasterskayaContext()
        {
            cars = new HashSet<Car>();
            customers = new HashSet<Customer>();
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
        }

    }
}