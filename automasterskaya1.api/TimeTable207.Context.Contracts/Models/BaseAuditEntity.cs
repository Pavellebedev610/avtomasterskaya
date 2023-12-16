using System;

namespace TimeTable207.Context.Contracts.Models
{
    public abstract class BaseAuditEntity
    {
        /// <summary>
        /// Идендификатор сущности
        /// </summary>
        public Guid id { get; set; }

        /// <summary>
        /// Дата добавления сущности
        /// </summary>
        public DateTimeOffset CreateAt { get; set; }
        
        /// <summary>
        /// Кто создал
        /// </summary>
        public string CreatedBy { get; set; } = string.Empty;
        
        /// <summary>
        /// Обновление кем-то
        /// </summary>
        public string UpdatedBy { get; set; }= string.Empty;

        /// <summary>
        /// Дата редактирования сущности
        /// </summary>
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Дата удалени
        /// </summary>
        public DateTimeOffset? DeleteAt { get; set;} 
    }

}
