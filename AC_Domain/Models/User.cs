namespace AC_Domain.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        // Не уверен
        public string PhoneNumber { get; set; }
        public string PfpPath { get; set; } // путь к profile picture пользователя
    }
}
