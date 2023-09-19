using PizzaPlaceApp.Models;

namespace PizzaPlaceApp.BLL
{
    public class MenuBLL
    {
        public List<Pizzas> Pizzas { get; set; } = new List<Pizzas>();
        public void Add(Pizzas pizza) => Pizzas.Add(pizza);
        public Pizzas? GetPizza(int id) => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
    }
}
