using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPoints.Models
{
    public class Points
    {
        public Points()
        {

        }
        public List<Shop> Shops { get; set; }

        public void GenTestData(int n)
        {
            Shops = new List<Shop>();

            for(int i = 0; i < n; i++)
            {
                var shop = new Shop
                {
                    Name = "-9394014" + i,
                    Address = "jcnw" + i,
                    Telephone = "39-4" + i,
                    Specialization = "sdvn" + i,
                    Ownership = "ckcn" + i,
                    WorkingHours = "je " + i
                };

                Shops.Add(shop);
            }
        }
    }
}
