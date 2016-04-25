using System;
using System.Collections.Generic;
using System.Linq;
using CompanyHierarchy.Einumerable;
using CompanyHierarchy.Interfaces;
using System.Threading.Tasks;          //Няма хич защита за въведени данни :)Може много по-добре...ако знаеш какъв ще е следващия курс пиши..
                                       //кога почва...ква е тaя програма...някой знае ли кво става...следващия курс е февруари май..

namespace CompanyHierarchy
{
    class AProgramMain
    {
        static void Main(string[] args)
        {
           Employee pencho=new Employee("343HH-ID","Pencho","Penchev",704.56m,Departments.Sales);
           Employee pencho1=new Employee("3s3HH-ID","Hristo","Penchev",604.50m,Departments.Production);
           Employee pencho2=new Employee("3t3HH-ID","Yanko","Mankov",634.56m,Departments.Production);
           Employee pencho3=new Employee("34hHH-ID","Djanko","Penkov",234.56m,Departments.Sales);

           Employee gencho = new Employee("Y43HH-ID", "Encho", "Penchev", 204.56m, Departments.Sales);
           Employee gencho1 = new Employee("Bs3HH-ID", "Hristo", "Nechev", 634.50m, Departments.Accounting);
           Employee gencho2 = new Employee("At3HH-ID", "Anko", "Penkov", 934.56m, Departments.Production);
           Employee gencho3 = new Employee("Z4hHH-ID", "Djanko", "Bonkov", 334.56m, Departments.Sales);
            
            List<Employee>employeesFood=new List<Employee>{pencho,pencho1,pencho2,pencho3};
            List<Employee> employeesDrink = new List<Employee> { gencho, gencho1, gencho2, gencho3 };

            Manager golqm = new Manager("545ABC-ID", "Hristo", "Peshev", 5000m, Departments.Production, employeesFood);
            Manager velik = new Manager("B45ABC-ID", "Stoyanka", "Mutafova", 3000m, Departments.Marketing, employeesDrink);


            //Console.WriteLine(pencho);
            //Console.WriteLine(food);

            Sales sale1 = new Sales("Kurabijki", DateTime.Today, 3.45m);
            Sales sale2 = new Sales("Bijki", DateTime.Now, 5.55m);
            Sales sale3 = new Sales("Brabijki",new DateTime(2008,11,8), 4.55m);
            Sales sale4 = new Sales("Tjki", DateTime.Now, 6.40m);

            Sales bsale1 = new Sales("Shokolad", DateTime.Now, 6.45m);
            Sales bsale2 = new Sales("Drugo", DateTime.Now, 3.55m);
            Sales bsale3 = new Sales("Neshto", DateTime.Now, 2.55m);
            Sales bsale4 = new Sales("BiskviDi", DateTime.Now, 10.40m);

            List<Sales>packOfSales=new List<Sales>{sale1,sale2,sale3,sale4};
            List<Sales> packOfSales1 = new List<Sales> { bsale1, bsale2, bsale3, bsale4 };

            SalesEmployee penko = new SalesEmployee("545ABC-ID", "Georgi", "Blagoev", 3000m, Departments.Sales, packOfSales);
            SalesEmployee lenko = new SalesEmployee("E45ABC-ID", "Bonko", "Chonchev", 2000m, Departments.Sales, packOfSales1);
            //Console.WriteLine(penko);

            Projects project1=new Projects("Analysis of BigBig Big",DateTime.Today,"Online",State.Closed);
            Projects project2=new Projects("Analysis of BigSmalll",DateTime.UtcNow,"NotOnline",State.Open);
            Projects project3=new Projects("Analysis of SmallBig",new DateTime(2015,09,11),"VinmagiOnline",State.Open);
            Projects project4=new Projects("Analysis of BigCar",DateTime.Now,"OnlineLie",State.Closed);
            Projects project5 = new Projects("Analysis of Moon", DateTime.Now, "OnlineDabe", State.Open);

            Projects project10=new Projects("BigBig Big",new DateTime(2015,05,08),"EhaaaOnline",State.Closed);
            Projects project20=new Projects("BigSmalll",DateTime.Now,"Areveline",State.Open);
            Projects project30=new Projects("SmallBig",DateTime.Now,"NeeeVinmagiOnline",State.Closed);
            Projects project40=new Projects("BigCar",DateTime.Now,"DaaaOnlineLie",State.Closed);
            Projects project50 = new Projects("Moon", DateTime.Now, "OnlineDabe", State.Open);

            project20.CloseProject();  
            project50.CloseProject();

            List<Projects> sborProjects = new List<Projects> { project1, project20, project3, project4, project5 };
            List<Projects> sborProjects1 = new List<Projects> { project10, project20, project30, project40, project50 };
            Developer nqkoi = new Developer("343HH-ID", "Gencho", "Nqkoev", 400.56m, Departments.Production, sborProjects);
            Developer nqkoi2 = new Developer("233HHJB-Id", "Conko", "Yonov", 2300m, Departments.Marketing, sborProjects1);

            

            List<Employee> merge = new List<Employee> { golqm,velik, penko,lenko, nqkoi, nqkoi2 };
            foreach (var item in merge)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
