using System;
using System.Collections.Generic;
using System.Text;
using HomeTask5_2.UserClassModules;

namespace HomeTask5_2.UserModules
{
    class NeighborhoodAdd
    {
        public static List<Neighborhood> neighborhoods()
        {
            var neighborhood = new List<Neighborhood>
            {
                new Neighborhood() {Id = 1, HouseNumber = "10", StreetName = "Chapel", YesContry = true, NeighborhoodName = "Fitzroy"},
                new Neighborhood() {Id = 2, HouseNumber = "1", StreetName = "Collins", YesContry = true, NeighborhoodName = "Collingwood"},
                new Neighborhood() {Id = 3, HouseNumber = "5", StreetName = "Lygon", YesContry = true, NeighborhoodName = "Brunswick"},
                new Neighborhood() {Id = 4, HouseNumber = "105", StreetName = "Bourke", YesContry = false, NeighborhoodName = "Carlton"},
                new Neighborhood() {Id = 5, HouseNumber = "12", StreetName = "Brunswick", YesContry = true, NeighborhoodName = "Hakodate"},
                new Neighborhood() {Id = 6, HouseNumber = "45", StreetName = "Acland", YesContry = true, NeighborhoodName = "Tokyo"},
                new Neighborhood() {Id = 7, HouseNumber = "6", StreetName = "Flinders", YesContry = false, NeighborhoodName = "Sappord"},
                new Neighborhood() {Id = 7, HouseNumber = "16", StreetName = "Tsaricova", YesContry = false, NeighborhoodName = "Asahikawa"},
                new Neighborhood() {Id = 9, HouseNumber = "8", StreetName = "Wynnum", YesContry = true, NeighborhoodName = "Tsarikova"},
                new Neighborhood() {Id = 10, HouseNumber = "15", StreetName = "Manly", YesContry = false, NeighborhoodName = "Hakodate"},
                new Neighborhood() {Id = 11, HouseNumber = "61", StreetName = "Logan", YesContry = true, NeighborhoodName = "Tokyo"},
                new Neighborhood() {Id = 12, HouseNumber = "36", StreetName = "Old Cleveland", YesContry = false, NeighborhoodName = "Bangalore"},
                new Neighborhood() {Id = 13, HouseNumber = "17", StreetName = "Gateway Motorway", YesContry = true, NeighborhoodName = "Chennai"},
                new Neighborhood() {Id = 14, HouseNumber = "102", StreetName = "Jozankei", YesContry = true, NeighborhoodName = "Sheveleva"},
                new Neighborhood() {Id = 15, HouseNumber = "99", StreetName = "Heiwa ", YesContry = false, NeighborhoodName = "Delhi"},
                new Neighborhood() {Id = 16, HouseNumber = "1", StreetName = "Koganeyu", YesContry = true, NeighborhoodName = "Hyderabad"},
            };
            return neighborhood;
        }
    }
}
