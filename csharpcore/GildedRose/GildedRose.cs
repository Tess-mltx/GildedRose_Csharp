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
                LegendaryItem.UpdateQuality(item);
            }

            else if (name.Contains("aged"))
            {
                AgedItem.UpdateQuality(item);
            }

            else if (name.Contains("conjured"))
            {
                ConjuredItem.UpdateQuality(item);
            } 
            
            else if (name.Contains("backstage passes"))
            {
                BackstagePassesItem.UpdateQuality(item);
            }

            else
            {
                OrdinaryItem.UpdateQuality(item);
            }
        }
    }
}