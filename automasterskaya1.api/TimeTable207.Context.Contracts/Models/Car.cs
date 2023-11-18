namespace TimeTable207.Context.Contracts.Models
{
    public class Car : BaseAuditEntity
    {
        /// <summary>
        /// Марка и модель автомобиля
        /// </summary>
        public string Automobil { get; set; }

        /// <summary>
        /// Вин номер автомобиля
        /// </summary>
        public string VIN { get; set; }

        /// <summary>
        /// Номер кузова автомобиля
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Номер двигателя
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Тип кузова
        /// </summary>
        public string TypeBody { get; set; }

        /// <summary>
        /// Гос номер
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// ТехПаспорт автомобиля
        /// </summary>
        public string CarPassport { get; set; }

        /// <summary>
        /// Год выпуска
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Пробег
        /// </summary>
        public string Mileage { get; set; }

        /// <summary>
        /// Цвет автомобиля
        /// </summary>
        public string Color { get; set; }
    }
}