using ASP.Net_1.Entities;
using System.Collections.Generic;

namespace ASP.Net_1.Models
{
    public class MealsViewModel
    {
        public List<Drink> Drinks {  get; set; }
        public List<HotMeal> HotMeals { get; set; }
        public List<FastFood> FastFoods {  get; set; }
    }
}
