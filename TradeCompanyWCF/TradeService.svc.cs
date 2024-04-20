using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using TradeCompanyWCF.Models;

namespace TradeCompanyWCF
{
    public class TradeService : ITradeService
    {
        /// <summary>
        /// Получить строку подключения к базе данных
        /// </summary>
        /// <returns></returns>
        private SqlConnection GetConnection()
        {
            var cnString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;

            return new SqlConnection(cnString);
        }

        public List<Customer> GetCustomers()
        {
            var list = new List<Customer>();

            using (var con = GetConnection())
            {
                var command = new SqlCommand("select * from customers", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Customer();
                    c.Id = (int)reader["Id"];
                    c.Name = (string)reader["Name"];
                    c.Surname = (string)reader["Surname"];
                    c.BirthYear = (int)reader["BirthYear"];
                    list.Add(c);
                }
            }

            return list;

        }

        public List<Order> GetOrders(int customerId)
        {
            var list = new List<Order>();

            using (var con = GetConnection())
            {
                var command = new SqlCommand("select * from orders where customerid=@customerId", con);
                command.Parameters.AddWithValue("@customerId", customerId);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Order();
                    c.Id = (int)reader["Id"];
                    c.Title = (string)reader["Title"];
                    c.CustomerId = (int)reader["CustomerId"];
                    c.Price = (int)reader["Price"];
                    c.Quantity = (int)reader["Quantity"];
                    list.Add(c);
                }
            }

            return list;
        }
    }
}
