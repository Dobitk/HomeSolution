using System.Configuration;

namespace HomeTask9.Services
{
    class Connect 
    {
        public static string StringConnect()
        {
            return ConfigurationManager.ConnectionStrings["Connectbase"].ConnectionString;
        }
    }
}
