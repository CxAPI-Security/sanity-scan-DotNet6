using Sanity.Models;

namespace Sanity.Services
{
    public interface IUserService
    {
        public static string GET_USER_BY_EMAIL = "select u.* from users u where upper(u.email) = upper({0})";
        public static string GET_USER_BY_ID = "select u.* from users u where u.id = {0}";

        public static string INSERT_USER =
            "INSERT INTO users (password, first_name, email, info) values ({0}, {1}, {2}, {3})";

        void InsertUser(User user);
        User? GetUserByEmail(string email);
        User GetUSerById(long id);
        void UpdateUser(User user);
        void CreateUserCart(User user, ISet<string> productIds, ISet<int> quantities);
        void CreateUserMapCart(User user, Dictionary<string, int> mapCart);
    }
}