using PizzaPlaceApp.BLL;

namespace PizzaPlaceApp.Models
{
    public class Estados
    {
        public MenuBLL Menu { get; } = new MenuBLL();
        public CestaCompras Cesta { get; } = new CestaCompras();
        public InterfazUsuarios Interfaz { get; set; } = new InterfazUsuarios();
        public decimal PrecioTotal => Cesta.Pedidos.Sum(Id => Menu.GetPizza(Id)!.Precio);
    }
}
