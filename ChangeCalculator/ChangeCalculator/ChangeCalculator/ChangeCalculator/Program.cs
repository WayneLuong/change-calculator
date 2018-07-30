using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChangeCalculator
{
    class Program
    {
        static void Main()
        {
            //Declarations
            double cost = 0;
            double paid = 0;

            Console.WriteLine("\t===============Wayne's Change Calculator===============\n");
            //Reading Input

            //Type Validation check for input
            Console.Write("\t\tPlease Enter Cost of Item: ");
            try
            {
                cost = Double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                MessageBox.Show("Please Enter a Number!", "Error!");
                Console.Clear();
                Main();
            }

            //Type Validation check for input
            Console.Write("\t\tPlease Enter Amount Paid: ");
            try
            {
                paid = Double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                MessageBox.Show("Please Enter a Number!", "Error!");
                Console.Clear();
                Main();
            }

            Console.WriteLine("\n\t\t\tItem cost: £" + cost);
            Console.WriteLine("\t\t\tAmount paid: £" + paid + "\n");
            
            //Calling calculateChange.amountOfCoins methods
            //Checks if paid amount is more than cost
            if (cost <= paid) 
            {
                double change = Math.Round(paid - cost, 4);

               Console.WriteLine("\t\t\tChange Due: £" + change + "\n");

                var ukSterling = new ukSterling();
                ukSterling.amountOfCoins(change);

            } else 
            {
                MessageBox.Show("You entered less than the cost! Please Retry.","Warning!");
                Console.Clear();
                Main();
            }

           
            //Exit/Restart
            Console.Write("\n\t\tPress any Key to Restart or E to exit");
            ConsoleKeyInfo Keypress;
            Keypress = Console.ReadKey();
            if (Keypress.Key == ConsoleKey.E)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Main();
            }
            
        }
    }
}
