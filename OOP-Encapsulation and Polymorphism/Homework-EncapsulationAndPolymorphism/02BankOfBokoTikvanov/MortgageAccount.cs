using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfBokoTikvanov
{
    public class MortgageAccount:Account
    {
        public MortgageAccount(Customers customer,decimal balance,decimal interestRate)
            :base(customer,balance,interestRate)
        {

        }
        public override void AddDedductMoney(decimal addornot)
        {
            base.Balance += addornot;
        }
        public override void AddMonths(int months)
        {
                this.Months = months;
        }
        public int Months { get; set; }

        public override decimal MoneyFromInterest()
        {
            decimal b = 0;
            if (base.Customer is IndividualCustomer)
            {
                b = base.Balance * (base.InterestRate * (this.Months - 6));
            }
            if (base.Customer is CompanyCustomer)
            {
                b = base.Balance * ((base.InterestRate / 2) * 12);
                b += base.Balance * (base.InterestRate * (this.Months - 12));
            }
            return b;
        }
    }
}
