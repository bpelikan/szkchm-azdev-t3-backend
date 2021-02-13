using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using System.IO;

public class UsersRepository
{
    public User getUserById(int id)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        var connectionString = config.GetConnectionString("kurs-azure"); 

        using (var connection = new SqlConnection(connectionString))
        {
            IEnumerable<User> queryResult = connection.Query<User>($"SELECT [Id], [FirstName], [LastName] FROM dbo.[Users] WHERE Id={id}");
            return queryResult.ToList().FirstOrDefault();
        }
    }
}