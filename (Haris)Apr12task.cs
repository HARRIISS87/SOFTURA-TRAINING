using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Dataa
{
    class Apr12task
    {
       
        public void createtable()
        {
            SqlConnection con = new SqlConnection("data source = HARIS;database=HARIS;user id=sa;password=P@ssw0rd");
            con.Open();
            SqlCommand cmd = new SqlCommand("create table newTaskTest (sno int, StuName varchar(20))", con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Completed Query");
            con.Close();
        }
        public void insertmeth(int sno, string StuName)
        {
            SqlConnection con = new SqlConnection("data source = HARIS;database=HARIS;user id=sa;password=P@ssw0rd");
            SqlCommand cmd = new SqlCommand("sp_insTask", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            cmd.Parameters.Add("@StuName", SqlDbType.VarChar).Value = StuName;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Updatemeth(int sno, string StuName)
        {

            SqlConnection con = new SqlConnection("data source = HARIS;database=HARIS;user id=sa;password=P@ssw0rd");
            SqlCommand cmd = new SqlCommand("upd_task", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            cmd.Parameters.Add("@StuName", SqlDbType.VarChar).Value = StuName;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void deletemeth(int sno)
        {
            SqlConnection con = new SqlConnection("data source = HARIS;database=HARIS;user id=sa;password=P@ssw0rd");
            SqlCommand cmd = new SqlCommand("del_task", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void Main()
        {
            Apr12task nobj = new Apr12task();
            //nobj.createtable();
           //Console.WriteLine("Press any Key to Continue....");
           //Console.ReadLine();
            Console.WriteLine("Enter sno");
            int sn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a topic");
            string tpic = Console.ReadLine();
            //nobj.insertmeth(sn, tpic);
            //nobj.Updatemeth(sn,tpic);
            nobj.deletemeth(sn);

        }
    }
}



//Procedures
//create proc sp_insTask
//@sno int, @StuName Varchar(20)
//as
//insert[dbo].[newTaskTest] values (@sno, @StuName)

//select* from[dbo].[newTaskTest]
//create proc upd_task
//@sno int , @stuName varchar(20)
//as
//update[dbo].[newTaskTest] set StuName = @stuName where sno=@sno

//create proc del_task
//@sno int
//as
//delete [dbo].[newTaskTest] where sno = @sno

//select*from [dbo].[newTaskTest] 
