﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal:ISoundProducible
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cant be empty");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Name cant be empty");
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cant be empty");
                }
                this.gender = value;
            }
        }

        public override string ToString()
        {
            return this.Name + " " + this.Age + " " + this.Gender;
        }
        
        public abstract void ProduceSound();
    }
}
