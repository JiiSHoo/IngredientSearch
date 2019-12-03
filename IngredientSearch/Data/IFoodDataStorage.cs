using System.Collections.Generic;

namespace IngredientSearch.Data
{
    public interface IFoodDataStorage
    {
        List<Food> GetFoodItems();
        void AddFoodItem(Food food);
    }
}   