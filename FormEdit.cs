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
    public partial class FormEdit : Form
    {
        public int NuevaCantidad { get; set; }
        public FormEdit(int cantidadActual, string productoSeleccionado)
            //recibiendo los parametros y uusandolos al iniciar el componente
        {
            InitializeComponent();
            numUDEdit.Value = cantidadActual;
            lblEdit.Text = productoSeleccionado;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnEditAceptar_Click(object sender, EventArgs e)
        {
            NuevaCantidad = (int)numUDEdit.Value;
            this.DialogResult = DialogResult.OK; 
            //Devuelve una confirmacion
            this.Close();
            //cierra el formulario
        }

        private void btnEditCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //devuelve una cancelacion
            this.Close();
        }
    }
}
