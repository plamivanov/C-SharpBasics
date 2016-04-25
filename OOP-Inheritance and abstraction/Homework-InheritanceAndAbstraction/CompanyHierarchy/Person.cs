using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy
{
    public abstract class Person:IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        public Person(string id,string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.Id = id;
            this.LastName = lastName;
        }
        public string Id
        {
            get { return this.id; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cant be empty");
                }
                this.id = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cant be empty");
                }
                this.lastName = value;
            }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cant be empty");
                }
                this.firstName = value;
            }
        }

        public override string ToString()
        {
            return this.Id + " " + this.FirstName + " " + this.LastName;
        }
    }
}
