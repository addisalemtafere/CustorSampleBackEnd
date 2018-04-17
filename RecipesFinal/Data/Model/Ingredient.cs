﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesFinal.Data.Model
{
    public class Ingredient
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Amount { get; set; }
    public Recipe    Recipe { get; set; }
  }
}
