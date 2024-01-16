using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisleriumCafePOSSystem.Core.Model
{
    public class ReportData
    {
        public string CoffeeType { get; set; }
        public string AddIns { get; set; }
        public int QuantitySold { get; set; }
        public double Revenue { get; set; }
    }

}
