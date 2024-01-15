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
    public class PaymentService
    {
        private readonly string filePath = "payments.json";
        private List<Payment> payments;

        public PaymentService()
        {
            payments = LoadPayments();
        }

        public void AddPayment(Payment newPayment)
        {
            // Increment the ID
            newPayment.Id = payments.Any() ? payments.Max(u => u.Id) + 1 : 1;


            payments.Add(newPayment);


            SavePayment();
        }

        private void SavePayment()
        {
            string json = JsonConvert.SerializeObject(payments, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private List<Payment> LoadPayments()
        {
            if (!File.Exists(filePath))
            {
                return new List<Payment>();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Payment>>(json) ?? new List<Payment>();
        }
    }
}
