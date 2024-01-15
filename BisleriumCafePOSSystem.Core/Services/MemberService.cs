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
    public class MemberService
    {
        public List<Member> members;
        private readonly string filePath = "members.json";

        public MemberService()
        {
            // Load existing members from file or initialize an empty list
            members = LoadMembers() ?? new List<Member>();
        }

        public void AddMember(Member newMember)
        {
            newMember.Id = members.Any() ? members.Max(m => m.Id) + 1 : 1;
            members.Add(newMember);
            SaveMembers();
        }

        
        public Member GetMemberByPhoneNumber(string phoneNumber)
        {
            return members.FirstOrDefault(m => m.PhoneNumber == phoneNumber);
        }

        public void SaveMembers()
        {
            string json = JsonConvert.SerializeObject(members, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public List<Member> LoadMembers()
        {
            if (!File.Exists(filePath))
            {
                return new List<Member>();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Member>>(json) ?? new List<Member>();
        }


       
    }
}
