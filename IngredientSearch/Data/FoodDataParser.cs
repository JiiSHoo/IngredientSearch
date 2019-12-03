using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngredientSearch.Data
{
    public class FoodDataParser
    {
        private IFoodDataStorage _foodDataStorage;
        public FoodDataParser(IFoodDataStorage foodDataStorage)
        {
            _foodDataStorage = foodDataStorage;
        }

        //THe business layer for data 
        public List<Food> GetFoodItems()
        {
            return _foodDataStorage.GetFoodItems();
        }

        public List<Food> AddFoodItem(Food food)
        {
            return _foodDataStorage.AddFoodItem(food);
        }
    }
}
