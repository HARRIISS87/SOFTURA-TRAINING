using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Apr15task
{
    class ProductTask
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
            string sqlqry = "insert Customer values('" + CustomerName + "','" + Gender + "','" + DoB + "','" + ContactNO + "','" + EmailId + "','" + City + "')";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row Inserted");
        }
    }
    class Product1
    {
        public int Cookie(int prod, int Quan)
        {
            Console.WriteLine("You ve selected Cookies");

            int Quantity = Quan;
            SqlConnection con1 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
            SqlCommand cmd1 = new SqlCommand("select price* " + Quantity + " from Product where ProductId = " + prod + "", con1);
            con1.Open();
            cmd1.ExecuteNonQuery();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                int Total = Convert.ToInt32(dr1[0]);
                Console.WriteLine(" Total Amount " + Total);
                return Total;

            }
            con1.Close();
            return 0;
        }
        public int Crisps(int prod, int Quan)
        {
            Console.WriteLine("You ve selected Crisps");

            int Quantity = Quan;
            SqlConnection con2 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
            SqlCommand cmd2 = new SqlCommand("select price* " + Quantity + " from Product where ProductId = " + prod + "", con2);
            con2.Open();
            cmd2.ExecuteNonQuery();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                int Total = Convert.ToInt32(dr2[0]);
                Console.WriteLine(" Total Amount " + Total);
                return Total;
            }
            con2.Close();
            return 0;
        }
        public int Vegetables(int prod, int Quan)
        {
            Console.WriteLine("You ve selected Vegetables");

            int Quantity = Quan;
            SqlConnection con3 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
            SqlCommand cmd3 = new SqlCommand("select price* " + Quantity + " from Product where ProductId = " + prod + "", con3);
            con3.Open();
            cmd3.ExecuteNonQuery();
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                int Total = Convert.ToInt32(dr3[0]);
                Console.WriteLine(" Total Amount " + Total);
                return Total;
            }
            con3.Close();
            return 0;
        }
        public int CandyBars(int prod, int Quan)
        {
            Console.WriteLine("You ve selected Candy Bars ");
            Console.WriteLine("Enter the Quantity");
            int Quantity = Quan;
            SqlConnection con4 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
            SqlCommand cmd4 = new SqlCommand("select price* " + Quantity + " from Product where ProductId = " + prod + "", con4);
            con4.Open();
            cmd4.ExecuteNonQuery();
            SqlDataReader dr3 = cmd4.ExecuteReader();
            while (dr3.Read())
            {
                int Total = Convert.ToInt32(dr3[0]);
                Console.WriteLine(" Total Amount " + Total);
                return Total;
            }
            con4.Close();
            return 0;
        }
        //public void Cookie1(int prod1, int Quan1)
        //{
        //    Console.WriteLine("You ve selected Cookies");

        //    int Quantity = Quan1;
        //    SqlConnection con1 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
        //    SqlCommand cmd1 = new SqlCommand("select price* " + Quantity + " from Product where ProductId = " + prod1 + "", con1);
        //    con1.Open();
        //    cmd1.ExecuteNonQuery();
        //    SqlDataReader dr1 = cmd1.ExecuteReader();
        //    while (dr1.Read())
        //    {
        //        int Total1 = Convert.ToInt32(dr1[0]);
        //        Console.WriteLine(" Total Amount " + Total1);
                

        //    }
        //    con1.Close();
        //}
        //public void Crisps1(int prod1, int Quan1)
        //{
        //    Console.WriteLine("You ve selected Crisps");

        //    int Quantity = Quan1;
        //    SqlConnection con2 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
        //    SqlCommand cmd2 = new SqlCommand("select price* " + Quantity + " from Product where ProductId = " + prod1 + "", con2);
        //    con2.Open();
        //    cmd2.ExecuteNonQuery();
        //    SqlDataReader dr2 = cmd2.ExecuteReader();
        //    while (dr2.Read())
        //    {
        //        int Total1= Convert.ToInt32(dr2[0]);
        //        Console.WriteLine(" Total Amount " + Total1);
        //    }
        //    con2.Close();
        //}
        //public void Vegetables1(int prod1, int Quan1)
        //{
        //    Console.WriteLine("You ve selected Vegetables");

        //    int Quantity = Quan1;
        //    SqlConnection con3 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
        //    SqlCommand cmd3 = new SqlCommand("select price* " + Quantity + " from Product where ProductId = " + prod1 + "", con3);
        //    con3.Open();
        //    cmd3.ExecuteNonQuery();
        //    SqlDataReader dr3 = cmd3.ExecuteReader();
        //    while (dr3.Read())
        //    {
        //        int Total1 = Convert.ToInt32(dr3[0]);
        //        Console.WriteLine(" Total Amount " + Total1);
        //    }
        //    con3.Close();
        //}
        //public void CandyBars1(int prod1, int Quan1)
        //{
        //    Console.WriteLine("You ve selected Candy Bars ");
        //    Console.WriteLine("Enter the Quantity");
        //    int Quantity = Quan1;
        //    SqlConnection con4 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
        //    SqlCommand cmd4 = new SqlCommand("select price* " + Quantity + " from Product where ProductId = " + prod1 + "", con4);
        //    con4.Open();
        //    cmd4.ExecuteNonQuery();
        //    SqlDataReader dr3 = cmd4.ExecuteReader();
        //    while (dr3.Read())
        //    {
        //        int Total1 = Convert.ToInt32(dr3[0]);
        //        Console.WriteLine(" Total Amount " + Total1);
        //    }
        //    con4.Close();
        //}


        public static void Main()
        {
            Console.WriteLine("Enter your CustomerId");
            int CustId1 = Convert.ToInt32(Console.ReadLine());
            if (CustId1 > 0 && CustId1 <= 5)
            {
                Console.WriteLine("Welcome..! You are Existing Customer.");
                SqlConnection con = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                SqlCommand cmd = new SqlCommand("select * from dbo.product", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Console.WriteLine(" ProductId: " + dr[0] + " ProductName : " + dr[1] + "          Price : " + dr[2]   + "     Manufactured date:"+dr[3] +"  Expiry date:"  +dr[4]);
                }
                con.Close();
                Console.WriteLine("Enter the productId:");
                int prod = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Quantity:");
                int Quan = Convert.ToInt32(Console.ReadLine());
                Product1 obj1 = new Product1();

                if (prod == 1)
                {
                    int Totamt = obj1.Cookie(prod, Quan);
                    
                    SqlConnection con5 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                    string sqlqry = "insert into Purchase(CustID,ProductID,Quantity,Totalamount) values(" + CustId1 + "," + prod + "," + Quan + "," + Totamt + ")";
                    SqlCommand cmd5 = new SqlCommand(sqlqry, con5);
                    con5.Open();
                    cmd5.ExecuteNonQuery();
                    con5.Close();

                }
                else if (prod == 2)
                {
                    int Totamt = obj1.Crisps(prod, Quan);
                    SqlConnection con6 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                    string sqlqry = "insert into Purchase(CustId,ProductID,Quantity,Totalamount) values(" + CustId1 + "," + prod + "," + Quan + "," + Totamt + ")";
                    SqlCommand cmd6 = new SqlCommand(sqlqry, con6);
                    con6.Open();
                    cmd6.ExecuteNonQuery();
                    con6.Close();
                }
                else if (prod == 3)
                {
                    int Totamt = obj1.Vegetables(prod, Quan);
                    SqlConnection con7 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                    string sqlqry = "insert into Purchase(CustId,ProductID,Quantity,Totalamount) values(" + CustId1 + "," + prod + "," + Quan + "," + Totamt + ")";
                    SqlCommand cmd7 = new SqlCommand(sqlqry, con7);
                    con7.Open();
                    cmd7.ExecuteNonQuery();
                    con7.Close();
                }
                else if (prod == 4)
                {

                    int Totamt = obj1.CandyBars(prod, Quan);
                    SqlConnection con8 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                    string sqlqry = "insert into Purchase(CustId,ProductID,Quantity,Totalamount) values(" + CustId1 + "," + prod + "," + Quan + "," + Totamt + ")";
                    SqlCommand cmd8 = new SqlCommand(sqlqry, con8);
                    con8.Open();
                    cmd8.ExecuteNonQuery();
                    con8.Close();
                }

                Console.WriteLine("DO you want to purchase again..?(Y/N)");
                string Condi = Console.ReadLine();
                if(Condi=="Y")
                {
                    Console.WriteLine("Enter the productId:");
                    int prod1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Quantity:");
                    int Quan1 = Convert.ToInt32(Console.ReadLine());
                    Product1 obj2 = new Product1();

                    if (prod1 == 1)
                    {
                        int Totamt2 = obj2.Cookie(prod1, Quan1);

                        SqlConnection con5 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                        string sqlqry = "insert into Purchase(CustID,ProductID,Quantity,Totalamount) values(" + CustId1 + "," + prod1 + "," + Quan1 + "," + Totamt2 + ")";
                        SqlCommand cmd5 = new SqlCommand(sqlqry, con5);
                        con5.Open();
                        cmd5.ExecuteNonQuery();
                        con5.Close();

                    }
                    else if (prod1 == 2)
                    {
                        int Totamt2 = obj1.Crisps(prod, Quan);
                        SqlConnection con6 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                        string sqlqry = "insert into Purchase(CustId,ProductID,Quantity,Totalamount) values(" + CustId1 + "," + prod1 + "," + Quan1 + "," + Totamt2 + ")";
                        SqlCommand cmd6 = new SqlCommand(sqlqry, con6);
                        con6.Open();
                        cmd6.ExecuteNonQuery();
                        con6.Close();
                    }
                    else if (prod1 == 3)
                    {
                        int Totamt2 = obj1.Vegetables(prod, Quan);
                        SqlConnection con7 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                        string sqlqry = "insert into Purchase(CustId,ProductID,Quantity,Totalamount) values(" + CustId1 + "," + prod1 + "," + Quan1 + "," + Totamt2 + ")";
                        SqlCommand cmd7 = new SqlCommand(sqlqry, con7);
                        con7.Open();
                        cmd7.ExecuteNonQuery();
                        con7.Close();
                    }
                    else if (prod1 == 4)
                    {

                        int Totamt2 = obj1.CandyBars(prod, Quan);
                        SqlConnection con8 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                        string sqlqry = "insert into Purchase(CustId,ProductID,Quantity,Totalamount) values(" + CustId1 + "," + prod + "," + Quan + "," + Totamt2 + ")";
                        SqlCommand cmd8 = new SqlCommand(sqlqry, con8);
                        con8.Open();
                        cmd8.ExecuteNonQuery();
                        con8.Close();
                    }
                }
                Console.WriteLine("Want to print your Bill?(Y/N)");
                string condition = Console.ReadLine();
                if(condition=="Y")
                {
                    SqlConnection con10 = new SqlConnection("data source = HARIS;database=product;user id=sa;password=P@ssw0rd");
                    SqlCommand cmd10 = new SqlCommand("select BillNo,pur.CustID,CustomerName,pur.ProductId,Quantity,Totalamount,ContactNO,Date from[dbo].[Purchase]pur join[dbo].[product]pro on pur.ProductID = pro.ProductId join[dbo].[Customer]cust on cust.CustID = pur.CustID",con10);
                    Console.WriteLine("Welcome..! You are Existing Customer.");
                    con10.Open();
                    SqlDataReader dr1 = cmd10.ExecuteReader();
                    while (dr1.Read())
                    {

                        Console.WriteLine(" BillNo " + dr1[0] + " CustID : " + dr1[1] + "          CustomerName : " + dr1[2] + "     ProductID :" + dr1[3] + "  Quantity :" + dr1[4] + "TotalAmount:" + dr1[5] + " ContactNo :" + dr1[6] + "Date:" +dr1[7]);
                    }
                    con10.Close();
                    
                }
                else if (condition == "N")
                {
                    Console.WriteLine("Welcome again.");
                }

                   
                //Console.WriteLine("Do you want to continue your shopping..?(Y/N)");
                //string condition = Console.ReadLine();
                //if(condition=="Y")
                //{
                //    Console.WriteLine("Enter the productId:");
                //    int prod1 = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine("Enter the Quantity:");
                //    int Quan1 = Convert.ToInt32(Console.ReadLine());

                //    if (prod1 == 1)
                //    {
                //        obj1.Cookie(prod1, Quan1);
                //    }
                //    else if (prod1 == 2)
                //    {
                //        obj1.Crisps(prod1, Quan1);
                //    }
                //    else if (prod1 == 3)
                //    {
                //        obj1.Vegetables(prod1, Quan1);
                //    }
                //    else if (prod1 == 4)
                //    {
                //        obj1.CandyBars(prod1, Quan1);
                //    }

                //}

            }
            else
            {
                ProductTask obj = new ProductTask();
                obj.LoginFailed();
            }
        }


    }
 }
