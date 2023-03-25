using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            acc.ID = 1;
            acc.Deposit(15);
            acc.Whitdraw(5);

            Console.WriteLine(acc.ToString());
        }
    }
}
