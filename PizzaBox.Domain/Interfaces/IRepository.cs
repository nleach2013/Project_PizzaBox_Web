using System.Collections.Generic;

namespace PizzaBox.Domain.Interfaces
{
  public interface IRepository<T> where T : class
  {
    IEnumerable<T> Select();
    bool Insert();
    T Update();
    bool Delete();
  }
}