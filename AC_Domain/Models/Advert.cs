namespace AC_Domain.Models
{
    public class Advert
    {
        public int Id { get; set; }

        public string Title { get; set; } // Заголовок объявления
        public string Description { get; set; } // Основной текст объявления

        public string Email { get; set; } // Электронная почта для связи
        public string PhoneNumber { get; set; } // Номер телефона для связи
    }
}
