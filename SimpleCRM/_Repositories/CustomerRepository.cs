using System.Data;
using System.Data.SqlClient;
using SimpleCRM._Repositories._connections;
using SimpleCRM.Models._models;
using SimpleCRM.Models._repositories;

namespace SimpleCRM._Repositories
{
    public class CustomerRepository : ConnectionProvider, IBaseRepository<CustomerModel>
    {
        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Customers 
                                        (first_name, middle_name, last_name, suffix, email, phone_number, created_at)
                                        VALUES 
                                        (@firstName, @middleName, @lastName, @suffix, @email, @phoneNumber, @createdAt);";

                command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = customerModel.FirstName;
                command.Parameters.Add("@middleName", SqlDbType.NVarChar).Value = customerModel.MiddleName;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = customerModel.LastName;
                command.Parameters.Add("@suffix", SqlDbType.NVarChar).Value = customerModel.Suffix;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = customerModel.PhoneNumber;
                command.Parameters.Add("@createdAt", SqlDbType.DateTime).Value = customerModel.CreatedAt;

                command.ExecuteNonQuery();
            }
        }

        public void Delete(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Customers WHERE customer_id = @customerId;";
                command.Parameters.Add("@customerId", SqlDbType.Int).Value = customerModel.CustomerId;

                command.ExecuteNonQuery();
            }
        }

        public void Edit(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customers SET 
                                        first_name = @firstName,
                                        middle_name = @middleName,
                                        last_name = @lastName,
                                        suffix = @suffix,
                                        email = @email,
                                        phone_number = @phoneNumber
                                        WHERE customer_id = @customerId;";

                command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = customerModel.FirstName;
                command.Parameters.Add("@middleName", SqlDbType.NVarChar).Value = customerModel.MiddleName;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = customerModel.LastName;
                command.Parameters.Add("@suffix", SqlDbType.NVarChar).Value = customerModel.Suffix;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = customerModel.PhoneNumber;
                command.Parameters.Add("@customerId", SqlDbType.Int).Value = customerModel.CustomerId;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            var customerList = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customers ORDER BY customer_id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.CustomerId = (int)reader[0];
                        customerModel.FirstName = reader[1].ToString();
                        customerModel.MiddleName = reader[2].ToString();
                        customerModel.LastName = reader[3].ToString();
                        customerModel.Suffix = reader[4].ToString();
                        customerModel.Email = reader[5].ToString();
                        customerModel.PhoneNumber = reader[6].ToString();
                        customerModel.CreatedAt = Convert.ToDateTime(reader[7]);
                        customerList.Add(customerModel);


                    }
                }
            }
            return customerList;
        }

        public IEnumerable<CustomerModel> GetByValue(string value)
        {
            var customerList = new List<CustomerModel>();
            int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customerName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM customers 
                                WHERE customer_id = @customerId 
                                   OR first_name LIKE @name + '%' 
                                   OR last_name LIKE '%' + @name + '%' 
                                ORDER BY customer_id DESC;";

                command.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.CustomerId = (int)reader[0];
                        customerModel.FirstName = reader[1].ToString();
                        customerModel.MiddleName = reader[2].ToString();
                        customerModel.LastName = reader[3].ToString();
                        customerModel.Suffix = reader[4].ToString();
                        customerModel.Email = reader[5].ToString();
                        customerModel.PhoneNumber = reader[6].ToString();
                        customerModel.CreatedAt = Convert.ToDateTime(reader[7]);
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }

    }
}
