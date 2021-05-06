using PizzaBox.Storage.Repositories;

namespace PizzaBox.Storage
{
  public class UnitOfWork
  {
    public CrustRepository Crusts { get; }
    public SizeRepository Sizes { get; }
    public ToppingRepository Toppings { get; }

    public UnitOfWork()
    {

    }
  }
}