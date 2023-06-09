﻿using System.Collections.Generic;

namespace TraidingPointsApp.Models
{
    public class TraidingPoints
    {
        public TraidingPoints()
        {
            Shops = new List<Shop>(); 
            Favorites = new List<Shop>(); 
        }

        public List<Shop> Shops { get; set; }

        public List<Shop> Favorites { get; set; }
        public bool IsDirty { get; set; }
        public bool IsFavoritesDisplayed { get; set; }
        public bool IsFavoritesDirty { get; set; }

        //public void GenTestData(int n)
        //{
        //    Shops = new List<Shop>();
        //    for (int i = 0; i < n; i++)
        //    {
        //        var point = new Shop
        //        {
        //            Name = "TestPoint" + i,
        //            Address = "-----" + i,
        //            Telephone = "098" + i,
        //            Specialization = "0000" + i,
        //            Ownership = "74758" + i,
        //            WorkingHours = "800" + i,
        //        };
        //        Shops.Add(point);
        //    }
        //}

        internal List<Shop> SearchShops(string line)
        {
            List<Shop> result = new List<Shop>();
            var t = line.ToLower();

            foreach (Shop shop in Shops)
            {
                if (shop.Name != null && shop.Name.ToLower().IndexOf(t) > -1 ||
         shop.Specialization != null && shop.Specialization.ToLower().IndexOf(t) > -1 ||
         shop.Address != null && shop.Address.ToLower().IndexOf(t) > -1)
                {
                    result.Add(shop);
                }
            }

            return result;
        }
    }
}
