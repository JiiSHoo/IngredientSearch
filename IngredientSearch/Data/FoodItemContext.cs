using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngredientSearch.Data
{
    public class FoodItemContext : DbContext
    {
        public FoodItemContext(DbContextOptions<FoodItemContext> options) : base(options){}
        public FoodItemContext() { }

        public DbSet<Food> Food { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }
    }
}
