using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using HomeTask5_2.UserClassModules;

namespace HomeTask5_2.UserModules
{
     class CityAdd
    {
        public static List<City> CityList()
        {
            var city = new List<City>();

            city.Add(new City() { Id = 1, NeighborhoodCity = "Melbourne", Neighborhood = "Fitzroy" });
            city.Add(new City() { Id = 2, NeighborhoodCity = "Melbourne", Neighborhood = "Collingwood" });
            city.Add(new City() { Id = 3, NeighborhoodCity = "Melbourne", Neighborhood = "Carlton" });
            city.Add(new City() { Id = 4, NeighborhoodCity = "Melbourne", Neighborhood = "Brunswick" });
            city.Add(new City() { Id = 4, NeighborhoodCity = "Brisbane", Neighborhood = "West End" });
            city.Add(new City() { Id = 4, NeighborhoodCity = "Brisbane", Neighborhood = "Chinatown" });
            city.Add(new City() { Id = 5, NeighborhoodCity = "Abuta", Neighborhood = "Sapporo" });
            city.Add(new City() { Id = 6, NeighborhoodCity = "Sorachi", Neighborhood = "Asahikawa" });
            city.Add(new City() { Id = 7, NeighborhoodCity = "Sapporo", Neighborhood = "Hakodate" });
            city.Add(new City() { Id = 8, NeighborhoodCity = "Greater Mumbai", Neighborhood = "Tokyo" });
            city.Add(new City() { Id = 9, NeighborhoodCity = "Greater Mumbai", Neighborhood = "Bangalore" });
            city.Add(new City() { Id = 10, NeighborhoodCity = "Greater Mumbai", Neighborhood = "Chennai " });
            city.Add(new City() { Id = 11, NeighborhoodCity = "Puna", Neighborhood = "Delhi" });
            city.Add(new City() { Id = 12, NeighborhoodCity = "Puna", Neighborhood = "Hyderabad " });


            return city;
        }


    }
}
