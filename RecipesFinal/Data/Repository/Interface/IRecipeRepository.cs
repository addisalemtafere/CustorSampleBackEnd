using RecipesFinal.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesFinal.Data.Interface
{
    public interface IRecipeRepository:IRepository<Recipe>
    {
    IEnumerable<Recipe> GetAllWithIngredients();
    }
}
