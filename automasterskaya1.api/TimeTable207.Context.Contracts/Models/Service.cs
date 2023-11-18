using Automasterskaya.Context.Contracts.Models.Enums;
using TimeTable207.Context.Contracts.Models;

namespace Automasterskaya.Context.Contracts.Models
{
    public class Service : BaseAuditEntity
    {
        /// <summary>
        /// код
        /// </summary>
        public string Kod { get; set; }

        /// <summary>
        /// наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// определение
        /// </summary>
        public ServiceTypes ServiceType { get; set; }

        /// <summary>
        /// цена
        /// </summary>
        public decimal Money { get; set; }
    }
}
