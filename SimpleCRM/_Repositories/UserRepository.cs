using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SimpleCRM._Repositories._connections;
using SimpleCRM.Models._models;
using SimpleCRM.Models._repositories;

namespace SimpleCRM._Repositories
{
    public class UserRepository : ConnectionProvider, IBaseRepository<UserModel>
    {
        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(UserModel userModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Users 
                                        (username, password, email, full_name, role)
                                        VALUES 
                                        (@username, @password, @email, @fullName, @role);";

                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = userModel.Username;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = userModel.Password;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = userModel.Email;
                command.Parameters.Add("@fullName", SqlDbType.NVarChar).Value = userModel.FullName;
                command.Parameters.Add("@role", SqlDbType.NVarChar).Value = userModel.Role;

                command.ExecuteNonQuery();
            }
        }

        public void Delete(UserModel userModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Users WHERE user_id = @userId;";
                command.Parameters.Add("@userId", SqlDbType.Int).Value = userModel.UserId;

                command.ExecuteNonQuery();
            }
        }

        public void Edit(UserModel userModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Users SET 
                                        username = @username,
                                        password = @password,
                                        email = @email,
                                        full_name = @fullName,
                                        role = @role
                                        WHERE user_id = @userId;";

                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = userModel.Username;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = userModel.Password;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = userModel.Email;
                command.Parameters.Add("@fullName", SqlDbType.NVarChar).Value = userModel.FullName;
                command.Parameters.Add("@role", SqlDbType.NVarChar).Value = userModel.Role;
                command.Parameters.Add("@userId", SqlDbType.Int).Value = userModel.UserId;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<UserModel> GetAll()
        {
            var userList = new List<UserModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Users ORDER BY user_id ASC;";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new UserModel
                        {
                            UserId = (int)reader[0],
                            Username = reader[1].ToString(),
                            Password = reader[2].ToString(),
                            Email = reader[3].ToString(),
                            FullName = reader[4].ToString(),
                            Role = reader[5].ToString()
                        };
                        userList.Add(user);
                    }
                }
            }
            return userList;
        }

        public IEnumerable<UserModel> GetByValue(string value)
        {
            var userList = new List<UserModel>();
            int userId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string nameOrEmail = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Users
                                        WHERE user_id = @userId 
                                           OR username LIKE @nameOrEmail + '%' 
                                           OR email LIKE @nameOrEmail + '%'
                                           OR full_name LIKE @nameOrEmail + '%'
                                        ORDER BY user_id ASC;";

                command.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                command.Parameters.Add("@nameOrEmail", SqlDbType.NVarChar).Value = nameOrEmail;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new UserModel
                        {
                            UserId = (int)reader[0],
                            Username = reader[1].ToString(),
                            Password = reader[2].ToString(),
                            Email = reader[3].ToString(),
                            FullName = reader[4].ToString(),
                            Role = reader[5].ToString()
                        };
                        userList.Add(user);
                    }
                }
            }
            return userList;
        }
    }
}
