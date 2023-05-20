using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using TraidingPointsApp.Models;

namespace TraidingPointsApp.Data
{
    internal class DataAccess
    {
        const string DATA_PATH = "TradingPoints.json";
        const string FAVORITES_PATH = "Favorites.json";

        public static void Save(TraidingPoints traidingPoints)
        {
            string jsonString = JsonSerializer.Serialize(traidingPoints.Shops);
            File.WriteAllText(DATA_PATH, jsonString);
            traidingPoints.IsDirty = false;
        }

        public static void Load (TraidingPoints traidingPoints)
        {
            string jsonString = File.ReadAllText(DATA_PATH);
            traidingPoints.Shops = JsonSerializer.Deserialize<List<Shop>>(jsonString);
            var newTradingPoints = JsonSerializer.Deserialize<List<Shop>>(jsonString);
            traidingPoints.Shops.Clear();
            traidingPoints.Shops.AddRange(newTradingPoints);
            traidingPoints.IsDirty = false;
        }

        public static void SaveFavorites(List<Shop> favorites)
        {
            string jsonString = JsonSerializer.Serialize(favorites);
            File.WriteAllText(FAVORITES_PATH, jsonString);
        }

        public static List<Shop> LoadFavorites()
        {
            if (File.Exists(FAVORITES_PATH))
            {
                string jsonString = File.ReadAllText(FAVORITES_PATH);
                return JsonSerializer.Deserialize<List<Shop>>(jsonString);
            }
            else
            {
                return new List<Shop>();
            }
        }
        
    }
}
