using OrderingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Entities
{
    public class Cook : ICookService
    {
        public string Name { get; set; }
        public int DishesInProgress { get; set; } = 0;
        public int TotalCookingTime { get; set; } = 0;

        public Cook(string _name)
        {
            Name = _name;
        }

        public void TakeDish()
        {
            DishesInProgress++;
        }

        public int GetEstimatedCookingTime(Dish dish)
        {
            return TotalCookingTime += dish.EstimatedCookingTime;
        }
    }
}
