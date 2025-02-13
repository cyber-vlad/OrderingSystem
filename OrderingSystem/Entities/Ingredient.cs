using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Entities
{
    public class Ingredient
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public Ingredient(string _name, float _price)
        {
            Name = _name; 
            Price = _price;
        }
    }
}
