using IngredientSearch.Data;
using System;
using Xunit;

namespace IncredientSearch_TESTS
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var dbMock = new DbContextMock();

            var context = new IngredientSearch.Data.SqlFoodDataStorage(dbMock);
        }
    }
}
