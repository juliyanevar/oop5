using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    [Serializable]
    public class Owner
    {
        public string fullName { get; set; }
        public string date { get; set; }
        public string passport { get; set; }

        public Owner()
        {
        }

        public Owner(string fullName, string date, string passport)
        {
            this.fullName = fullName;
            this.date = date;
            this.passport = passport;
        }
    }

    [Serializable]
    public class BankAccount
    {
        public BankAccount()
        {
        }

        public BankAccount(int number, string type, int balance, string openingDate,string sms, string banking, Owner owner)
        {
            this.number = number;
            this.type = type;
            this.balance = balance;
            this.openingDate = openingDate;
            this.sms = sms;
            this.banking = banking;
            this.owner = owner;
        }

        public int number { get; set; }
        public string type { get; set; }
        public int balance { get; set; }
        public string openingDate { get; set; }
        public string sms { get; set; }
        public string banking { get; set; }
        public Owner owner = new Owner();


        public override string ToString()
        {
            return "Number: " + number + Environment.NewLine +
                "Type: " + type + Environment.NewLine +
                "Balance: " + balance + Environment.NewLine +
                "Opening date: " + openingDate + Environment.NewLine +
                "Owner name: " + owner.fullName + Environment.NewLine +
                "Owner bday: " + owner.date + Environment.NewLine +
                "Owner passport: " + owner.passport + Environment.NewLine +
                "SMS: " + sms + Environment.NewLine +
                "Internet banking: " + banking + Environment.NewLine+ Environment.NewLine;
        }
    }
}
