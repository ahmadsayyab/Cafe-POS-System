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
            sale.TotalBill = CalculateInitialBill(sale);

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

            //sale.TotalBill = CalculateInitialBill(sale) - sale.Discount;
            sale.TotalBill -= sale.Discount;
            SaveSale();

        }
        
        private double CalculateRegularMemberDiscount(double totalBill)
        {
           
            const double DISCOUNT = 0.1;
            return totalBill * DISCOUNT;
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

            
            if (!DateTime.TryParse(member.JoiningDate, out DateTime joiningDate))
            {
               
                return false;
            }

           
            if (joiningDate.Date == currentDate.Date)
            {
                // Member is eligible on the joining date.
                return true;
            }
            DateTime startDate = joiningDate.Date;
            DateTime endDate = currentDate.Date;

            // Check each day from joining date to current date
            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                
                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }

                // Check if there is a purchase on this day
                if (!member.PurchaseHistory.Any(date => date.Date == day.Date))
                {
                   
                    return false;
                }
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




        public List<Sale> GetAllSales()
        {
            return sales;
        }

        public List<Sale> GetSalesByDate(DateTime date)
        {
            
            return sales.Where(s => s.Date.Date == date.Date).ToList();
        }

        public List<Sale> GetSalesByMonth(int month, int year)
        {
            
            return sales.Where(s => s.Date.Month == month && s.Date.Year == year).ToList();
        }

        private List<ReportData> AggregateData(List<Sale> filteredSales)
        {
            // Group the filtered sales by coffee type and add-ins
            var groupedSales = filteredSales.GroupBy(s => new { s.CoffeeType, AddIns = string.Join(", ", s.AddIns.OrderBy(a => a)) });

            // Create report data
            var reportDataList = groupedSales.Select(group => new ReportData
            {
                CoffeeType = group.Key.CoffeeType,
                AddIns = group.Key.AddIns,
                QuantitySold = group.Sum(g => g.Quantity),
                Revenue = group.Sum(g => g.TotalBill)
            })
            .OrderByDescending(rd => rd.QuantitySold) // Order by most frequently purchased
            .Take(5) // Take top 5
            .ToList();

            return reportDataList;
        }

       


        public List<ReportData> GenerateReportDataForSales(List<Sale> filteredSales)
        {
            return AggregateData(filteredSales);
        }


        public double CalculateTotalRevenue(List<Sale> sales)
        {
            return sales.Sum(s => s.TotalBill);
        }


    }
}
