using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Account
    {
        private string accName;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }

        private string acid;

        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }

        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account()
        {

        }

        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (amount < balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Not enough balance!");
            }
        }

        public void Transfer(int amount, Account receiver)
        {
            if (amount < balance)
            {
                this.balance -= amount;
                receiver.balance += amount;
            }
            else
            {
                Console.WriteLine("Not enough balance!");
            }
        }
    }
}
