using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class Operations
    {
        public void SellInUpdate(Item item)
        {
            item.SellIn -= 1;
        }

        public void QualityDecrease(Item item, int malus = 1)
        {
            if (item.Quality > 0)
            {
                item.Quality -= malus;
                if (item.Quality < 0)
                {
                    item.Quality = 0;
                }
            }
        }

        public void QualityIncrease(Item item, int bonus = 1)
        {
            if (item.Quality < 50)
            {
                item.Quality += bonus;
                if (item.Quality > 50)
                {
                    item.Quality = 50;
                }
            }
        }
    }
}
