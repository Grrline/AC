namespace AC_Domain.Models
{
    public class Resume
    {
        public int Id { get; set; }


        public User Owner { get; set; } // владелец резюме
        public string Vacancy { get; set; } // вакансия, на которую претендует владелец резюме
        public string About { get; set; } // строка в резюме "о себе"
        public string Education { get; set; } // строка в резюме о уровне образования
    }
}