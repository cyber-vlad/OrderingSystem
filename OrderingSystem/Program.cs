using OrderingSystem.Entities;

namespace OrderingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cook> cooks = new List<Cook>
            {
                new Cook("Uncle Bob"),
                new Cook("Steve"),
                new Cook("Aibek")
            };

            List<Dish> menu = new List<Dish>
            {
                new Dish("Omelette", "A fluffy egg dish filled with cheese, vegetables and meat", 10, 
                    new List<Ingredient>
                    {
                        new("egg", 3.0f),
                        new ("cheese", 25.5f),
                        new("vegetables", 40.4f),
                        new("meat", 33.3f)
                    }),
                new Dish("Waffles", "Crispy and golden waffles topped with butter and syrup make for a delicious breakfast", 15,
                    new List<Ingredient>
                    {
                        new("egg", 3.0f),
                        new ("flour", 4.3f),
                        new("milk", 10.1f),
                        new("syrup", 20.4f),
                    }),
                new Dish("Avocado Toast", "Toasted bread topped with mashed avocado", 5,
                    new List<Ingredient>
                    {
                        new("bread", 3.0f),
                        new ("avocado", 24.7f),
                        new("salt", 1.5f),
                        new("papper", 1.5f)
                    })

            };

            Cafe cafe = new Cafe(cooks, menu);

            cafe.ShowMenu();
            cafe.RegisterOrders();
        }
    }
}
