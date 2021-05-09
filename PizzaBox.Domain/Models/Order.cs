using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Order : Entity
  {
    public List<Pizza> Pizzas { get; set; }
  }
}