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


    // After sellin date decrease quality twice
    [Test]
    public void SellInPassedQuality()
    {
        var items = new List<Item> { new Item { Name = "Mana potion", SellIn = 0, Quality = 40 } };
        var app = new GildedRose(items);

        // simuler 5 jours
        for (int i = 0; i < 5; i++)
        {
            app.UpdateQuality();
        }

        Assert.That(items[0].Quality, Is.EqualTo(30));
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
        var items = new List<Item> { new Item { Name = "Aged brie", SellIn = 2, Quality = 50 } };
        var app = new GildedRose(items);

        for (int i = 0; i < 2; i++)
        {
            app.UpdateQuality();
        }

        Assert.That(items[0].Quality, Is.EqualTo(50));
    }

    // Aged brie Increase quality 
    [Test]
    public void AgedItemIncreaseQuality() 
    {
        var items = new List<Item> { new Item { Name = "Aged brie", SellIn = 5, Quality = 10 } };
        var app = new GildedRose(items);

        for (int i = 0; i < 2; i++)
        {
            app.UpdateQuality();
        }

        Assert.That(items[0].Quality, Is.EqualTo(12));
    }

    // Legendary item neve sold or decrease
    [Test]
    public void LegendaryItemImmutable()
    {
        var items = new List<Item> { new Item { Name = "Sulfuras", SellIn = 5, Quality = 80 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(80));
        Assert.That(items[0].SellIn, Is.EqualTo(5));
    }

    // Backstages passes increase (sellIn > 10)
    [Test]
    public void BackstagePassesIncrease() 
    {
        var items = new List<Item> { new Item { Name = "Backstage passes", SellIn = 15, Quality = 10 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(11));
    }

    // Backstage passes increase twice (SellIn <= 10)
    [Test]
    public void BackstagePassesIncreaseTwice()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes", SellIn = 10, Quality = 10 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(12));
    }

    // Backstage passes increase third (SellIne <= 5)
    [Test]
    public void BackstagePassesIncreaseThird()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes", SellIn = 5, Quality = 10 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(13));
    }

    // Conjured item decrease twice as normal
    [Test]
    public void ConjuredItemQualityDecrease()
    {
        var items = new List<Item> { new Item { Name = "Conjured love potion", SellIn = 5, Quality = 10 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(8));
    }
}
