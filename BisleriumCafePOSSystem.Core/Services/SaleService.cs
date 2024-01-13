using BisleriumCafePOSSystem.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisleriumCafePOSSystem.Core.Services
{
    public class SaleService
    {
        private List<Sale> sales;
        private readonly string filePath = "sales.json";
        private MemberService memberService;

        // Assuming these services are available for fetching prices
        private AddInService addInService;
        private CoffeeService coffeeService;

        public SaleService(MemberService memberService, AddInService addInService, CoffeeService coffeeService)
        {
            this.memberService = memberService;
            this.addInService = addInService;
            this.coffeeService = coffeeService;
            sales = LoadSales() ?? new List<Sale>();
        }

        //public void ProcessSale(Sale sale)
        //{
        //    Member member = memberService.GetMemberByPhoneNumber(sale.PhoneNumber);

        //    if (member != null)
        //    {
        //        if (member.MembershipType == "Regular" && IsRegularEligible(member, sale.Date))
        //        {
        //            sale.Discount = CalculateRegularMemberDiscount(sale.TotalBill);
        //        }
        //        else if (member.MembershipType == "Basic")
        //        {
        //            if (IsEligibleForFreeCoffee(member))
        //            {
        //                // Apply free coffee logic
        //            }
        //        }

        //        memberService.UpdateMemberPurchaseHistory(member.Id, sale.Date);
        //    }

        //    sale.TotalBill -= sale.Discount;
        //    sales.Add(sale);
        //    SaveSales();
        //}

        //private double CalculateInitialBill(Sale sale)
        //{
        //    double bill = 0.0;

        //    bill += coffeeService.GetPrice(sale.CoffeeType) * sale.Quantity;
        //    bill += sale.AddIns.Sum(addIn => addInService.GetPrice(addIn));

        //    // Assuming tax rate is a constant, e.g., 10%
        //    const double taxRate = 0.10;
        //    bill *= (1 + taxRate);

        //    return bill;
        //}

        //private double ApplyDiscountsAndOffers(Sale sale, Member member, double totalBill)
        //{
        //    switch (member.MembershipType)
        //    {
        //        case "Regular":
        //            if (IsRegularEligible(member, sale.Date))
        //            {
        //                totalBill *= 0.90; // 10% discount
        //            }
        //            break;
        //        case "Basic":
        //            if (member.PurchaseHistory.Count % 10 == 0) // Every 10th purchase
        //            {
        //                totalBill = 0; // Free coffee
        //            }
        //            break;
        //    }
        //    return totalBill;
        //}

        //private bool IsRegularEligible(Member member, DateTime currentDate)
        //{
        //    // Define the start of the month
        //    DateTime startOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);

        //    // Iterate through each day of the current month up to the current date
        //    for (DateTime date = startOfMonth; date <= currentDate; date = date.AddDays(1))
        //    {
        //        // Skip weekends
        //        if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
        //            continue;

        //        // Check if the member made a purchase on this day
        //        if (!member.PurchaseHistory.Contains(date))
        //            return false;
        //    }

        //    return true; // Eligible if purchases were made every weekday of the month
        //}

        //private void UpdateMemberPurchaseHistory(Member member, DateTime purchaseDate)
        //{
        //    // Avoid adding duplicate entries for the same day
        //    if (!member.PurchaseHistory.Contains(purchaseDate.Date))
        //    {
        //        member.PurchaseHistory.Add(purchaseDate.Date);
        //        memberService.SaveMembers();
        //    }
        //}


        public void SaveSale()
        {
            string json = JsonConvert.SerializeObject(sales, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public List<Sale> LoadSales()
        {
            if (!File.Exists(filePath))
            {
                return new List<Sale>();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Sale>>(json) ?? new List<Sale>();
        }
    }
}
