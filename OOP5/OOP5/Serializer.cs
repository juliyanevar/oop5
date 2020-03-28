using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Serializer
    {
        DataContractJsonSerializer jsonformatter = new DataContractJsonSerializer(typeof(List<BankAccount>));

        public List<BankAccount> ReadFile()
        {
            List<BankAccount> BankAccounts;
            using (FileStream fs = new FileStream("BankAccount.json", FileMode.OpenOrCreate))
            {
                BankAccounts = (List<BankAccount>)jsonformatter.ReadObject(fs);
            }
            return BankAccounts;
        }

        public void WriteFile(BankAccount BankAccount)
        {
            var list = ReadFile();
            list.Add(BankAccount);
            using (FileStream fs = new FileStream("BankAccount.json", FileMode.Open))
            {
                jsonformatter.WriteObject(fs, list);
            }
        }
    }
}
