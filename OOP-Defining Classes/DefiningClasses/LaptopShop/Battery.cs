using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Battery
    {
        private string batteryType;
        private int cells;
        private int mah;

        public Battery(string batteryType,  int cells,int mah)
        {
            this.BatteryType = batteryType;
            this.Cells = cells;
            this.mah = mah;
        }

        public string BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                { 
                    throw new ArgumentException("not valid battery type"); 
                }
                this.batteryType=value;}
        }

        public int Cells
        {
            get { return this.cells; }
            set {
                    if (value > 10 && value < 1)
                    {
                        throw new ArgumentException("not existing count of cells"); 
                    }
                   this.cells = value; }
        }
        public int Mah
        {
            get { return this.mah; }
            set { 
                    if(value>10000||value<100)
                    {
                        throw new ArgumentException("not real mAh");
                    }
                  this.mah = value; }
        }
        
        public override string ToString()
        {
            string allComponents= this.BatteryType + " " + this.Cells + " cells " + this.Mah + " mAh";
            return allComponents;
        }
    }
}
