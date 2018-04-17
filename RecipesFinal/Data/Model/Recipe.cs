using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesFinal.Data.Model
{
    public class Recipe
    {

    public int RecipeId { get; set; }
    public string Name { get; set; }
  
    public string ImagePath { get; set; }
    public string Description { get; set; }

    public IEnumerable<Ingredient> Ingredients { get; set; }
    
  }
}
