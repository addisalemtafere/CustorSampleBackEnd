using RecipesFinal.Data.Context;
using RecipesFinal.Data.Model;
using RecipesFinal.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesFinal.Data.Repository.Implementation
{
    public class RegionRepository: Repository<Region>, IRegionRepository
  {
    public RegionRepository(RecipeDatacontext context) : base(context)
    {

    }
    }
}
