using BisleriumCafePOSSystem.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BisleriumCafePOSSystem.Core.Services
{
    public class UserManager
    {
        private readonly string filePath = "users.json";
        private List<User> users;

        public UserManager()
        {
            users = LoadUsers();
        }

        public void AddUser(User newUser)
        {
            // Increment the ID
            newUser.Id = users.Any() ? users.Max(u => u.Id) + 1 : 1;

            
            users.Add(newUser);

            
            SaveUsers();
        }

        private void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private List<User> LoadUsers()
        {
            if (!File.Exists(filePath))
            {
                return new List<User>();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
        }



        //Authenticate user
        public User ValidateLogin(Credentials credentials)
        {
            List<User> users = LoadUsers();
            return users.FirstOrDefault(u => u.Email == credentials.Email && u.Password == credentials.Password);
        }
    }
}
