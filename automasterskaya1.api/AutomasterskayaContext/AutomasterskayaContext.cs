using Automasterskaya.Context.Contracts.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using TimeTable207.Context.Contracts;
using TimeTable207.Context.Contracts.Models;

namespace AutomasterskayaContext
{
    //AutomasterskayaContext\AutomasterskayaContext.csproj
    public class AutomasterskayaContext :DbContext, IAutomasterskayaContext
    {
        private DbSet<Car> cars { get; set; }
        private DbSet<Customer> customers { get; set; }
        
        private DbSet<Service> services { get; set; }

        public DbSet<Car> Cars => cars;

        public DbSet<Customer> Customers => customers;

        public DbSet<Service> Services => services;

        public AutomasterskayaContext(DbContextOptions<AutomasterskayaContext> options)
            : base(options)
        {
        }
    }
}