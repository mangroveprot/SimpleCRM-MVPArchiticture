using System.Data;
using System.Data.SqlClient;
using SimpleCRM._Repositories._connections;
using SimpleCRM.Models._models;
using SimpleCRM.Models._repositories;

namespace SimpleCRM._Repositories
{
    public class ProductRepository : ConnectionProvider, IBaseRepository<ProductModel>
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Products 
                                        (product_name, description, price, stock_quantity)
                                        VALUES 
                                        (@productName, @description, @price, @stockQuantity);";

                command.Parameters.Add("@productName", SqlDbType.NVarChar).Value = productModel.ProductName;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = productModel.Description;
                command.Parameters.Add("@price", SqlDbType.Decimal).Value = productModel.Price;
                command.Parameters.Add("@stockQuantity", SqlDbType.Int).Value = productModel.StockQuantity;

                command.ExecuteNonQuery();
            }
        }

        public void Delete(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Products WHERE product_id = @productId;";
                command.Parameters.Add("@productId", SqlDbType.Int).Value = productModel.ProductId;

                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Products SET 
                                        product_name = @productName,
                                        description = @description,
                                        price = @price,
                                        stock_quantity = @stockQuantity
                                        WHERE product_id = @productId;";

                command.Parameters.Add("@productName", SqlDbType.NVarChar).Value = productModel.ProductName;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = productModel.Description;
                command.Parameters.Add("@price", SqlDbType.Decimal).Value = productModel.Price;
                command.Parameters.Add("@stockQuantity", SqlDbType.Int).Value = productModel.StockQuantity;
                command.Parameters.Add("@productId", SqlDbType.Int).Value = productModel.ProductId;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products ORDER BY product_id DESC;";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel();
                        product.ProductId = (int)reader[0];
                        product.ProductName = reader[1].ToString();
                        product.Description = reader[2].ToString();
                        product.Price = Convert.ToDecimal(reader[3]);
                        product.StockQuantity = (int)reader[4];
                        productList.Add(product);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string name = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Products
                                        WHERE product_id = @productId 
                                           OR product_name LIKE @name + '%' 
                                           OR description LIKE '%' + @name + '%'
                                        ORDER BY product_id DESC;";

                command.Parameters.Add("@productId", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel();
                        product.ProductId = (int)reader[0];
                        product.ProductName = reader[1].ToString();
                        product.Description = reader[2].ToString();
                        product.Price = Convert.ToDecimal(reader[3]);
                        product.StockQuantity = (int)reader[4];
                        productList.Add(product);
                    }
                }
            }
            return productList;
        }
    }
}
