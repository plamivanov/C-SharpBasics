using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfBokoTikvanov
{
    public class DepositAcccount:Account
    {

        public DepositAcccount(Customers customer,decimal balance,decimal interestRate)
            :base(customer,balance,interestRate)
        {
            
        }
        
        public override void AddMonths(int months)
        {
 	        this.Months=months;
        }
        public int Months { get; set; }
       
        public override void AddDedductMoney(decimal addornot)
        {
            base.Balance += addornot;
        }

        public override decimal MoneyFromInterest()
        {
            return base.Balance * (base.InterestRate * this.Months);
        }

    }
}
