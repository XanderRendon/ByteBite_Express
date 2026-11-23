using System.Collections.Generic;
using System.Drawing;

public record MenuItemData(int Id, string Name, decimal Price, Image? Icon);

public static class MenuData
{
    // Category 1 = Main Dish, Category 2 = Drinks
    public static readonly Dictionary<int, Dictionary<int, MenuItemData>> Categories = new()
    {
        [1] = new Dictionary<int, MenuItemData>
        {
            [1] = new(1, "Burger", 120m, null),
            [2] = new(2, "Pasta", 150m, null),
            [3] = new(3, "Steak", 280m, null),
            [4] = new(4, "Fried Rice", 95m, null),
            [5] = new(5, "Sandwich", 110m, null),
        },
        [2] = new Dictionary<int, MenuItemData>
        {
            [1] = new(1, "Iced Latte", 85m, null),
            [2] = new(2, "Lemonade", 60m, null),
            [3] = new(3, "Matcha", 95m, null),
            [4] = new(4, "Cola", 45m, null),
            [5] = new(5, "Hot Tea", 50m, null),
        }
    };
    public static MenuItemData? GetItem(int categoryId, int itemId) {
        if (Categories.TryGetValue(categoryId, out var items) && items.TryGetValue(itemId, out var item)) {return item;}
        return null;
    }
}