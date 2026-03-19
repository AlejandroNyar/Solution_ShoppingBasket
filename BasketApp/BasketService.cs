using System.Linq;

public class BasketService
{
    public List<Item> SelectItemsForBasket(List<Item> items, double maxWeight)
    {
        //In a real scenario, we retrieve here items from database
        //For this assignment, the data is provided directly to this method in order to focus on the selection logic.
        var sortedItems = items
            .OrderByDescending(i => i.Weight)
            .ToList();

        var result = new List<Item>();
        double currentWeight = 0;

        foreach (var item in sortedItems)
        {
            if (currentWeight + item.Weight <= maxWeight)
            {
                result.Add(item);
                currentWeight += item.Weight;
            }
        }

        return result;
    }
}