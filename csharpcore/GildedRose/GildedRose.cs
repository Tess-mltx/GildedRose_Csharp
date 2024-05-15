using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> _items;

    public GildedRose(IList<Item> items)
    {
        _items = items;
    }

    public void UpdateQuality()
    {
        foreach (var item in _items)
        {
            var name = item.Name.ToLower();

            if (name.Contains("sulfuras"))
            {
                LegendaryUpdate(item);
            }

            else if (name.Contains("aged"))
            {
                AgedUpdate(item);
            }

            else if (name.Contains("conjured"))
            {
                ConjuredUpdate(item);
            } 
            
            else if (name.Contains("backstage passes"))
            {
                BackstagePassesUpdate(item);
            }

            else
            {
                OrdinaryUpdate(item);
            }
        }
    }

    private void LegendaryUpdate(Item item)
    {
        item.SellIn = item.SellIn;
        item.Quality = item.Quality;
    }

    private void AgedUpdate(Item item)
    {
        SellInUpdate(item);
        if (item.SellIn < 0)
        {
            QualityIncrease(item, 2);
        }
        else
        {
            QualityIncrease(item);
        }
    }

    private void ConjuredUpdate(Item item)
    {
        SellInUpdate(item);
        if (item.SellIn < 0)
        {
            QualityDecrease(item, 4);
        }
        else
        {
            QualityDecrease(item, 2);
        }
    }

    private void BackstagePassesUpdate(Item item)
    {
        SellInUpdate(item);
        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
        else if (item.SellIn < 5)
        {
            QualityIncrease(item, 3);
        }
        else if (item.SellIn < 10)
        {
            QualityIncrease(item, 2);
        }
        else
        {
            QualityIncrease(item);
        }
    }

    private void OrdinaryUpdate(Item item)
    {
        SellInUpdate(item);
        if (item.SellIn < 0)
        {
            QualityDecrease(item, 2);
        }
        else
        {
            QualityDecrease(item);
        }
    }

    private void SellInUpdate(Item item)
    {
            item.SellIn -= 1;
    }

    private void QualityDecrease(Item item, int malus = 1)
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

    private void QualityIncrease(Item item, int bonus = 1)
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