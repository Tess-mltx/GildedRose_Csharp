using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTests
{
    internal class LegendaryItemTest
    {
        // Legendary item neve sold or decrease
        [Test]
        public void LegendaryItemImmutable()
        {
            var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.That(items[0].Quality, Is.EqualTo(80));
            Assert.That(items[0].SellIn, Is.EqualTo(5));
        }
    }
}
