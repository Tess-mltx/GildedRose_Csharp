using System.Collections.Generic;
using GildedRoseKata;
using Microsoft.VisualBasic;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void Foo()
    {
        var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Name, Is.EqualTo("foo"));
    }

    // Quality never negative
    [Test]
    public void MinQualityIsZero() 
    {
        var items = new List<Item> { new Item { Name = "Mana potion", SellIn = 5, Quality = 2 } };
        var app = new GildedRose(items);

        for (int i = 0; i < 5; i++)
        {
            app.UpdateQuality();
        }

        Assert.That(items[0].Quality, Is.EqualTo(0));
    }

    // Maximum quality is 50
    [Test]
    public void MaxQualityIsFifty() 
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 } };
        var app = new GildedRose(items);

        for (int i = 0; i < 2; i++)
        {
            app.UpdateQuality();
        }

        Assert.That(items[0].Quality, Is.EqualTo(50));
    }
}
