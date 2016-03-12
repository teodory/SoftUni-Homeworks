using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDefiningClasses.Problem2
{
    class Laprop
    {
        //model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.

        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private string battery;
        private double batteryLife;
        private double price;


        public Laprop(string model, string manufacturer, string processor, int ram,
            string graphicsCard, string hdd, string screen,
            string battery, double batteryLife, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.Battery = battery;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
            this.Price = price;
        }

        public Laprop(String model, double price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laprop(String model, String procesor, int ram, string graphicsCard, double price)
        {
            this.Model = model;
            this.Processor = procesor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Price = price;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Model value is null or empty");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Manufacturer value is null or empty");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Processor value is null or empty");
                }
                this.processor = value;
            }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The RAM value can't be negative");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Graphics Card value is null or empty");
                }
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The HDD value is null or empty");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Screen value is null or empty");
                }
                this.screen = value;
            }
        }

        public string Battery
        {
            get { return this.battery; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Battery value is null or empty");
                }
                this.battery = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The Battery Life value is null or empty");
                }
                this.batteryLife = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The Price Life value is null or empty");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {

            StringBuilder returnString = new StringBuilder();

            if (this.Model != null)
            {
                returnString.Append( "model " + this.Model + "\n");
            }
            if (this.Manufacturer != null)
            {
                returnString.Append("manufacturer " + this.Manufacturer + "\n");
            }
            if (this.Processor != null)
            {
                returnString.Append("processor " + this.Processor + "\n");
            }
            if (this.Ram > 0)
            {
                returnString.Append("RAM " + this.Ram + " GB\n");
            }
            if (this.GraphicsCard != null)
            {
                returnString.Append("graphics card " + this.GraphicsCard + "\n");
            }
            if (this.Hdd != null)
            {
                returnString.Append("HDD " + this.Hdd + "\n");
            }
            if (this.Screen != null)
            {
                returnString.Append("screen " + this.Screen + "\n");
            }
            if (this.Battery != null)
            {
                returnString.Append("battery " + this.Battery + "\n");
            }
            if (BatteryLife > 0)
            {
                returnString.Append("battery life " + this.batteryLife + " hours\n");
            }
            if (this.Price > 0)
            {
                returnString.Append("price " + this.Price + " lv.\n");
            }

            return returnString.ToString(0, returnString.Length - 1);
        }
    }
}
