using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IngredientSearch.Data;

namespace IngredientSearch.Data
{
    public class SqlFoodDataStorage : IFoodDataStorage
    {
        private FoodItemContext _foodItemContext;
        public SqlFoodDataStorage() { }
        public SqlFoodDataStorage(FoodItemContext foodItemContext)
        {
            _foodItemContext = foodItemContext;
        }


        public List<Food> GetFoodItems()
        {
            var foodItems = new List<Food>();
            
            foodItems = _foodItemContext.Food.ToList();
            
            return foodItems;
        }
        public void AddFoodItem(Food food)
        {
            _foodItemContext.Add(food);
            _foodItemContext.SaveChanges();
        }
    }
}
