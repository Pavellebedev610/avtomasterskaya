namespace TimeTable207.Context.Contracts.Models
{
    public class Customer : BaseAuditEntity
    {
        /// <summary>
        /// ���
        /// </summary>
        public string FIO { get; set; }

        /// <summary>
        /// �����
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public string Iphone { get; set; }
    }
}