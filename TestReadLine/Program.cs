using System;
using System.Collections;

namespace TestReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine cm = new CoffeeMachine();
            decimal price;
            string line;
            string drinkName;
            int itemNumber;
            
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\coded\Desktop\test.txt");

            while ((line = file.ReadLine()) != null)
            {
                
                itemNumber = Int32.Parse(line);
                line = file.ReadLine();
                drinkName = line;
                line = file.ReadLine();
                price = Decimal.Parse(line);
                line = file.ReadLine();
                string[] addins = line.Split(',');
                ArrayList addinList = new ArrayList();
                addinList.AddRange(addins);
                Product drink = new Product(drinkName, price, addinList, itemNumber);
                cm.products.Add(drink);

            }

            file.Close();


            while (true)
            {
                foreach (Product drink in cm.products)
            {
                System.Console.WriteLine(drink.ToString());
            }

           

                Console.WriteLine("Enter your selection: ");
                int userChoice = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please insert funds");
                decimal moneyPaid = Decimal.Parse(Console.ReadLine());

                cm.CreateOrder(userChoice, moneyPaid);

                if ((string)cm.selectedProduct.addins[0] != "none")
                {
                    Console.WriteLine("Would you like an addin? Y/N");
                    string addinYesOrNo = Console.ReadLine().ToLower();
                    if (addinYesOrNo.Equals("y"))
                    {
                        Console.WriteLine("Great! which one?");
                        int counter = 1;
                        foreach (string addin in cm.selectedProduct.addins)
                        {
                            Console.Write(counter + ": " + addin + " ");
                            counter++;

                        }

                        Console.WriteLine();
                        int tempNum = Int32.Parse(Console.ReadLine());
                        string tempAddin = (string)cm.selectedProduct.addins[tempNum - 1];

                        Console.WriteLine(cm.MakeDrink(tempNum));
                        Console.WriteLine(cm.DispenseChange());
                    }
                    else
                    {
                        Console.WriteLine(cm.MakeDrink());
                        Console.WriteLine(cm.DispenseChange());
                    }


                    
                }
                else
                {
                    Console.WriteLine(cm.MakeDrink());
                    Console.WriteLine(cm.DispenseChange());
                }


            }

        }
    }
}
