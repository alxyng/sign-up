namespace SignUp.Services
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    using SignUp.Data;
    using SignUp.Data.Queries;
    using SignUp.Models;

    public class UserService : IUserService
    {
        public async Task<int> AddUser(UserModel model)
        {
            using (var connection = DatabaseConnectionFactory.Create())
            {
                await connection.OpenAsync();

                var query = new AddUserQuery(connection);
                return await query.Execute(model);
            }
        }
    }
}
