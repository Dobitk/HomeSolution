using System.Configuration;

namespace HomeTask8.Services
{
    class Connect 
    {
        public static string StringConnect()
        {
            return ConfigurationManager.ConnectionStrings["Connectbase"].ConnectionString;
        }
    }
}
