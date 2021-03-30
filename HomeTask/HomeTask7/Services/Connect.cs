using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7.Services
{
    class Connect 
    {
        public static string StringConnect()
        {
            return ConfigurationManager.ConnectionStrings["Connectbase"].ConnectionString;
        }
    }
}
