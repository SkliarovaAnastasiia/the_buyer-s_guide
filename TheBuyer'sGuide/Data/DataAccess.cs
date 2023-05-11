using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using the_buyer_s_guide.Models;

namespace the_buyer_s_guide.Data
{
    internal class DataAccess
    {
        const string DATA_PATH = "TradingDataModel.json";

        public static void Save(TraidingDataModel traidingDataModel)
        {
            string jsonString = JsonSerializer.Serialize(traidingDataModel.TradingPoints);

            File.WriteAllText(DATA_PATH, jsonString);
        }

        public static void Load(TraidingDataModel traidingDataModel)
        {
            string jsonString = File.ReadAllText(DATA_PATH);

            traidingDataModel.TradingPoints = JsonSerializer.Deserialize<List<PointDataModel>>(jsonString);
        }
    }
}
