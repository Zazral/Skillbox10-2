using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skillbox10_2
{
    internal class Account
    {
        protected string _lastName;
        protected string _firstName;
        protected string _patronymic;
        protected string _phoneNumber;
        protected string _passport;
        public string LastName { get { return _lastName; } }
        public string FirstName { get { return _firstName; } }
        public string Patronymic { get { return _patronymic; } }
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        public string Passport { get { return "******************"; } }
        public Account() { }
        protected Account(string lastName, string firstName, string patronymic, string phoneNumber,string passport)
        {
            
            _lastName = lastName;
            _firstName = firstName;
            _patronymic = patronymic;
            _phoneNumber = phoneNumber;
            _passport = passport;
        }
        public void Write(List<Account> list)
        {
            StreamWriter sw = new StreamWriter("Accounts.txt");
            foreach (Account el in list)
            {
                sw.WriteLine(el.ToString("#"));
            }
            sw.Close();
        }
        public List<Account> Read()
        {
            StreamReader sr = new StreamReader("Accounts.txt");
            List<Account> accs = new List<Account>();
            string[] acc = new string[4];
            while (!sr.EndOfStream)
            {
                acc = sr.ReadLine().Split('#');
                Account ac = new Account(acc[0], acc[1], acc[2], (acc[3]), acc[4]);
                accs.Add(ac);
            }
            sr.Close();
            return accs;
        }

        public string ToString(string sep)
        {
            return $"{this.LastName}{sep}{this.FirstName}{sep}{this.Patronymic}{sep}{this.PhoneNumber}{sep}{this._passport}";
        }
        public string ToString()
        {
            return $"{this.LastName} {this.FirstName} {this.Patronymic} {this.PhoneNumber} {this.Passport}";
        }
        public void Print()
        {
            List<Account> accs = Read();
            Console.Clear();
            for (int i = 0; i < accs.Count; i++)
            {
                Console.WriteLine(accs[i].ToString());
            }
        }
    }
}
