using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTests
{
    internal class OrdinaryItemTest
    {
        // After sellin date decrease quality twice
        [Test]
        public void QualityDecreaseTwice()
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
    }
}
