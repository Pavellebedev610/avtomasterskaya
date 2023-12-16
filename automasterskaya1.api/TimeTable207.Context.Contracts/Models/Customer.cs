namespace TimeTable207.Context.Contracts.Models
{
    public class Customer : BaseAuditEntity
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string FIO { get; set; }

        /// <summary>
        /// адрес
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// телефон
        /// </summary>
        public string Iphone { get; set; }
    }
}