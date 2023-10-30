namespace GildedTros.App;

public class GildedTros
{
    public IList<Item> Items { get; }
    public GildedTros(IList<Item> Items)
    {
        this.Items = Items;
    }

    private void updateGoodWine(Item item)
    {
        item.SellIn = item.SellIn - 1;

        // quality increases every day. but never past 50
        item.Quality = item.Quality + 1;

        if (item.SellIn < 0)
        {
            item.Quality = item.Quality + 1;
        }

        // quality can never be more than 50
        if (item.Quality > 50)
        {
            item.Quality = 50;
        }
    }

    private void updateBackstagePasses(Item item)
    {
        // Backstage passes increase in Quality as its SellIn value approaches;
        item.Quality++;

        // Quality increases by 2 when there are 10 days or less
        if (item.SellIn < 11)
        {
            item.Quality++;
        }

        // Quality increases by 3 when there are 5 days or less
        if (item.SellIn < 6)
        {
            item.Quality++;
        }

        item.SellIn--;

        // quality can never be more than 50
        if (item.Quality > 50)
        {
            item.Quality = 50;
        }

        // after the sellin date, quality drops to 0
        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }

    private void updateBDAWGKeychain(Item item)
    {
        // legendary item, never has to be sold or decreases in Quality
    }

    private void updateDefaultItem(Item item)
    {
        item.SellIn--;

        // after the sellin date, quality degrades twice as fast
        if (item.SellIn < 0)
        {
            item.Quality--;
        }

        // quality degrades every day
        item.Quality--;

        // quality can never be negative
        if (item.Quality < 0)
        {
            item.Quality = 0;
        }
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            switch (item.Name)
            {
                case "Good Wine":
                    updateGoodWine(item);
                    break;
                case "Backstage passes for Re:factor":
                case "Backstage passes for HAXX":
                    updateBackstagePasses(item);
                    break;
                case "B-DAWG Keychain":
                    updateBDAWGKeychain(item);
                    break;
                case "Duplicate Code":
                    updateSmellyItem(item);
                    break;
                default:
                    updateDefaultItem(item);
                    break;
            }
        }
    }

    private void updateSmellyItem(Item item)
    {
        item.SellIn--;

        // quality degrades every day
        item.Quality = item.Quality - 2;

        // quality degrades twice as fast after the sellin date
        if (item.SellIn < 0)
        {
            item.Quality--;
        }

        // quality can never be negative
        if (item.Quality < 0)
        {
            item.Quality = 0;
        }
    }
}
