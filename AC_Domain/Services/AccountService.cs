using AC_Domain.Models;

namespace AC_Domain.Services
{
    public class AccountService(AccountRepository accountRepository, JwtService jwtService)
    {
        public void Register(string name, string surname, string password)
        {
            var user = new User()
            {
                Name = name,
                Surname = surname,
                Password = password
            };
            accountRepository.Add(user);
        }

        public string Login(string name, string surname, string password)
        {
            var user = accountRepository.GetByName(name);
            if (user.Password == password)
            {
                return jwtService.GenerateToken(user);
            }
            else
            {
                throw new Exception("Не авторизован");
            }
        }
    }
}
