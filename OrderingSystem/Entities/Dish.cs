using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Entities
{
    public class Dish
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int EstimatedCookingTime { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Dish(string _name, string _description, int _estimatedCookingTime, List<Ingredient> _ingredients)
        {
            Name = _name;
            Description = _description;
            EstimatedCookingTime = _estimatedCookingTime;
            Ingredients = _ingredients;
            Price = _ingredients.Sum(x => x.Price) * 1.2f;
        }
    }
}
