using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTests
{
    internal class ConjuredItemTest
    {
        // Decrease twice as normal (-2)
        [Test]
        public void DecreaseTwice()
        {
            var items = new List<Item> { new Item { Name = "Conjured love potion", SellIn = 5, Quality = 10 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.That(items[0].Quality, Is.EqualTo(8));
        }

        // Decrease twice as normal after SellIn date (-4)
        [Test]
        public void DecreaseTwiceAfterSellIn()
        {
            var items = new List<Item> { new Item { Name = "Conjured love potion", SellIn = 0, Quality = 10 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.That(items[0].Quality, Is.EqualTo(6));
        }
    }
}
