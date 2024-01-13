using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisleriumCafePOSSystem.Core.Model
{
    public class Purchase
    {
        public int MemberId { get; set; }
        public string CoffeeType { get; set; }

        public string PhoneNumber {get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public List<string> AddIns { get; set; }
       
       
        public double TotalBill { get; set; }
        public double Discount { get; set; }
    }

}
