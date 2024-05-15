using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> _items;
    private Operations _operations;


    public GildedRose(IList<Item> items)
    {
        _items = items;
        _operations = new Operations();
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
        _operations.SellInUpdate(item);
        if (item.SellIn < 0)
        {
            _operations.QualityIncrease(item, 2);
        }
        else
        {
            _operations.QualityIncrease(item);
        }
    }

    private void ConjuredUpdate(Item item)
    {
        _operations.SellInUpdate(item);
        if (item.SellIn < 0)
        {
            _operations.QualityDecrease(item, 4);
        }
        else
        {
            _operations.QualityDecrease(item, 2);
        }
    }

    private void BackstagePassesUpdate(Item item)
    {
        _operations.SellInUpdate(item);
        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
        else if (item.SellIn < 5)
        {
            _operations.QualityIncrease(item, 3);
        }
        else if (item.SellIn < 10)
        {
            _operations.QualityIncrease(item, 2);
        }
        else
        {
            _operations.QualityIncrease(item);
        }
    }

    private void OrdinaryUpdate(Item item)
    {
        _operations.SellInUpdate(item);
        if (item.SellIn < 0)
        {
            _operations.QualityDecrease(item, 2);
        }
        else
        {
            _operations.QualityDecrease(item);
        }
    }
}