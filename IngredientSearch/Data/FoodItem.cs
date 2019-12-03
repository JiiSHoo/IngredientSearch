using System;
using System.ComponentModel.DataAnnotations;

namespace IngredientSearch.Data
{
    public class Food
    {
        [Key]
        public int FOODID { get; set; }
        public String FOODNAME { get; set; }
    }
}