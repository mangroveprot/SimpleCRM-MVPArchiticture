using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SimpleCRM._Repositories._connections;
using SimpleCRM.Models._models;
using SimpleCRM.Models._repositories;

namespace SimpleCRM._Repositories
{
    public class OrderRepository : ConnectionProvider, IBaseRepository<OrderModel>
    {
        public OrderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(OrderModel orderModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Orders 
                                        (customer_id, product_id, quantity, total_amount, status, date)
                                        VALUES 
                                        (@customerId, @productId, @quantity, @totalAmount, @status, @date);";

                command.Parameters.Add("@customerId", SqlDbType.Int).Value = orderModel.CustomerId;
                command.Parameters.Add("@productId", SqlDbType.Int).Value = (object?)orderModel.ProductId ?? DBNull.Value;
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = orderModel.Quantity;
                command.Parameters.Add("@totalAmount", SqlDbType.Decimal).Value = orderModel.TotalAmount;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = orderModel.Status;
                command.Parameters.Add("@date", SqlDbType.DateTime).Value = orderModel.Date;

                command.ExecuteNonQuery();
            }
        }

        public void Delete(OrderModel orderModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Orders WHERE order_id = @orderId;";
                command.Parameters.Add("@orderId", SqlDbType.Int).Value = orderModel.OrderId;

                command.ExecuteNonQuery();
            }
        }

        public void Edit(OrderModel orderModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Orders SET 
                                        customer_id = @customerId,
                                        product_id = @productId,
                                        quantity = @quantity,
                                        total_amount = @totalAmount,
                                        status = @status
                                        WHERE order_id = @orderId;";

                command.Parameters.Add("@customerId", SqlDbType.Int).Value = orderModel.CustomerId;
                command.Parameters.Add("@productId", SqlDbType.Int).Value = (object?)orderModel.ProductId ?? DBNull.Value;
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = orderModel.Quantity;
                command.Parameters.Add("@totalAmount", SqlDbType.Decimal).Value = orderModel.TotalAmount;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = orderModel.Status;
                command.Parameters.Add("@orderId", SqlDbType.Int).Value = orderModel.OrderId;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<OrderModel> GetAll()
        {
            var orderList = new List<OrderModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Orders ORDER BY date DESC;";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var order = new OrderModel();
                        order.OrderId = (int)reader[0];
                        order.CustomerId = (int)reader[1];
                        order.ProductId = reader.IsDBNull(2) ? null : (int?)reader[2];
                        order.Quantity = (int)reader[3];
                        order.TotalAmount = (decimal)reader[4];
                        order.Status = reader[5].ToString();
                        order.Date = (DateTime)reader[6];
                        orderList.Add(order);
                    }
                }
            }
            return orderList;
        }

        public IEnumerable<OrderModel> GetByValue(string value)
        {
            var orderList = new List<OrderModel>();
            int orderId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Orders
                                        WHERE order_id = @orderId
                                           OR status LIKE @status + '%'
                                        ORDER BY date DESC;";

                command.Parameters.Add("@orderId", SqlDbType.Int).Value = orderId;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = value;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var order = new OrderModel();
                        order.OrderId = (int)reader[0];
                        order.CustomerId = (int)reader[1];
                        order.ProductId = reader.IsDBNull(2) ? null : (int?)reader[2];
                        order.Quantity = (int)reader[3];
                        order.TotalAmount = (decimal)reader[4];
                        order.Status = reader[5].ToString();
                        order.Date = (DateTime)reader[6];
                        orderList.Add(order);
                    }
                }
            }
            return orderList;
        }
    }
}
