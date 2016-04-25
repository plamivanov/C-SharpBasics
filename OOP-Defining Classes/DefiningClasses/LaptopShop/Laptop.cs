using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        //model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life 
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private double batteryLife;
        private decimal price;

        public Laptop()
        {

        }
        public Laptop(string model,decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, string hdd,string screen,Battery battery,double batteryLife, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd=hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
            this.price=price;
        }
        public string Model 
        { 
          get{return this.model;}
          set{
              if(value.Length<3||value.Length>20)
              {
                  throw new ArgumentException("the name of the model is too short or to long");
              }
              this.model=value;}
        }
        public string Manufacturer 
        { 
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public decimal Price 
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("your price cant be negative");
                }
                this.price = value; }
        }
        public string Processor 
        {
            get { return this.processor; }
            set { this.processor = value; }
        }
        public int Ram 
        {
            get { return this.ram; }
            set { this.ram = value; }
        }
        public string GraphicsCard 
        {
            get { return this.graphicsCard; }
            set { this.graphicsCard = value; }
        }
        public string Hdd 
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }

        public string Screen 
        {
            get { return this.screen; }
            set { this.screen = value; }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public double BatteryLife
        {
            get { return this.batteryLife; }
            set { this.batteryLife = value; }
        }

        public override string ToString()
        {
            string allData = "Model: " + this.Model + "\n";
            if (this.Manufacturer!=null)
                allData += "Manufacturer: " + this.Manufacturer + "\n";
            if (this.Processor!=null)
                allData += "Processor: " + this.Processor + "\n";
            if (this.Ram>0&&this.Ram<100)
                allData+="RAM: "+this.Ram+" GB \n";
            if (this.GraphicsCard != null)
                allData += "Graphics Card: " + this.GraphicsCard + "\n";
            if(this.Hdd!=null)
                allData+="HDD: "+this.Hdd+"\n";
            if (this.Screen!=null)
                allData+="Screen: "+this.Screen +"\n";
            if(this.Battery!=null)
                allData+="Battery: "+this.Battery +"\n";
            if(this.BatteryLife>1&&this.BatteryLife<100)
                allData+="Battery life: "+this.BatteryLife+" hours \n";
                allData+="Price: "+this.price+" lv \n";

            return allData;
        }

    }
}
