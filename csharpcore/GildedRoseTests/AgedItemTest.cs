using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTests
{
    internal class AgedItemTest
    {
        // Aged Increase quality 
        [Test]
        public void AgedItemIncreaseQuality()
        {
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 10 } };
            var app = new GildedRose(items);

            for (int i = 0; i < 2; i++)
            {
                app.UpdateQuality();
            }

            Assert.That(items[0].Quality, Is.EqualTo(12));
        }

        // Aged Increase quality twice After SellIn
        [Test]
        public void IncreaseTwice()
        {
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 10 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.That(items[0].Quality, Is.EqualTo(12));
        }
    }
}
