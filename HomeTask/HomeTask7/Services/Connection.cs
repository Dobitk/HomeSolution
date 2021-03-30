using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace HomeTask7.Services
{
    class Connection
    {
       public static string ConnectionBase()
        {
           
            return ConfigurationManager.ConnectionStrings["Connectbase"].ConnectionString;
        }
    }
}
