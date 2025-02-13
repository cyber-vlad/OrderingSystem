using OrderingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Interfaces
{
    public interface ICookService
    {
        void TakeDish();
        int GetEstimatedCookingTime(Dish dish);
    }
}
