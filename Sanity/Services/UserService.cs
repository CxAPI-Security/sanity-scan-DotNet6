using Microsoft.Data.Sqlite;
using Sanity.Models;

namespace Sanity.Services
{

    public class UserService : IUserService
    {

        public void InsertUser(User user)
        {
            var sql = string.Format(IUserService.INSERT_USER, user.Password, user.FirstName, user.Email, user.Info);
            var command = new SqliteCommand(sql);
            command.ExecuteNonQuery();
        }

        public User? GetUserByEmail(string email)
        {
            var connection = new SqliteConnection();
            connection.Open();
            var sql = "SELECT * FROM user WHERE email = '" + email + "';";
            var command = new SqliteCommand(sql, connection);
            var reader = command.ExecuteReader();
            var user = new User();

            while (reader.Read())
            {
                user.Email = reader.GetString(0);
                user.Password = reader.GetString(1);
                user.FirstName = reader.GetString(2);
                user.Info = reader.GetString(3);

            }

            connection.Close();
            return user;
        }

        public User GetUSerById(long id)
        {
            var sql = string.Format(IUserService.GET_USER_BY_ID, id);
            using var command = new SqliteCommand(sql);
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();
            var user = new User();
            while (reader.Read())
            {
                user.Email = reader.GetString(0);
                user.Password = reader.GetString(1);
                user.FirstName = reader.GetString(2);
                user.Info = reader.GetString(3);
            }

            return user;
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void CreateUserCart(User user, ISet<string> productIds, ISet<int> quantities)
        {
            throw new NotImplementedException();
        }

        public void CreateUserMapCart(User user, Dictionary<string, int> mapCart)
        {
            throw new NotImplementedException();
        }
    }
}