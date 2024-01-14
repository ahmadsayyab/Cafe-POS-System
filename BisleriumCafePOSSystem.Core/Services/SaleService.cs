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
                    double addInsPrice = sale.AddIns.Sum(addIn => addInService.GetPrice(addIn)) * sale.Quantity;

                    
                    sale.Discount = coffeePrice + addInsPrice;
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

        private bool IsRegularEligible(Member member, DateTime currentDate)
        {
            
            DateTime startOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);

            
            for (DateTime date = startOfMonth; date <= currentDate; date = date.AddDays(1))
            {
                // Skip weekends
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    continue;

                
                if (!member.PurchaseHistory.Contains(date))
                    return false;
            }

            return true; 
        }

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
