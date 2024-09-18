using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_3
{
    public partial class FormSalida : Form
    {
        public FormSalida(string totalSalida, List<Articulos> listaSalida)
        {
            InitializeComponent();
            foreach (var item in listaSalida)
            {
                listBoxSalida.Items.Add("Código: " + item.Codigo + ", Producto: " + item.Nombre + ", Cantidad:  " + item.Cantidad + ". Total $" + item.Precio * item.Cantidad);
            }
            lblSalidaTotal.Text = totalSalida;
        }
    }
}
