using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace the_buyer_s_guide.Models
{
    public class TraidingDataModel
    {
        public TraidingDataModel()
        {

        }
        public List<PointDataModel> TradingPoints { get; set; }

        public void GenTestData(int n)
        {
            TradingPoints = new List<PointDataModel>();
            for(int i = 0; i < n; i++)
            {
                var point = new PointDataModel
                {
                    Name = "TestPoint" + i,
                    Address = "-----" + i,
                    Telephone = "098" + i,
                    Specialization = "0000" + i, 
                    Ownership = "74758" + i,
                    WorkingHours = "800" + i, 
                };
                TradingPoints.Add(point);
            }
        }
    }
}
