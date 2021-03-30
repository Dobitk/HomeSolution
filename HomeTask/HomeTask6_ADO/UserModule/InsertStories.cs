using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6_ADO.UserModule
{
    class InsertStories
    {
        public static void InsertTable( string nameStory, string discription, DateTime dateStory)
        {
            try
            {
                string SqlInsert = @"INSERT INTO Stories (NameStory, Discription, DateStory)
                                   VALUES (@namestory, @discription, @datestory)";


                using (SqlConnection connection = new SqlConnection(Connection.AllConnection()))
                {
                    SqlCommand command = new SqlCommand(SqlInsert, connection);
             //       command.Parameters.Add(new SqlParameter("@id", id));
                    command.Parameters.Add(new SqlParameter("@namestory", nameStory));
                    command.Parameters.Add(new SqlParameter("@discription", discription));
                    command.Parameters.Add(new SqlParameter("@datestory", dateStory));
                    connection.Open();
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                Console.Read();
            }

        }

        public static void InsertValues()
        {
            InsertTable("Клеопатра", "Знаменитая царица Египта", Convert.ToDateTime("12.06.2019"));
            InsertTable("Елизавета", "Королева Англии", Convert.ToDateTime("13.09.2020")); 
            InsertTable("Александр Македонский", "Полководец", Convert.ToDateTime("01.02.2021"));
        }
    }
}
