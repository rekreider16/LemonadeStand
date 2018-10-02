using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    interface IStand
    {
        string Name { get; set; }
        double PricePerItem { get; set; }
        double CostPerItem { get; set; }
        double TotalItemsSold { get; set; }

        double TotalRevenue();
        double TotalExpenses();
        double TotalProfit();
    }
}
