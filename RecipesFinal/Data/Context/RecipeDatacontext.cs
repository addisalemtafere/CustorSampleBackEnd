using Microsoft.EntityFrameworkCore;
using RecipesFinal.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;
using RecipesFinal.Controllers;

namespace RecipesFinal.Data.Context
{
  public class RecipeDatacontext : DbContext
  {
    public RecipeDatacontext(DbContextOptions<RecipeDatacontext> options) : base(options)
    {
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //  optionsBuilder.ReplaceService<IMigrationCommandExecutor, myExecutor>();
    //}

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //  modelBuilder.Entity<Ingredient>().se
    //}

        public DbSet<Recipe> recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Customer> customers { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Zone> Zones { get; set; }
    public DbSet<Woreda> Woredas   { get; set; }
    public DbSet<Kebele> kebeles   { get; set; }
    public DbSet<Nationality> Nationality { get; set; }
    public DbSet<CustomerDetail> customerDetails { get; set; }
  }
}