using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.PC_Catalog
{
    class Computer
    {
        //processor, graphics card, motherboard, etc.A
        private string name;
        private double price;
        private List<Component> components = new List<Component>();


        //private Component processor;
        //private Component graphicsCard;
        //private Component motherboard;
        //private Component ram;
        //private Component hdd;

        public Computer(String name, double price, Component processor,
            Component graphicsCard, Component motherboard, Component ram, Component hdd)
        {
            this.Name = name;
            this.Price = price;
            components.Add(processor);
            components.Add(graphicsCard);
            components.Add(motherboard);
            components.Add(ram);
            components.Add(hdd);
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Error: The Computer Name value is null");
                }
                this.name = value;
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
                    throw new ArgumentException("Error: The Computer price cannot be negative");
                }
                this.price = value;
            }
        }

        private double TotalPrice()
        {
            double total = 0.0;
            foreach (Component component in components)
            {
                total += component.Price;
            }
            return total;
        }

        public void DisplayComputerInformation()
        {
                //Add a method in the Computer class that displays the name,
                //each of the components' name and price and the total computer price.
                //The total price is the sum of all components' price.
                //Print the prices in BGN currency format.
            Console.WriteLine("Computer name: " + this.Name);
            Console.WriteLine();
            foreach (Component component in components)
            {
                Console.WriteLine(component.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("Total price: " + TotalPrice() + " lv.");


        }

    }
}
