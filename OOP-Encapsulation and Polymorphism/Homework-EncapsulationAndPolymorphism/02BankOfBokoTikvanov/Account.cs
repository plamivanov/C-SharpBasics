using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfBokoTikvanov
{
    public abstract class Account:IAddDedductMoney
    {
        private Customers customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customers customer,decimal balance,decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public Customers Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }

        public abstract void AddMonths(int months);
        public abstract void AddDedductMoney(decimal addornot);
        public abstract decimal MoneyFromInterest();
    }
}
