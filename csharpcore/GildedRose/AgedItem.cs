using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    internal class AgedItem
    {
        public static void UpdateQuality(Item item)
        {
            Operations.SellInUpdate(item);
            if (item.SellIn < 0)
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
