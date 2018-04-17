using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesFinal.Data.Interface
{
   public interface IRepository<T> where T:class
    {
    IEnumerable<T> GetAll();
    IEnumerable<T> Find(Func<T, bool> Predicate);

    T GetById(int Id);

    void Create(T Entity);

    void Update(T Entity);

    void Delete(T Enity);
    int Count(Func<T, bool> Predicate);

    }
}
