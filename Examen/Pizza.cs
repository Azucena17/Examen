using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Pizza
    {
        public string nombre;
        public int precio;
        public string descripcion;

        public Pizza(string nombre, int precio, string descripcion)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
        }
    }
}
