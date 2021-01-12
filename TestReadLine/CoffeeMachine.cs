using System;
using System.Collections.Generic;
using System.Text;

namespace TestReadLine
{
    class CoffeeMachine
    {
        public List<Product> products = new List<Product>();
        public Product selectedProduct;
        public decimal change = 0.00M;

        public Product SelectedProduct
        {
            get;
        }

        
        //Working here. Need to create a method to receive my drink orders
        public string CreateOrder(int productSelection, decimal fundsReceived)
        {
            this.selectedProduct = products[productSelection - 1];
            this.change = fundsReceived - selectedProduct.price;
            return selectedProduct.ToString();

        }

        public string MakeDrink(int addonChoice = 0)
        {
            string tempVar = "";
            if (addonChoice == 0)
            {
                tempVar = "Dispensing your " + selectedProduct.name;
            }
            else
            {
                tempVar = "Dispensing your " + selectedProduct.name + " with " + selectedProduct.addins[addonChoice - 1];
            }
            return tempVar;
        }
        
        public string DispenseChange()
        {
            string foober = "Dispensing your change $" + change.ToString();
            return foober;
        }
        
        public string coinSlot(decimal customerPayment)
        {

            return "blad";
        }
        
    }
}
