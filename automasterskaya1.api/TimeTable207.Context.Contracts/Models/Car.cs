namespace TimeTable207.Context.Contracts.Models
{
    public class Car : BaseAuditEntity
    {
        /// <summary>
        /// ����� � ������ ����������
        /// </summary>
        public string Automobil { get; set; }

        /// <summary>
        /// ��� ����� ����������
        /// </summary>
        public string VIN { get; set; }

        /// <summary>
        /// ����� ������ ����������
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// ����� ���������
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// ��� ������
        /// </summary>
        public string TypeBody { get; set; }

        /// <summary>
        /// ��� �����
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// ���������� ����������
        /// </summary>
        public string CarPassport { get; set; }

        /// <summary>
        /// ��� �������
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string Mileage { get; set; }

        /// <summary>
        /// ���� ����������
        /// </summary>
        public string Color { get; set; }
    }
}