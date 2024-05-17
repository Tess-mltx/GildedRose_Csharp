using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTests
{
    internal class OperationsTest
    {
        // SellIn Operation
        [Test]
        public void SellInOperationTesting()
        {
            Item item = new Item { Name = "Mana potion", SellIn = 5, Quality = 40 };
            Operations.SellInUpdate(item);
            Assert.That(item.SellIn, Is.EqualTo(4));
        }

        // Quality Increase Operation
        [Test]
        public void QualityIncreaseOperationTesting()
        {
            Item item = new Item { Name = "Mana potion", SellIn = 5, Quality = 40 };
            Operations.QualityIncrease(item, 2);
            Assert.That(item.Quality, Is.EqualTo(42));
        }

        // Quality Decrease Operation
        [Test]
        public void QualityDecreaseOperationTesting()
        {
            Item item = new Item { Name = "Mana potion", SellIn = 5, Quality = 40 };
            Operations.QualityDecrease(item, 2);
            Assert.That(item.Quality, Is.EqualTo(38));
        }
    }
}
