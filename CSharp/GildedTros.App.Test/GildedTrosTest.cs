using FluentAssertions;

namespace GildedTros.App.Test
{
    public class GildedTrosTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Items[0].Name.Should().Be("foo");
        }
    }
}
