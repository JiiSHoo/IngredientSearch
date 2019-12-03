using System;
using System.Collections.Generic;
using System.Text;
using IngredientSearch.Data;

namespace IncredientSearch_TESTS
{
    public class DbContextMock : IngredientSearch.Data.IFoodDataStorage
    {
        public List<Food> GetFoodItems()
        {
            return new List<Food>
            {
                new Food(){FOODID = 1, FOODNAME="FoodItem1" },
                new Food(){FOODID = 2, FOODNAME="FoodItem2" },
                new Food(){FOODID = 3, FOODNAME="FoodItem3" },
                new Food(){FOODID = 4, FOODNAME="FoodItem4" }
            };
        }
    }
}
