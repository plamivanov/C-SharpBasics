using System;

namespace _01HumanStudenAndWorker
{
    public class Worker:Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName,string lastName,decimal weekSalary,decimal workHoursPerDay):base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary { get; set; }
        public decimal WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay;
        }
        public override string ToString()
        {
            return base.ToString()+String.Format(" | Hour Payment: {0:0.00} BGN",MoneyPerHour());
        }
    }
}
