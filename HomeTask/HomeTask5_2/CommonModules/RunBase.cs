using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HomeTask5_2.UserClassModules;
using HomeTask5_2.UserModules;

namespace HomeTask5_2.CommonModules
{
     
    class RunBase
    {

        public static void Runbase ()
        {
            var _country = CountryAdd.country();
            var _district = DistrictAdd.districts();
            var _city = CityAdd.CityList();
            var _neighborhood = NeighborhoodAdd.neighborhoods();


            var _query = from country in _country
                join district in _district on country.District equals district.DistrictName
                join city in _city on district.City equals city.NeighborhoodCity
                join neighborhood in _neighborhood on city.Neighborhood equals neighborhood.NeighborhoodName
                select new { neighborhood.StreetName };


            foreach (var item in _query)
            {

                Console.WriteLine($"Street:  {item.StreetName}");


            }




            //var _query = from country in _country
            //      group country by country.CountryName into newGroup

            //    select new
            //    {
            //        countryname = newGroup.Key,
            //        streetname = from fdCountry in newGroup 
            //            join district in _district on fdCountry.District equals district.DistrictName
            //            join city in _city on district.City equals city.NeighborhoodCity
            //            join neighborhood in _neighborhood on city.Neighborhood equals neighborhood.NeighborhoodName
            //            select new { neighborhood.StreetName }
            //     };

            //foreach (var item in _query)
            // {
            //     Console.WriteLine($"Country: {item.countryname}");
            //     Console.WriteLine("");
            //     foreach (var subitem in item.streetname)
            //     {

            //         Console.WriteLine($"Street:  {subitem.StreetName}");
            //     }
            //     Console.WriteLine(Environment.NewLine);
            // }

        }
    }
}
