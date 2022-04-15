using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Apr15task
{
    class Customer
    {
        public void LoginFailed()
        {
            Console.WriteLine("Enter your Name:");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("Enter your Gender:");
            string Gender = Console.ReadLine();
            Console.WriteLine("DoB");
            string DoB = Console.ReadLine();
            Console.WriteLine("Enter your ContactNo:");
            string ContactNO = Console.ReadLine();
            Console.WriteLine("Enter Email id:");
            string EmailId = Console.ReadLine();
            Console.WriteLine("Enter your city:");
            string City = Console.ReadLine();
            
            SqlConnection con = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
            string sqlqry = "insert Customer values('"+CustomerName+"','"+Gender+"','"+DoB+"','"+ContactNO+"','"+EmailId+"','"+City+"')";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row Inserted");
        }
        
    }
    class Product
    {
        public void LoginSuccess()
        {
            SqlConnection con = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
            SqlCommand cmd = new SqlCommand("select * from dbo.product", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Console.WriteLine(" ProductId: " + dr[0] + " ProductName : " + dr[1] + "          Price : " + dr[2] );
            }
            Console.WriteLine("Enter the ProductId you want to purchase:");
            int prod = Convert.ToInt32(Console.ReadLine());
            switch (prod)
            {
                case 1:
                   
                    Console.WriteLine("You ve selected Cookies");
                    Console.WriteLine("Enter the Quantity");
                    int Quantity = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con1 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                    SqlCommand cmd1 = new SqlCommand("select price* " + Quantity + " from Product where ProductId = "+prod+"", con1);
                    con1.Open();
                    cmd1.ExecuteNonQuery();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        int Total1 = Convert.ToInt32(dr1[0]);
                        Console.WriteLine(" Total Amount " + Total1  );
                    }
                    con1.Close();
                    break;
                case 2:
                    Console.WriteLine("You ve selected Crisps");
                    Console.WriteLine("Enter the Quantity");
                    int Quantity2 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con2 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                    SqlCommand cmd2 = new SqlCommand("select price* " + Quantity2 + " from Product where ProductId = " + prod + "", con2);
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        int Total2= Convert.ToInt32(dr2[0]);
                        Console.WriteLine(" Total Amount " + Total2);
                    }
                    con2.Close();
                    break;
                case 3:
                    Console.WriteLine("You ve selected Vegetables");
                    Console.WriteLine("Enter the Quantity");
                    int Quantity3 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con3 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                    SqlCommand cmd3 = new SqlCommand("select price* " + Quantity3 + " from Product where ProductId = " + prod + "", con3);
                    con3.Open();
                    cmd3.ExecuteNonQuery();
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        int Total3 = Convert.ToInt32(dr3[0]);
                        Console.WriteLine(" Total Amount " + Total3);
                    }
                    con3.Close();
                    break;
                case 4:
                    Console.WriteLine("You ve selected Candy Bars ");
                    Console.WriteLine("Enter the Quantity");
                    int Quantity4 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con4 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                    SqlCommand cmd4 = new SqlCommand("select price* " + Quantity4 + " from Product where ProductId = " + prod + "", con4);
                    con4.Open();
                    cmd4.ExecuteNonQuery();
                    SqlDataReader dr4 = cmd4.ExecuteReader();
                    while (dr4.Read())
                    {
                        int Total4 = Convert.ToInt32(dr4[0]);
                        Console.WriteLine(" Total Amount " + Total4);
                    }
                    con4.Close();
                    break;
                default:
                    Console.WriteLine("Invalid Details");
                    break;
            }
            con.Close();
        }
            
    }
    class Validation
    {

        SqlConnection con = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
        public static void Main()
        {
            Console.WriteLine("Enter your CustomerID:");
            int CustId=Convert.ToInt32(Console.ReadLine());
            if(CustId>0 && CustId<=6) 
            {

                Console.WriteLine("Welcome, you may Continue now!!");
                Product obj1 = new Product();
                obj1.LoginSuccess();
                Console.WriteLine("Want you Coninue..?(Y/N)");
                string condition1 = Console.ReadLine(); 
                if(condition1=="Y")
                {
                    obj1.LoginSuccess();
                }
                else if(condition1=="N")
                {
                    Console.WriteLine("Thank you for Your Purchase");
                }
                //Console.WriteLine("Need Bill..?(Y/N)");
                //string cond = Console.ReadLine();
                //if(cond=="Y")

                //{
                //    SqlConnection con = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                //    string sqlqry = "insert Purchase values('" + CustId + "','" + Gender + "','" + DoB + "','" + ContactNO + "','" + EmailId + "','" + City + "')";
                //    SqlCommand cmd = new SqlCommand(sqlqry, con);
                //    con.Open();
                //    cmd.ExecuteNonQuery();
                //    con.Close();
                //}
                //else
                //{
                //    Console.WriteLine("Welcome Again.");
                //}
                
            }
            else
            {
                Console.WriteLine("Id Does not Exist,please Enter the Details given below to continue");
                Customer obj = new Customer();
                obj.LoginFailed();
            }
           
            
        }
    }
}
