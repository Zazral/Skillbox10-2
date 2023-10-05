using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox10_2
{
    internal class Manager : Account
    {
        public Manager(string lastName, string firstName, string patronymic, string phoneNumber, string passport) : base(lastName, firstName, patronymic, phoneNumber, passport)
        {
            _lastName = lastName;
            _firstName = firstName;
            _patronymic = patronymic;
            _phoneNumber = phoneNumber;
            _passport = passport;
        }
        public Manager() { }
        public Account Add()
        {
            string[] addingAcc = new string[5];
            Console.WriteLine("\nпоочередно введите: фамилию, имя, отчество, номер телефона и паспортные данные разделяя кнопкой enter");
            for(int i = 0; i < 5; i++)
            {
                addingAcc[i] = Console.ReadLine();
            }
            Account newPerson = new Manager(addingAcc[0], addingAcc[1], addingAcc[2], addingAcc[3], addingAcc[4]);
            return newPerson;
        }
    }
}
