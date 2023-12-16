using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomasterskayaContext
{
    internal class DesignTimeFactory : IDesignTimeDbContextFactory<AutomasterskayaContext>
    {
        public AutomasterskayaContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<AutomasterskayaContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new AutomasterskayaContext(options);
        }
    }
}
