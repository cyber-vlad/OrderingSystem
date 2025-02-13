using OrderingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Entities
{
    public class Cafe : ICafeService
    {
        public List<Cook> Cooks { get; set; }
        public List<Dish> Menu { get; set; }

        public Cafe(List<Cook> _cooks, List<Dish> _menu)
        {
            Cooks = _cooks;
            Menu = _menu;
        }

        public void ShowMenu()
        {
            Console.WriteLine("________________________________________________ ~Menu~ ________________________________________________");

            foreach (var dish in Menu)
            {
                Console.WriteLine($"| Name: {dish.Name}");
                Console.WriteLine($"| Description: {dish.Description}");
                Console.Write($"| Ingredients: ");
                foreach(var i in dish.Ingredients)
                {
                    Console.Write($"{i.Name}, ");
                }
                Console.WriteLine($"\n| Price: {dish.Price:F2}");
                Console.WriteLine("________________________________________________________________________________________________________");

            }
        }

        public void RegisterOrders()
        {
            Console.WriteLine("\n~Register Orders~\n");
            Console.WriteLine("Enter anytime [q], to leave cafe");
            do
            {
                Console.Write("Write dish name: ");
                string dishName = Console.ReadLine();
                
                if (dishName == "q")
                {
                    Console.WriteLine("Thanks for your visiting. See you later!");
                    break;
                }

                Dish dish = Menu.FirstOrDefault(d => d.Name == dishName);
                if (dish is null)
                {
                    Console.WriteLine("Wrong name of dish");
                    continue;
                }

                int minDishes = Cooks.Any(c => c.DishesInProgress < 5)
                    ? Cooks.Where(c => c.DishesInProgress < 5).Min(c => c.DishesInProgress)
                    : 5;
                
                Cook readyCook = Cooks.FirstOrDefault(c => c.DishesInProgress == minDishes && c.DishesInProgress < 5);

                if(readyCook is null)
                {
                    Console.WriteLine("All cooks are busy. Wait...");
                    continue;
                }

                readyCook.TakeDish();
                int estimatedTime = readyCook.GetEstimatedCookingTime(dish);
                
                Console.WriteLine("Your order is registered!");
                Console.WriteLine($"Estimated time (minutes): {estimatedTime}");
            } while (true);
        }
    }
}
