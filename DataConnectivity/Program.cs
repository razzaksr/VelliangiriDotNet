using System;
using System.Data;
using System.Data.SqlClient;

namespace DataConnectivity
{
    class Program
    {
        static void Main(string[] args)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=SRDB\\SQLEXPRESS;Initial Catalog=velliangiri;Integrated Security=True"))
            {
                connection.Open();
                // table creation
                /*Console.WriteLine("Connection opened");

                SqlCommand cmd = new SqlCommand("create table notes (title varchar(255) not null, description varchar(255) not null, date date not null)", connection);

                //cmd.ExecuteNonQuery();

                Console.WriteLine("table created");

                //cmd = new SqlCommand("alter table notes add id int identity(1,1)", connection);
                cmd = new SqlCommand("alter table notes add primary key(id)", connection);

                cmd.ExecuteNonQuery();

                //SqlCommand cmd = new SqlCommand("alter table notes add id int identity(1,1) go alter table notes drop column id ", connection);

                //SqlCommand cmd = new SqlCommand("drop table notes", connection);

                Console.WriteLine("Identity column added");*/

                // insertion
                /*String tit = Console.ReadLine();
                String des = Console.ReadLine();
                String date = Console.ReadLine();

                SqlCommand cmd = new SqlCommand("insert into notes(title,description,date) values(@a,@b,@c)",connection);
                cmd.Parameters.AddWithValue("@a", tit);
                cmd.Parameters.AddWithValue("@b", des);
                cmd.Parameters.AddWithValue("@c", date);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Record added, Connection closed");*/


                /*int id=Int32.Parse(Console.ReadLine());
                String tit = Console.ReadLine();
                String des = Console.ReadLine();
                String date = Console.ReadLine();

                SqlCommand cmd = new SqlCommand("update notes set title=@a, description=@b, date=@c where id=@i ", connection);
                cmd.Parameters.AddWithValue("@a", tit);
                cmd.Parameters.AddWithValue("@b", des);
                cmd.Parameters.AddWithValue("@c", date);
                cmd.Parameters.AddWithValue("@i", id);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Record updated, Connection closed");
                */


                /*
                // remove single record
                int id = Int32.Parse(Console.ReadLine());
                SqlCommand cmd = new SqlCommand("delete from notes where id=@i", connection);
                cmd.Parameters.AddWithValue("@i", id);
                Console.WriteLine("Record deleted");
                */

                /*
                                // table : truncate>> delete all records
                                SqlCommand cmd = new SqlCommand("truncate table notes", connection);

                                cmd.ExecuteNonQuery();


                                Console.WriteLine("Table becomes empty");*/
                /*
                                // drop : table
                                SqlCommand cmd = new SqlCommand("drop table notes", connection);
                                cmd.ExecuteNonQuery();


                                Console.WriteLine("Table deleted");*/
                /*
                                //fetch all
                                SqlCommand cmd = new SqlCommand("select * from expert",connection);
                                SqlDataReader reader = cmd.ExecuteReader();
                                while(reader.Read())
                                {
                                    Console.WriteLine(reader[0]+" "+reader[1]+" "+reader[2]+" "+reader[3]);
                                }*/
                /*
                                //fetch one record
                                SqlCommand cmd = new SqlCommand("select * from expert where exp=9.6", connection);
                                SqlDataReader reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]);
                                }*/

                /*
                                //fetch records by like constrain
                                SqlCommand cmd = new SqlCommand("select * from expert where skill like '%python%' ", connection);
                                SqlDataReader reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]);
                                }*/

                //fetch records by between constrain
                SqlCommand cmd = new SqlCommand("select * from expert where exp between 5 and 10", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]);
                }
            }
        }
    }
}
