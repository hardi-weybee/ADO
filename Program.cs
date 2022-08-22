using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.net
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //new Program().CreateTable();
            //new Program().InsertData();
            new Program().RetriveData();            
            //new Program().DeletingData();
        }

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = Student; integrated security = SSPI");

                SqlCommand cm = new SqlCommand("create table student" +
                    "(id int not null, name varchar(100), email varchar(50), join_date date)", con);

                con.Open();

                cm.ExecuteNonQuery();

                Console.WriteLine("Table created successfully");

            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong" + e);
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = Student; integrated security = SSPI");

                SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date) values('1', 'Hardi', 'hardi@gmail.com', '6/7/2020'), ('2', 'Misari', 'misari@gmail.com', '10/4/2019'), ('3', 'Rishit', 'rishit@gmail.com', '2/10/2020')", con);

                con.Open();

                cm.ExecuteNonQuery();

                Console.WriteLine("Data inserted successfully");
            } catch (Exception e)
            {
                Console.WriteLine("Something went wrong" + e);
            } finally
            {
                con.Close();
            }
        }

        public void RetriveData()
        {
            using(SqlConnection con = new SqlConnection("data source = .; database = Student; integrated security = SSPI"))
            {
                SqlCommand cm = new SqlCommand("select * from Student", con);
                con.Open();

                SqlDataReader sr = cm.ExecuteReader();

                while(sr.Read())
                {      
                    Console.WriteLine($"{sr["id"]}   {sr["name"]}   {sr["email"]}   {sr["join_date"]}");
                }
            }
            Console.ReadLine();

            //SqlConnection con = null;
            //try
            //{
            //    con = new SqlConnection("data source = .; database = Student; integrated security = SSPI");

            //    SqlCommand cm = new SqlCommand("select * from Student", con);

            //    con.Open();

            //    SqlDataReader sr = cm.ExecuteReader();

            //    while(sr.Read())
            //    {
            //        Console.WriteLine(sr["id"] + " " + sr["name"] + " " + sr["email"] + " " + sr["join_date"]);
            //    }
            //} catch (Exception e)
            //{
            //    Console.WriteLine("Something went wrong" + e);
            //} finally
            //{
            //    con.Close();
            //}
            //Console.ReadLine();
        }

        public void DeletingData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = Student; integrated security = SSPI");

                SqlCommand cm = new SqlCommand("delete from Student", con);

                con.Open();

                cm.ExecuteNonQuery();

                Console.WriteLine("Deleted successfully");
            } catch (Exception e)
            {
                Console.WriteLine("Something went wrong" + e);
            } finally
            {
                con.Close();
            }
        }
    }
}
