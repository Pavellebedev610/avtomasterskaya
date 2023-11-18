using TimeTable207.Context.Contracts;
using TimeTable207.Context.Contracts.Models;

namespace AutomasterskayaContext
{
    public class AutomasterskayaContext : IAutomasterskayaContext
    {
        private ICollection<Car> Cars { get; set; }

        private ICollection<Customer> Customers { get; set; }

        ICollection<Car> IAutomasterskayaContext.Cars => Cars;

        ICollection<Customer> IAutomasterskayaContext.Customers => Customers;

        public AutomasterskayaContext()
        {
            Cars = new HashSet<Car>();
            Customers = new HashSet<Customer>();
        }

    }
}