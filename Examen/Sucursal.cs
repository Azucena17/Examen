using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Sucursal
    {
        public string nombre;
        public List<Pizza> listPizza = new List<Pizza>();

        public Sucursal(string nombre)
        {
            this.nombre = nombre;
        }

        public void agregarPizza(Pizza pizza)
        {
            listPizza.Add(pizza);
        }
    }
}
