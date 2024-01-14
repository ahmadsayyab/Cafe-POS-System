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
    public class AddInService
    {
        public readonly string filePath = "addIns.json";
        public List<AddIn> addIns;

        public AddInService()
        {
            addIns = LoadAddIns();
        }

        public void AddAddIn(AddIn addIn)
        {

            addIn.Id = addIns.Any() ? addIns.Max(c => c.Id) + 1 : 1;

            addIns.Add(addIn);
            SaveAddIn();
        }

        public List<AddIn> LoadAddIns()
        {
            if (!File.Exists(filePath))
            {
                return new List<AddIn>();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<AddIn>>(json) ?? new List<AddIn>();
        }

        public void SaveAddIn()
        {
            string json = JsonConvert.SerializeObject(addIns, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }


        public double GetPrice(string addInName)
        {
            var addIn = addIns.FirstOrDefault(a => a.Name.Equals(addInName, StringComparison.OrdinalIgnoreCase));
            return addIn != null ? addIn.Price : 0;
        }

        public double GetTotalPriceForSelectedAddIns(IEnumerable<string> selectedAddInNames)
        {
            double totalPrice = 0;
            foreach (var name in selectedAddInNames)
            {
                totalPrice += GetPrice(name);
            }
            return totalPrice;
        }
    }
}
