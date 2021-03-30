using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6_ADO.UserModule
{
    class SelectStories
    {
        public static void SelectTable()
        {
            try
            {
                string SQLSelect = @"SELECT * FROM Stories";

                using (SqlConnection connection = new SqlConnection(Connection.AllConnection()))
                {
                    SqlCommand command = new SqlCommand(SQLSelect, connection);
                    connection.Open();
                    SqlDataReader reader =  command.ExecuteReader();

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object namestory = reader.GetValue(1);
                        object discription = reader.GetValue(2);
                        object datestory = reader.GetValue(3);
                        Console.WriteLine($"{id}\t{namestory}\t{discription}\t{datestory}");
                        
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.Read();
            }

            Console.Read();

        }

    }
}
