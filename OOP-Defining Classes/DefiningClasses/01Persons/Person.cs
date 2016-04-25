using System;

class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name,int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public Person(string name,int age,string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }
    public string Name
    {
        get { return this.name; }
        set
        {
            if(value.Trim()==""||value.Length<2)
            {
                throw new ArgumentException("Insert your real name.");
            }
            this.name = value; }
        }
    public int Age
    {
         
        get { return this.age; }

        set
        {
            this.age = value;
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Insert your real age.");
            }
        }
    }
    public string Email
    {
        get { return this.email; }
        set 
        { this.email = value;
            if (!value.Contains("@"))
            {
                throw new ArgumentException("Not valid email");
            }
        }
    }

    public override string ToString()
    {
        return string.Format("Name:{0}\nAge:{1}\nEmail:{2}\n", this.Name, this.Age, this.Email);
    }
    
}

