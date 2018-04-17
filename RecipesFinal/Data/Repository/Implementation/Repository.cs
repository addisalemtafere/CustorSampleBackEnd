using Microsoft.EntityFrameworkCore;
using RecipesFinal.Data.Context;
using RecipesFinal.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesFinal.Data.Repository
{
  public class Repository<T> : IRepository<T> where T : class
  {

    protected readonly RecipeDatacontext _context;
    public Repository(RecipeDatacontext context)
    {
      this._context = context;

    }
    public int Count(Func<T, bool> Predicate)
    {
      throw new NotImplementedException();
    }
    protected void save() => _context.SaveChanges();

    public void Create(T Entity)
    {
      this._context.Add(Entity);
    }

    public void Delete(T Enity)
    {
      this._context.Remove(Enity);
    }

    public IEnumerable<T> Find(Func<T, bool> Predicate)
    {
     return this._context.Set<T>().Where(Predicate);
    }

    public IEnumerable<T> GetAll()
    {
      return this._context.Set<T>();
    }

    public T GetById(int Id)
    {
      return this._context.Set<T>().Find(Id);
    }

    public void Update(T Entity)
    {
      this._context.Entry(Entity).State = EntityState.Modified;
    }
  }
}
