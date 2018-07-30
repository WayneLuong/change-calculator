using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeCalculator
{

    class ukSterling
    {
        //Declarations
        double[] coins = { 0.75, 0.15, 0.03, 0.01, 0.005, 0.0025 };

        //Methods
        public void amountOfCoins(double input)
        {
          int numOfCoins = 0;
          var index = 0;
          double remainder = 0;

          Console.WriteLine("\t\t  Your change in (uk sterling):\n");
          //Iterate through the coins array
          for (var i=0; i<coins.Length; i++)
           {
               remainder = input % coins[i];
                while (input > coins[i])
                {
                    input = input - coins[i];
                    numOfCoins++;
                    index = i;
                }
                
                //If rounded number equals last array value increment the numOfCoins
                if (Math.Round(remainder, 4) == 0.0025)
                {
                    numOfCoins++;
                } 
                
                //Checks if numOfCoins has a value before printing
                if (numOfCoins != 0)
                {
                    Console.WriteLine("\t\t\t" + numOfCoins + "   x   " + coins[i] + "p   =   " + numOfCoins * coins[i] + "p");
                }
                                
                //Resets the counter for next coin
                numOfCoins = 0;
            }

          //Prints any remainder that the smallest coin value couldn't fill
          remainder = input % coins[index];
          if (Math.Round(remainder, 5) != coins[index] && remainder != 0)
            {
             Console.WriteLine("\n\t\tNote: Remainder of " + Math.Round(remainder, 5) + "p!(Rounded Value)");
            }
        }
    }
}
