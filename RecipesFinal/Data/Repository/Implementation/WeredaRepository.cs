using RecipesFinal.Data.Context;
using RecipesFinal.Data.Model;
using RecipesFinal.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesFinal.Data.Repository.Implementation
{
    public class WeredaRepository:Repository<Woreda>, IWeredaReposistory
  {
    public WeredaRepository(RecipeDatacontext context):base(context)
    {

    }
    }
}
