using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TraidingPointsApp.Models;

namespace TraidingPointsApp.Data
{
    internal class DataAccess
    {
        const string DATA_PATH = "TradingPoints.json";

        public static void Save(TraidingPoints traidingPoints)
        {
            string jsonString = JsonSerializer.Serialize(traidingPoints.Shops);
            File.WriteAllText(DATA_PATH, jsonString);
        }

        public static void Load (TraidingPoints traidingPoints)
        {
            string jsonString = File.ReadAllText(DATA_PATH);
            traidingPoints.Shops = JsonSerializer.Deserialize<List<Shop>>(jsonString);
        }
    }
}
