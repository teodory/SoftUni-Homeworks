using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private double price;

        public Component(string name, string details, double price){
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }
        public Component(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        
        public string Name
        {
            get 
            { 
                return this.name; 
            }
            set 
            {
                //if (value == null)
                //{
                //    throw new ArgumentNullException("The Name value is null");
                //}
                this.name = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Error: The Details value is null");
                }
                this.details = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: The price can't be negative or null");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder component = new StringBuilder();
            component.Append("Name: " + this.Name + "\n");
            if (this.details != null)
            {
                component.Append("Details: " + this.Details + "\n");
            }
            component.Append("Price: " + this.Price);

            return component.ToString();
        }

    }
}
