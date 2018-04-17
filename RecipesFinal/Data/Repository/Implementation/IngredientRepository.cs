using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipesFinal.Data.Context;
using RecipesFinal.Data.Interface;
using RecipesFinal.Data.Model;

namespace RecipesFinal.Data.Repository
{
    public class IngredientRepository:Repository<Ingredient>, IngredientReposistory
  {
      public IngredientRepository(RecipeDatacontext context) : base(context)
      {
      }


    }
}
