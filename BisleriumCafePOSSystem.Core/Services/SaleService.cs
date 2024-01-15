using BisleriumCafePOSSystem.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
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

       
        private AddInService addInService;
        private CoffeeService coffeeService;

        public SaleService(MemberService memberService, AddInService addInService, CoffeeService coffeeService)
        {
            this.memberService = memberService;
            this.addInService = addInService;
            this.coffeeService = coffeeService;
            sales = LoadSales() ?? new List<Sale>();
        }

        public void ProcessSale(Sale sale)
        {
    

            Member member = memberService.GetMemberByPhoneNumber(sale.PhoneNumber);

            if (member != null)
            {
                
                UpdateMemberPurchaseHistory(member, sale.Date);

                
                if (member.MembershipType == "Regular" && IsRegularEligible(member, sale.Date))
                {
                    sale.Discount = CalculateRegularMemberDiscount(sale.TotalBill);
                }
                else if (member.MembershipType == "Basic" && IsEligibleForFreeCoffee(member))
                {
                    double coffeePrice = coffeeService.GetPrice(sale.CoffeeType);

                    double addInsPriceForOneCoffee = sale.AddIns.Sum(addIn => addInService.GetPrice(addIn));

                    double totalPriceForOneCoffee = coffeePrice + addInsPriceForOneCoffee;

                    sale.Discount = totalPriceForOneCoffee;
                }
            }

            sale.TotalBill = CalculateInitialBill(sale) - sale.Discount;
            SaveSale();

        }

        private double CalculateRegularMemberDiscount(double totalBill)
        {
           
            const double discountRate = 0.10;
            return totalBill * discountRate;
        }
        private double CalculateInitialBill(Sale sale)
        {
            double bill = 0.0;

            bill += coffeeService.GetPrice(sale.CoffeeType) * sale.Quantity;
           
            bill += sale.AddIns.Sum(addIn => addInService.GetPrice(addIn)) * sale.Quantity;

            return bill;
        }


        //.....
        private bool IsRegularEligible(Member member, DateTime currentDate)
        {
            if (member.JoiningDate != null)
            {
                if (!DateTime.TryParse(member.JoiningDate, out DateTime joiningDate))
                {
                    
                    return false;
                }

                if (joiningDate.Date == currentDate.Date)
                {
                    // Member is eligible on the joining date
                    return true;
                }
            }

            // If it's a weekend, return false
            if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            // Check for a purchase on the previous business day
            DateTime previousBusinessDay = GetPreviousBusinessDay(currentDate);
            return member.PurchaseHistory.Any(purchaseDate => purchaseDate.Date == previousBusinessDay.Date);
        }

        private DateTime GetPreviousBusinessDay(DateTime currentDate)
        {
            DateTime previousDay = currentDate.AddDays(-1);

            while (previousDay.DayOfWeek == DayOfWeek.Saturday || previousDay.DayOfWeek == DayOfWeek.Sunday)
            {
                previousDay = previousDay.AddDays(-1);
            }

            return previousDay;
        }


        //....
        private bool IsEligibleForFreeCoffee(Member member)
        {
            return member.PurchaseCount % 10 == 1;
        }

  

        private void UpdateMemberPurchaseHistory(Member member, DateTime purchaseDate)
        {
            if (!member.PurchaseHistory.Contains(purchaseDate.Date))
            {
                member.PurchaseHistory.Add(purchaseDate.Date);
            }

            member.PurchaseCount++; 
            memberService.SaveMembers();
        }
        public void AddSale(Sale newSale)
        {
            // Increment the ID
            newSale.Id = sales.Any() ? sales.Max(u => u.Id) + 1 : 1;


            sales.Add(newSale);


            SaveSale();
        }
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
