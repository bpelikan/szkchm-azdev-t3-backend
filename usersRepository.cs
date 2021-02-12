using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
public class UsersRepository
{
    public User getUserById(int id)
    {
        var connectionString = "";

        using (var connection = new SqlConnection(connectionString))
        {
            IEnumerable<User> queryResult = connection.Query<User>($"SELECT [Id], [FirstName], [LastName] FROM dbo.[Users] WHERE Id={id}");
            return queryResult.ToList().FirstOrDefault();
        }
    }
}