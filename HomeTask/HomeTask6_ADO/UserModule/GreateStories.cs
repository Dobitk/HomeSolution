using System;
using System.Data.SqlClient;

namespace HomeTask6_ADO.UserModule
{
    class GreateStories
    {

        public static void CreateTable()
        {
            try
            {
                     string QueryCommand = @"CREATE TABLE [dbo].[Stories](
                                          [Id] [int] IDENTITY(1,1) NOT NULL,
	                                      [NameStory] [nchar](50) NULL,
	                                      [Discription] [nvarchar](50) NULL,
	                                      [DateStory] [datetime] NULL)";

                     string connectionString = Connection.AllConnection();

                     using (SqlConnection SqlConnect = new SqlConnection(Connection.AllConnection()))
                     {
                           SqlCommand command = new SqlCommand(QueryCommand, SqlConnect);
                           SqlConnect.Open();
                           command.ExecuteNonQuery();

 
                     }
            }
            catch (Exception e)
            {
                    Console.WriteLine(e);
                    Console.Read();

            }
        }
    }
}
