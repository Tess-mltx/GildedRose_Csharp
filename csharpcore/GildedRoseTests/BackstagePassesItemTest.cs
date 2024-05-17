using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTests
{
    internal class BackstagePassesItemTest
    {
        // Increase (sellIn > 10)
        [Test]
        public void Increase()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 10 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.That(items[0].Quality, Is.EqualTo(11));
        }

        // Increase twice (SellIn <= 10)
        [Test]
        public void IncreaseTwice()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.That(items[0].Quality, Is.EqualTo(12));
        }

        // Increase third (SellIne <= 5)
        [Test]
        public void IncreaseThird()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.That(items[0].Quality, Is.EqualTo(13));
        }

        // When Sold => Quality = 0
        [Test]
        public void SellInPassed()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.That(items[0].Quality, Is.EqualTo(0));
        }
    }
}
