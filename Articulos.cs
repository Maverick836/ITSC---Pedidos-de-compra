using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_3
{
    public class Articulos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public Articulos(int cod, string nombre, int precio)
            //en el constructor no inclui Cantidad a drede, ya que solo lo utilizaria en caso de cargar los productos al pedido
        {
            Codigo = cod;
            Nombre = nombre;
            Precio = precio;
        }
    }
}

