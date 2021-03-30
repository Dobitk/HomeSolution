using System.Configuration;

namespace HomeTask6_ADO.UserModule
{
    class Connection
    {
       public static string AllConnection()
        {
           
            return ConfigurationManager.ConnectionStrings["MyConnect"].ConnectionString;
        }
    }
}
