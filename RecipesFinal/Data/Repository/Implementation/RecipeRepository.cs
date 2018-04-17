using Microsoft.EntityFrameworkCore;
using RecipesFinal.Data.Context;
using RecipesFinal.Data.Interface;
using RecipesFinal.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesFinal.Data.Repository
{
  public class RecipeRepository : Repository<Recipe>, IRecipeRepository
  {
    public RecipeRepository(RecipeDatacontext context) : base(context)
    {
    }

    public IEnumerable<Recipe> GetAllWithIngredients()
    {
      return _context.recipes.Include(i => i.Ingredients);
    }
  }
}
