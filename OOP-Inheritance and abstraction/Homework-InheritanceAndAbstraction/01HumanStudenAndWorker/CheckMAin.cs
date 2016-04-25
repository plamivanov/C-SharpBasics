using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HumanStudenAndWorker
{
    class CheckMain
    {
        static void Main(string[] args)
        {
            Worker pesho = new Worker("Pesho", "Georgiev", 870.00m, 40m);
            Worker gosho = new Worker("Gosho", "Peshev", 800.00m, 40.5m);
            Worker resho = new Worker("Resho", "Cheshmedjiev", 500.00m, 40m);
            Worker plamen = new Worker("Plamen", "Tenchev", 800.00m, 30m);
            Worker pencho = new Worker("Pencho", "Vladigerov", 1000.00m, 50.5m);
            Worker ivan = new Worker("Ivan", "Agov", 400.00m, 41.5m);
            Worker ogi = new Worker("Ogi", "Peev", 830.00m, 42m);
            Worker bogi = new Worker("Bogi", "Georgiev", 860.00m, 45m);
            Worker roska = new Worker("Roskata", "Pastireva", 9000.00m, 40.5m);
            Worker boiko = new Worker("Boiko", "Tikvenov", 70000.00m, 60.5m);

            List<Worker> employees = new List<Worker> { pesho, gosho, resho, plamen, pencho, ivan, ogi, bogi, roska, boiko };
            var sortedByPaymentEmployees = employees.OrderByDescending(w => w.MoneyPerHour());
            foreach (var item in sortedByPaymentEmployees)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Student maria = new Student("Maria", "Gospodinova", 23465);
            Student milko = new Student("Milko", "Zelev", 13465);
            Student conko = new Student("Conko", "Bonkov", 23965);
            Student valeri = new Student("Valeri", "Simeonov", 22465);
            Student saho = new Student("Saho", "Yovkov", 23765);
            Student ivanV = new Student("Ivan", "Velev", 33465);
            Student yonka = new Student("Yonka", "Yonkova", 43465);
            Student monka = new Student("Monka", "Gospodinova", 23865);
            Student jonka = new Student("Jonka", "Monkova", 26465);
            Student genga = new Student("Genga", "Shekerova", 23455);

            List<Student> klasA3 = new List<Student> { maria, milko, conko, valeri, saho, ivanV, yonka, monka, jonka, genga };
            var sortedKlasA3 = klasA3.OrderBy(s =>s.FacultyNumber);
            foreach (var item in sortedKlasA3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<Human> choveci = new List<Human> { };
            foreach (var item in klasA3)
            {
                choveci.Add(item);
            }
            foreach (var item in employees)
            {
                choveci.Add(item);
            }
            var choveciOrderedByName = choveci.OrderBy(z => z.FirstName).ThenBy(e => e.LastName);
            foreach (var item in choveciOrderedByName)
            {
                Console.WriteLine("{0} {1}",item.FirstName,item.LastName);
            }
        }
    }
}
