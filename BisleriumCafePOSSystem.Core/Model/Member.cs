﻿using System;
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
        public string JoininDate { get; set; }
        public string MembershipType { get; set; }

        public int PurchaseCount { get; set; } // Added to track the number of purchases


    }
}