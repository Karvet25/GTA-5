// Базовый класс
public abstract class FoodItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Calories { get; set; }

    protected FoodItem(string name, decimal price, int calories)
    {
        Name = name;
        Price = price;
        Calories = calories;
    }

    public override string ToString()
    {
        return $"{Name} - {Price}р., {Calories} ккал";
    }
}

// Производные классы
public class MainDish : FoodItem
{
    public MainDish(string name, decimal price, int calories) : base(name, price, calories) { }
}

public class Dessert : FoodItem
{
    public Dessert(string name, decimal price, int calories) : base(name, price, calories) { }
}

public class Beverage : FoodItem
{
    public string Type { get; set; }

    public Beverage(string name, decimal price, int calories, string type) : base(name, price, calories)
    {
        Type = type;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Тип: {Type}";
    }
}

// Пример использования
class Program
{
    static void Main()
    {
        var dish1 = new MainDish("Борщ", 120.50m, 350);
        var dish2 = new MainDish("Пельмени", 150.00m, 500);
        var dish3 = new MainDish("Цезарь с курицей", 180.00m, 400);
        var dessert1 = new Dessert("Тирамису", 200.00m, 450);
        var dessert2 = new Dessert("Чизкейк", 170.00m, 370);
        var dessert3 = new Dessert("Мороженое", 100.00m, 200);
        var drink1 = new Beverage("Кофе", 100.00m, 100, "Горячий");
        var drink2 = new Beverage("Чай", 80.00m, 0, "Горячий");
        var drink3 = new Beverage("Сок", 90.00m, 120, "Холодный");
        var drink4 = new Beverage("Минеральная вода", 50.00m, 0, "Без газа");

        var menuItems = new List<FoodItem> { dish1, dish2, dish3, dessert1, dessert2, dessert3, drink1, drink2, drink3, drink4 };

        foreach (var item in menuItems)
        {
            Console.WriteLine(item);
        }
    }
}
