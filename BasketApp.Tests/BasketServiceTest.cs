using Xunit;
using System.Collections.Generic;

public class BasketServiceTests
{

    const double MAX_WEIGHT = 20;

    [Fact]
    public void Should_Add_Heaviest_Items_First()
    {
        var service = new BasketService();

        var items = new List<Item>
        {
            new Item { Name = "A", Weight = 10 },
            new Item { Name = "B", Weight = 5 },
            new Item { Name = "C", Weight = 8 }

        };

        var result = service.SelectItemsForBasket(items, MAX_WEIGHT);

        Assert.Collection(result,
            item => Assert.Equal("A", item.Name),
            item => Assert.Equal("C", item.Name)
        );
    }

    [Fact]
    public void Should_Return_Empty_List_When_MaxWeight_Is_Zero()
    {
        var service = new BasketService();

        var items = new List<Item>
        {
            new Item { Name = "A", Weight = 10 },
            new Item { Name = "B", Weight = 8 },
            new Item { Name = "C", Weight = 5 }
        };

        var result = service.SelectItemsForBasket(items, 0);

        Assert.Empty(result);
    }

    [Fact]
    public void Should_Skip_Items_When_Weight_Exceeds_MaxWeight()
    {
        var service = new BasketService();

        var items = new List<Item>
        {
            new Item { Name = "A", Weight = 31 },
            new Item { Name = "B", Weight = 13 },
            new Item { Name = "C", Weight = 4 }
        };

        var result = service.SelectItemsForBasket(items, MAX_WEIGHT);

        Assert.Collection(result,
            item => Assert.Equal("B", item.Name),
            item => Assert.Equal("C", item.Name)
        );
    }

    [Fact]
    public void Should_Return_Empty_List_When_Input_List_Is_Empty()
    {
        var service = new BasketService();

        var result = service.SelectItemsForBasket(new List<Item>(), MAX_WEIGHT);

        Assert.Empty(result);
    }
}