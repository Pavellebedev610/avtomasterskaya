using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable207.Context.Contracts.Models
{
    public abstract class BaseAuditEntity
    {
        public Guid id { get; set; }

        public DateTimeOffset CreateAt { get; set; }

        public string CreatedBy { get; set; } = string.Empty;

        public string UpdatedBy { get; set; }= string.Empty;
        
        public DateTimeOffset? DeleteAt { get; set;} 
    }

}
