using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> _items;
    private Dictionary<string, Action<Item>> actionDictionary = new Dictionary<string, Action<Item>>()
    {
        ["Sulfuras, Hand of Ragnaros"] = LegendaryItem.UpdateQuality , 
        ["Aged Brie"] = AgedItem.UpdateQuality ,
        ["Conjured Mana Cake"] = ConjuredItem.UpdateQuality,
        ["Backstage passes to a TAFKAL80ETC concert"] = BackstagePassesItem.UpdateQuality 
    };

    public GildedRose(IList<Item> items)
    {
        _items = items;
    }

    public void UpdateQuality()
    {
        foreach (var item in _items)
        {
            var name = item.Name;

            if (actionDictionary.TryGetValue(name, out var updateMethod))
            {
                updateMethod(item);
            }
            else
            {
                OrdinaryItem.UpdateQuality(item);
            }
            
        }
    }

        
    
}