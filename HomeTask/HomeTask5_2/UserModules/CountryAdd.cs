using System;
using System.Collections.Generic;
using System.Text;
using HomeTask5_2.UserClassModules;

namespace HomeTask5_2.UserModules
{
    class CountryAdd
    {
        public static List<Country> country()
        {
            var country = new List<Country>
            {
                new Country() {Id = 1, CountryName = "Australia", District = "Victoria"},
                new Country() {Id = 2, CountryName = "Japan", District = "Hokkaido"},
                new Country() {Id = 3, CountryName = "India", District = "Maharashtra"},

            };
            return country;
        }
    }
}
