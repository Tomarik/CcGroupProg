using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TestReadLine
{
    class Product
    {
        public string name;
        public decimal price;
        private int itemNumber;
        public ArrayList addins;
        

        public Product(string name, decimal price, ArrayList addins, int itemNumber)
        {
            this.name = name;
            this.price = price;
            this.addins = addins;
            this.itemNumber = itemNumber;
        }

        public decimal Price
        {
            get;
            set;
        }

        public ArrayList Addins
        {

            get;
        }

        public override string ToString()
        {
            string addinsList = "";
            foreach (string item in this.addins)
            {
                addinsList += item;
                addinsList += " ";
            }
            string drinkDetails = "Option #" + this.itemNumber + " " + this.name + " Price: $" + this.price + " Optional Addins: " + addinsList;

            return drinkDetails;
        }
    }
}
