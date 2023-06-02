using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anket
{
    internal class User
    {
        private string _phone;
        public string Phone
        {
            get => _phone;
            set
            {
                if (!Regex.IsMatch(value, "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$")) throw new Exception("Invalid Phone");
                else _phone = value;

            }
        }
        public DateTime Birthday { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public User(string name, string surname, string fatherName, string country, string city, string phone, DateTime birthday, string gender)
        {
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            Country = country;
            City = city;
            Phone = phone;
            Birthday = birthday;
            Gender = gender;
        }
    }
}
