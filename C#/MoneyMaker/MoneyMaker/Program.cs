using System;

namespace MoneyMaker
{
    // The purpose of this program is calculate the mininum amount of coins for a value entered by a user
    // Gold Coin = 10 Cents
    // Silver Coin = 5 Cents
    // Bronze Coins = 1 Cent 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins:");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(amount + " cents is equal to...");

            double gold = 10;
            double silver = 5;

            double goldCoins = Math.Floor(amount / gold);
            double remainder = amount % gold;

            double silverCoins = Math.Floor(remainder / silver);

            //Round to the nearest whole cent
            remainder = Math.Round(remainder % silverCoins);

            Console.WriteLine("Gold Coins: " + goldCoins);
            Console.WriteLine("Silver Coins: " + silverCoins);
            Console.WriteLine("Bronze Coins: " + remainder);
        }
    }
}
