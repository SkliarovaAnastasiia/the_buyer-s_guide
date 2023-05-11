using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBuyer_sGuide.Models
{
    internal class TradingPoints
    {
      public TradingPoints()
        {

        }
        public List<Shop> Shops { get; set; }

        public void GenTestData(int n)
        {
            Shops = new List<Shop>();
            for (int i = 0; i < n; i++)
            {
                var point = new Shop
                {
                    Name = "TestPoint" + i,
                    Address = "-----" + i,
                    Telephone = "098" + i,
                    Specialization = "0000" + i,
                    Ownership = "74758" + i,
                    WorkingHours = "800" + i,
                };
                Shops.Add(point);
            }
        }
    }
}
