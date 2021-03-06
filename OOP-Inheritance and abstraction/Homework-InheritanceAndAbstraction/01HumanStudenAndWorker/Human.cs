﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HumanStudenAndWorker
{
   public abstract class Human
    {
       protected string firstName;
       protected string lastName;

       public Human(string firstName,string lastName)
       {
           this.FirstName = firstName;
           this.LastName = lastName;
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

       public override string ToString()
       {
           return this.FirstName + " " + this.LastName;
       }
    }
}
