using System;
using System.Collections.Generic;
using System.Text;
using HomeTask5_2.UserClassModules;

namespace HomeTask5_2.UserModules
{
    class DistrictAdd
    {
        public static List<District> districts()
        {
            var district = new List<District>
            {
                new District() {Id = 1, DistrictName = "Victoria", City = "Melbourne"},
                new District() {Id = 2, DistrictName = "Queensland", City = "Brisbane"},
                new District() {Id = 8, DistrictName = "Hokkaido", City = "Sapporo"},
                new District() {Id = 9, DistrictName = "Hokkaido", City = "Asahikawa"},
                new District() {Id = 10, DistrictName = "Hokkaido", City = "Hakodate"},
                new District() {Id = 11, DistrictName = "Maharashtra", City = "Greater Mumbai"},
                new District() {Id = 12, DistrictName = "Maharashtra", City = "Puna"},
            };

            return district;
        }

    }
}
