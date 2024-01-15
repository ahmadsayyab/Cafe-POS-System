using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisleriumCafePOSSystem.Core.Model
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string JoiningDate { get; set; }
        public string MembershipType { get; set; }

        public List<DateTime> PurchaseHistory { get; set; }
        public int PurchaseCount { get; set; }

        public Member()
        {
            PurchaseHistory = new List<DateTime>();
            PurchaseCount = 0;
        }


    }
}
