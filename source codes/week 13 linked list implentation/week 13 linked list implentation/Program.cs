using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_13_linked_list_implentation
{
    class Program
    {
        public class perCity
        {
            public int irCurrentIndex = 0;
            public int irEdgeWeight = 0;
            public int irNextCityIndex = 0;
        }

        static void Main(string[] args)
        {
            string[] cityList = { "Atlanta", "Austin", "Chicago", "Dallas", "Denver", "Houston", "Washington" };

            List<perCity> myCitiesList = new List<perCity>();

            myCitiesList.Add(new perCity { irCurrentIndex = Array.IndexOf(cityList, "Atlanta"), irNextCityIndex = Array.IndexOf(cityList, "Houston"), irEdgeWeight = 800 });
            myCitiesList.Add(new perCity { irCurrentIndex = Array.IndexOf(cityList, "Houston"), irNextCityIndex = Array.IndexOf(cityList, "Washington"), irEdgeWeight = 600 });
            myCitiesList.Add(new perCity { irCurrentIndex = Array.IndexOf(cityList, "Washington"), irNextCityIndex = -1, irEdgeWeight = 0 });
        }
    }
}
