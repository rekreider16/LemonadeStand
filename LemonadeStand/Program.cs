using System;
using System.Linq;
using System.Collections.Generic;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            LemonadeStand stand = new LemonadeStand();

            Console.WriteLine("How much does a cup cost to make?");
            string costResponse = Console.ReadLine();
            stand.CostPerCup = double.Parse(costResponse);

            Console.WriteLine("For how much will a cup be sold for?");
            string priceResponse = Console.ReadLine();
            stand.PricePerCup = double.Parse(priceResponse);

            Console.WriteLine("How many cups have been sold this season?");
            string cupsSoldResponse = Console.ReadLine();
            stand.CupsSoldPerSeason = int.Parse(cupsSoldResponse);

            Console.WriteLine($"Your revenue is: {stand.TotalRevenue()}");
            Console.WriteLine($"Your expenses are: {stand.TotalExpenses()}");
            Console.WriteLine($"Your current profit is: {stand.TotalProfit()}");
            Console.ReadLine();


        }
    }
}
