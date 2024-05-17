namespace GildedRoseKata
{
    public class Operations
    {
        public static void SellInUpdate(Item item)
        {
            item.SellIn -= 1;
        }

        public static void QualityDecrease(Item item, int malus = 1)
        {
            if (item.Quality > 0)
            {
                item.Quality -= malus;
                if (item.Quality < 0)
                {
                    item.Quality = 0;
                }
            }
        }

        public static void QualityIncrease(Item item, int bonus = 1)
        {
            if (item.Quality < 50)
            {
                item.Quality += bonus;
                if (item.Quality > 50)
                {
                    item.Quality = 50;
                }
            }
        }
    }
}
