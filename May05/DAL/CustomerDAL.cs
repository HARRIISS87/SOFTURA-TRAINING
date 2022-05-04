using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using ADOdotNet.Models;
using Microsoft.Extensions.Configuration;

namespace ADOdotNet.DAL
{
    public class CustomerDAL
    {
        public string cnn = "";


        public CustomerDAL()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:Conn").Value;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> listCustomer = new List<Customer>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllCustomers", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listCustomer.Add(new Customer()
                        {
                            CustomerID = int.Parse(reader["CustomerID"].ToString()),
                            CustomerName = reader["CustomerName"].ToString(),
                            EmailID = reader["EmailID"].ToString(),
                            MobileNo = reader["MobileNo"].ToString()
                        }); ;
                    }

                }
            }
            return listCustomer;
        }
        public int NewCustomer(Customer cust)
        {
            /* int CustomerId = cust.CustomerID;
             string CustomerName = cust.CustomerName;
             string emailId = cust.EmailID;
             string MobileNo = cust.MobileNo;
             SqlConnection con = new SqlConnection(cnn);
             string sqlqry = "NewCustomer '"+ CustomerId +"','"+CustomerName+"','"+emailId+"','"+MobileNo+"'";
             SqlCommand cmd = new SqlCommand(sqlqry, con);
             con.Open();
             cmd.ExecuteNonQuery();
             con.Close();*/
            SqlConnection con = new SqlConnection(cnn);
            
            SqlCommand cmd = new SqlCommand("NewCustomer", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", cust.CustomerID);
            cmd.Parameters.AddWithValue("@cname", cust.CustomerName);
            cmd.Parameters.AddWithValue("@email", cust.EmailID);
            cmd.Parameters.AddWithValue("@mob", cust.MobileNo);
            con.Open();
            int result = cmd.ExecuteNonQuery();

            con.Close();
            return result;
        }

    }

}

