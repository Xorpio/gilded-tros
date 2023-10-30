namespace GildedTros.App.Test;

public class ItemTest
{
    [Fact(DisplayName = "Test `Duplicate code` after one day")]
    public void DuplicateCodeOneDay()
    {
        //arrange
        var Items = new Item[]
        {
            new() { Name = "Duplicate Code", SellIn = 3, Quality = 6 }
        };

        var app = new GildedTros(Items);

        //act
        app.UpdateQualityForItems();

        //assert
        app.Items[0].Quality.Should().Be(4);
    }

    [Fact(DisplayName = "Test `Long Methods` after one day")]
    public void LongMethodsAfterOneDay()
    {
        //arrange
        var Items = new Item[]
        {
            new() { Name = "Long Methods", SellIn = 3, Quality = 6 }
        };

        var app = new GildedTros(Items);

        //act
        app.UpdateQualityForItems();

        //assert
        app.Items[0].Quality.Should().Be(4);
    }

    [Fact(DisplayName = "Test `Duplicate code` after sellin date")]
    public void DuplicateCodeOneDayAfterSellinDate()
    {
        //arrange
        var Items = new Item[]
        {
            new() { Name = "Duplicate Code", SellIn = 0, Quality = 6 }
        };

        var app = new GildedTros(Items);

        //act
        app.UpdateQualityForItems();

        //assert
        app.Items[0].Quality.Should().Be(2);
    }

    [Fact(DisplayName = "Test `Ugly Variable Names` after one day")]
    public void UglyVariableNamesAfterOneDay()
    {
        //arrange
        var Items = new Item[]
        {
            new() { Name = "Ugly Variable Names", SellIn = 3, Quality = 6 }
        };

        var app = new GildedTros(Items);

        //act
        app.UpdateQualityForItems();

        //assert
        app.Items[0].Quality.Should().Be(4);
    }
}
