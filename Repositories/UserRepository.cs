using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories{

public class UserRepository{

    private SqlConnection _connection = new SqlConnection();
    public IEnumerable<User> Get(string connectionString)
        => _connection.GetAll<User>();
}
}