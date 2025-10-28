namespace AC_Domain.Models
{
    public class AccountRepository
    {
        private static IDictionary<string, User> Users = new Dictionary<string, User>();

        public void Add(User user)
        {
            Users[user.Name] = user;
        }

        public User? GetByName(string name)
        { return Users.TryGetValue(name, out var user) ? user : null; }
    }
}
