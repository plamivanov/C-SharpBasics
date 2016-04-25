using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfBokoTikvanov     
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyCustomer company1 = new CompanyCustomer("EOOD FIRMASTA", 3456, "123565-UN");
            CompanyCustomer company2 = new CompanyCustomer("Mincho EOOD", 3458, "123534-UN");
            CompanyCustomer company3 = new CompanyCustomer("Strong company", 3450, "523565-UN");
            IndividualCustomer individual1 = new IndividualCustomer("Pesho", 1456, 24);
            IndividualCustomer individual2 = new IndividualCustomer("Gosho", 1457, 21);
            IndividualCustomer individual3 = new IndividualCustomer("Sasho", 1459, 25);
          
          
            DepositAcccount CCB = new DepositAcccount(individual2, 12000.00m, 0.005m);
            CCB.AddDedductMoney(300.00m);//add some money +300...if I want to withdraw... -300
            CCB.AddMonths(12);//add some months
            Console.WriteLine("{2} won by interest for {1} months : {0:0.00}lv., he had first {3:0.00}lv.",CCB.MoneyFromInterest(),CCB.Months,CCB.Customer.Name,CCB.Balance);

            LoanAccount naDskTapotite = new LoanAccount(company1, 100000.00m, 0.005m); 
            naDskTapotite.AddMonths(4);
            Console.WriteLine("{0} has to return {1:0.00}lv. {2} months later",naDskTapotite.Customer.Name,naDskTapotite.MoneyFromInterest(),naDskTapotite.Months);
            // 2 months 0% interest rate
            LoanAccount onazi = new LoanAccount(company2, 100000m, 0.005m);
            onazi.AddMonths(5);
            Console.WriteLine("{0} has to return {1:0.00}lv. {2} months later", onazi.Customer.Name, onazi.MoneyFromInterest(), onazi.Months);
            
            MortgageAccount SiBank = new MortgageAccount(individual1, 3000.00m, 0.01m);
            SiBank.AddMonths(15);
            SiBank.AddDedductMoney(-50.20m);
            Console.WriteLine("{0} got the loan for {1} and now {2} months later has to return {3}lv",SiBank.Customer.Name,SiBank.Balance,SiBank.Months,SiBank.Balance+SiBank.MoneyFromInterest());

            MortgageAccount HSBC = new MortgageAccount(company3, 280000.00m, 0.006m);
            HSBC.AddMonths(15);
            DepositAcccount Santander = new DepositAcccount(individual3, 25000.00m, 0.0085m);
            Santander.AddMonths(24);

            List<Account> list1 = new List<Account> { HSBC, Santander };
            foreach (var item in list1)
            {
                Console.Write("Balance "+item.Balance+ " int.rate"+ item.InterestRate+" "+item.MoneyFromInterest());
                Console.WriteLine();
            }
                    
            
        }
    }
}
