using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;

namespace Skillbox10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы Консультант(1) или Менеджер(2)?");
            int vibor = Convert.ToInt32(Console.ReadLine());
            if (vibor == 1) 
            {
                Account account = new Account();
                account.Print();
                Console.WriteLine("\nесли хотите изменить телефон введите порядковый номер кого хотите поменять");
                bool pars = Int32.TryParse(Console.ReadLine(), out int x);
                if (pars)
                {
                    List<Account> list = new List<Account>();
                    list = account.Read();
                    x = x-1;
                    if (x > list.Count) { x = list.Count-1;}
                    Console.WriteLine("\nвведите номер телефона");
                    list[x].PhoneNumber = Console.ReadLine();
                    account.Write(list);
                    account.Print();
                }
            }
            else
            {
                Manager manager = new Manager();
                manager.Print();
                List<Account> list = new List<Account>();
                list = manager.Read();
                list.Add(manager.Add());
                manager.Write(list);
                manager.Print();
                
            }
            Console.ReadKey();
        }
    }
}
