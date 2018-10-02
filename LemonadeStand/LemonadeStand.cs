using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class LemonadeStand : IStand
    {
        public string Name { get; set; }
        public int CupsSoldPerSeason { get; set; }
        public double Chair { get; set; }
        public double Sign { get; set; }
        public double Table { get; set; }
        public double Blender { get; set; }

        public double PricePerCup { get; set; }
        public double CostPerCup { get; set; }
        public double PricePerItem { get; set; }
        public double CostPerItem { get; set; }
        public double TotalItemsSold { get; set; }

        public double TotalRevenue()
        {
            return CupsSoldPerSeason * PricePerCup;
        }

        public double TotalExpenses()
        {
            return (CupsSoldPerSeason * CostPerCup) + Chair + Sign + Table + Blender;
        }

        public double TotalProfit()
        {
            return TotalRevenue() - TotalExpenses();
        }
    }
}
