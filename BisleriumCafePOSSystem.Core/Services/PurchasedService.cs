using BisleriumCafePOSSystem.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisleriumCafePOSSystem.Core.Services
{
    public class PurchaseService
    {
        private MemberService memberService;

        public PurchaseService(MemberService memberService)
        {
            this.memberService = memberService;
        }

        public double CalculateTotalBill(string coffeeType, int quantity, double addInsPrice)
        {
            double coffeePrice = GetCoffeePrice(coffeeType);
            return (coffeePrice + addInsPrice) * quantity;
        }

        public double CalculateDiscount(Member member, double totalBill)
        {
            if (member.MembershipType == "Regular")
            {
                return totalBill * 0.1; // 10% discount
            }
            else if (member.MembershipType == "Basic" && IsEligibleForFreeCoffee(member))
            {
                double priceOfOneCoffee = GetCoffeePrice("default"); // Assuming a default coffee type for the free one
                return priceOfOneCoffee;
            }
            return 0;
        }

        private double GetCoffeePrice(string coffeeType)
        {
            // Implement logic to get coffee price based on coffeeType
        }

        private bool IsEligibleForFreeCoffee(Member member)
        {
            return member.PurchaseCount % 10 == 0;
        }

        public void ProcessPurchase(Member member, string coffeeType, int quantity, double addInsPrice, double freeCoffeePrice)
        {
            double totalBill = CalculateTotalBill(coffeeType, quantity, addInsPrice);
            double discount = CalculateDiscount(member, totalBill, freeCoffeePrice);

            // Continue with the rest of the processing...
        }

        public double CalculateDiscount(Member member, double totalBill, double freeCoffeePrice)
        {
            // Modify this method to take into account the freeCoffeePrice
            // Return the calculated discount
        }

        private void SavePurchaseDetails(Member member, string coffeeType, int quantity, double finalBill, double discount)
        {
            // TODO: Implement logic to save purchase details to a JSON file
        }
    }

}
