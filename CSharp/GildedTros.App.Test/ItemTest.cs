namespace GildedTros.App.Test;

public class ItemTest
{
    [Fact(DisplayName = "Test `Duplicate code`")]
    public void DuplicateCode()
    {
        //arrange
        var Items = new Item[]
        {
            new() {Name = "Duplicate Code", SellIn = 3, Quality = 6}
        };

        var app = new GildedTros(Items);

        //act
        app.UpdateQuality();

        //assert
        app.Items[0].Quality.Should().Be(4);
    }
}
