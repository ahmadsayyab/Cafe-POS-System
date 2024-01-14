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
    public class CoffeeService
    {
        private readonly string filePath = "coffee.json";
        public List<Coffee> coffees;
        


        public CoffeeService()
        {
            coffees = LoadCoffees();
        }

        public void AddCoffee(Coffee coffee)
        {
            
            coffee.Id = coffees.Any() ? coffees.Max(c => c.Id) + 1 : 1;

            coffees.Add(coffee);
            SaveCoffees();
        }

        public List<Coffee> LoadCoffees()
        {
            if (!File.Exists(filePath))
            {
                return new List<Coffee>();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Coffee>>(json) ?? new List<Coffee>();
        }

        public void SaveCoffees()
        {
            string json = JsonConvert.SerializeObject(coffees, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }


        public double GetPrice(string coffeeName)
        {
            var coffee = coffees.FirstOrDefault(c => c.Name.Equals(coffeeName));
            if (coffee != null)
            {
                return  coffee.Price;
            }
            else
            {
                throw new KeyNotFoundException($"No coffee found with name: {coffeeName}");
            }
        }


    }
}
