using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovaSmetka
{
    internal class BankAccount
    {
        private int id;

        public int ID
        {
            get 
            { 
                return id; 
            }
            set 
            { 
                id = value; 
            }
        }

        private double balance;

        public double Balance
        {
            get 
            {
                return balance;
            }
            set 
            { 
                balance = value; 
            }
        }

    }
}
    



    

