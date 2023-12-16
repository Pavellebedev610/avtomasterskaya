using Automasterskaya.Context.Contracts.Models;
using System.Collections;
using System.Collections.Generic;
using TimeTable207.Context.Contracts.Models;

namespace TimeTable207.Context.Contracts
{
    public interface IAutomasterskayaContext
    {
        /// <summary>
        /// ������
        /// </summary>
        ICollection<Car> Cars { get; }

        /// <summary>
        /// ��������
        /// </summary>
        ICollection<Customer> Customers { get; }

        ICollection<Service> Services { get; }

    }
}
