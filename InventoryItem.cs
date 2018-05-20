using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4Milestone2
{
    class InventoryItem
    {
        // private data
        private string name;
        private decimal price;
        private double weightLbs;
        private DateTime dateAdded;

        // C# 3.0+ allows for this sweet getter/setter format
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        public double WeightLbs { get => weightLbs; set => weightLbs = value; }
        public DateTime DateAdded { get => dateAdded; set => dateAdded = value; }

        // default constructor
        public InventoryItem()
        {
            name = "Screwdriver";
            price = 3.99m;
            weightLbs = 1;
            dateAdded = System.DateTime.Now;
        }

        // nondefault constructor
        public InventoryItem(string name, decimal price, double weightLbs, DateTime dateAdded)
        {
            this.Name = name;
            this.Price = price;
            this.WeightLbs = weightLbs;
            this.DateAdded = dateAdded;
        }

        // unique methods
        public void print()
        {
            Console.Write(name + "\n" + price + "\n" + weightLbs + "\n" + dateAdded + "\n");
        }
    }
}
