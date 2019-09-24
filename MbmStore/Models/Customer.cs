using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public List<string> PhoneNumbers { get; } = new List<string>();

        private DateTime birthDate;
        private int age;


        //Exercise 4
        public DateTime BirthDate {
            set
            {
              
                    if (0 > age && age < 120)
                    {
                        throw new Exception("Age not accepted");
                    }
                    else
                    {
                        birthDate = value;
                    }
                }
                get { return birthDate;
                }
            }


        public int Age {
            get
            {
                DateTime Now = DateTime.Now;
                int age;

                age = Now.Year - BirthDate.Year;

                if (Now.Month < BirthDate.Month || (Now.Month == BirthDate.Month && Now.Day < BirthDate.Day))
                {
                    age--;
                }
                return age; 
            }
            set { }
        }

 

        // constructors
        public Customer(string firstname, string lastname, string address, string zip, string city, DateTime birthDate)
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            Zip = zip;
            City = city;
            BirthDate = birthDate;
    
        }

        public void addPhone(string phoneNumber)
        {
            PhoneNumbers.Add(phoneNumber);
        }
    }
}