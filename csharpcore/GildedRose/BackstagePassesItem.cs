using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    internal class BackstagePassesItem
    {
        public static void UpdateQuality(Item item)
        {
            Operations.SellInUpdate(item);
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn < 5)
            {
                Operations.QualityIncrease(item, 3);
            }
            else if (item.SellIn < 10)
            {
                Operations.QualityIncrease(item, 2);
            }
            else
            {
                Operations.QualityIncrease(item);
            }
        }
    }
}
