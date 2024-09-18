using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Evaluacion_3
{
    public partial class Form1 : Form
    {
        Articulos art1 = new Articulos(1, "Nike Force", 160000);
        Articulos art2 = new Articulos(2, "Nike Air Zoom", 190000);
        Articulos art3 = new Articulos(3, "Total 90", 210000);
        Articulos art4 = new Articulos(4, "Adidas Predator", 180000);
        Articulos art5 = new Articulos(5, "Vans Old Skool", 1700000);
        Articulos art6 = new Articulos(6, "Johon Foos", 150000);
       
        List<Articulos> listArticulos = new List<Articulos>();
        //Creo nuevas instancias de la clase ARticulos para luego agregarlas a una lista para simular una lista que obtiene
        //el contenido de una tabla de una base de datos
        List<Articulos> listPedidos = new List<Articulos>();
        //Esta es la lista de los articulos que se van cargando

        void Eliminar(Articulos valor) {
            listPedidos.Remove(valor);
        }
        void ActualizarListBox()
            //Opte por crear una funcion que refresque el contenido del listBox ya que tenia planeado agregar botones para eliminar y editar
            //Es algo poco practico ya que se elimina y rellena constantemente, pero es la solucion que le encontre de momento
        {
            listBoxPedido.Items.Clear();
            foreach (var item in listPedidos)
            {
                listBoxPedido.Items.Add(item.Nombre + ", Cantidad:  " + item.Cantidad + ". Total $" + item.Precio * item.Cantidad);
            }
        }
        void Editar(Articulos articuloAEditar, int nuevaCantidad)
        {
            articuloAEditar.Cantidad = nuevaCantidad;  //Cree otro form y le inicia una nueva instancia con los valores segun sea el caso
            //Ese otro form contiene "nuevaCantidad" con un get set para leer y escribir datos, como toda funcion editar.
            ActualizarListBox();  
        }
        
        public void BuscarProducto(Action <Articulos> operacion, Articulos valor)
        {
            //Esta fue la forma que le encontre para seleccionar un elemento en la lista, y como necesito de esta funcion
            //tanto para eliminar como para editar, la cree para que reciba otra funcion (callback) y se ejecute. 

            if (listBoxPedido.SelectedIndex != -1)
                //esto para asegurarme de que se esta seleccionando un elemento en la listBox por medio del punero
            {
                string nombreProducto = listBoxPedido.SelectedItem.ToString().Split(',')[0];
                //Como en la listbox se cargan elementos que yo concatene mapeando la lista listPedidos, el selectedItem me devuelve
                //el item seleccionado como objeto, asi que lo paso a string y con el metodo Split lo divido en un array que 
                //lo va a separar al detectar las comas ",". el array seria ["el nombre", ", todo lo demas"], por eso tomo la posicion 0.
                //Si pudiera acceder al elemente seleccionado como un objeto de la clase Articulos, simplemente tomaria el codigo.
                //Pero en el listBox tuve que pasarlo como cadenas de texto, lo cual me complico un poco las cosas. 


                var productoEncontrado = listPedidos.FirstOrDefault(item => item.Nombre == nombreProducto);

                if (productoEncontrado != null)
                {
                    //En caso de que encuentre el producto, entonces ejecuta la funcion que se pasa como callback
                    //el callback tambien recibe un parametro, que seria el producto encontrado
                    operacion(productoEncontrado);
                    ActualizarListBox();
                }
                else
                {
                    //Manejo de errores para saber en donde esta fallando, si es que falla en encontrar el elemento en la lista

                    MessageBox.Show("No se encontró ningún artículo con ese nombre.", "Error al eliminar");
                }
            }
            else
            {
                //o si es que directamente no se esta seleccionando ninguno
                MessageBox.Show("Por favor selecciona un producto para eliminar", "Error al eliminar producto");
            }
        }

        public Form1()
        {
            InitializeComponent();
            //Al iniciar el componente, dejo esto como predeterminado
            //Cargo la lista de articulos 
            listArticulos.Add(art1);
            listArticulos.Add(art2);
            listArticulos.Add(art3);
            listArticulos.Add(art4);
            listArticulos.Add(art5);
            listArticulos.Add(art6);
            //recorro la lista para agregar los nombres de cada elemento en el comboBox como opciones
            foreach (var item in listArticulos)
            {
                comboBoxArt.Items.Add(item.Nombre);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (numUDCantidad.Value != 0)
                //Para evitar que carguen ceros
            {
                var productoExistente = listArticulos.FirstOrDefault(a => a.Nombre == comboBoxArt.Text);
                //Busco el elemento en la lista de Articulos que coincida con el texto seleccionado en el comboBox

                if (productoExistente != null)
                {
                    var productoEnPedidos = listPedidos.FirstOrDefault(a => a.Nombre == productoExistente.Nombre);
                    //Esto es para ver si el producto seleccionado ya esta cargado o no en la lista de pedidos

                    if (productoEnPedidos != null)
                    {
                        // Si ya está en listPedidos, actualizar la cantidad
                        productoEnPedidos.Cantidad += (int)numUDCantidad.Value;
                    }
                    else
                    {
                        // Si no está en listPedidos, agregarlo
                        productoExistente.Cantidad = (int)numUDCantidad.Value;
                        listPedidos.Add(productoExistente);
                    }
                    ActualizarListBox();
                    //siempre primero manejo la lista y luego actualizo el listBox
                }
                else
                {
                    MessageBox.Show("El producto seleccionado no existe.", "Error al cargar producto");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una cantidad mayor a cero.", "Error al cargar producto");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxPedido.SelectedIndex != -1)
            {
                string nombreProducto = listBoxPedido.SelectedItem.ToString().Split(',')[0].Trim();
                //repito la sintaxtis anteriormente explicada

                DialogResult confirmacion = MessageBox.Show(
                    //encontre esta forma de hacer un modal de confirmacion
                    "¿Estás seguro de que deseas eliminar " + nombreProducto + " de la lista de pedidos?",
                    "Confirmar eliminación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                // si el usuario confirma la eliminación entonces se ejecuta la funcion de buscar producto, recibiendo la de eliminar
                if (confirmacion == DialogResult.OK)
                {
                    // Ejecutar la función de búsqueda y eliminar
                    BuscarProducto(Eliminar, null);
                    MessageBox.Show("Producto eliminado correctamente.");
                }
                else
                //sino, no pasa nada
                {
                    MessageBox.Show("Eliminación cancelada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto para eliminar", "Error al eliminar producto");
            }
        }


        private void listBoxPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listBoxPedido.SelectedIndex != -1)
            {
                string nombreProducto = listBoxPedido.SelectedItem.ToString().Split(',')[0].Trim();

                var articuloAEditar = listPedidos.FirstOrDefault(item => item.Nombre == nombreProducto);

                if (articuloAEditar != null)
                {
                    // Creo una nueva instancia del formulario de edicion pasandole como parametros la cantidad del articulo a editar y el nombre
                    FormEdit formEdit = new FormEdit(articuloAEditar.Cantidad, articuloAEditar.Nombre);

                    // Muestro el formulario de edicion como un dialogo modal para que si o si elija una opcion antes de cerrar la ventana
                    var resultado = formEdit.ShowDialog();

                    // Si el usuario hace clic en Aceptar, actualiza la cantidad
                    if (resultado == DialogResult.OK)
                    {
                        Editar(articuloAEditar, formEdit.NuevaCantidad);
                        MessageBox.Show("Cantidad actualizada correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningún artículo para editar.", "Error al editar");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto para editar", "Error al editar producto");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Esta vendria a ser la salida final, la intencion es que se genere un pdf por medio de una extencion o libreria
            //y asi enviar ese pdf al sector de contaduria y que aprueben la compra. 

            var total = "El total es de $" + listPedidos.Sum(p => p.Cantidad * p.Precio);

            FormSalida formSalida = new FormSalida(total, listPedidos);
            //lo mismo, creo una nueva instancia de otro formulario

            formSalida.Show();
            //solo que esta vez no es como un dialogo modal. 

            //La intencion de esto es que pueda ser escalable.
            //Tratandose de un local grande que maneja muchos articulos mensual o semanalmente, facilmente puede usarse con una base de datos
            //y generar pedidos grandes, incluso tener la posibilidad de guardar esa lista de pedidos que se genera, en una tabla aparte
            //para contabilizar los gastos y tener un seguimiento. 

            //Tiene mucha posibilidad de mejora, especialmente en el manejo del listBox y no estar ocupando tanta memoria reseteandolo constantemente
            //y tambien en poder hacer uso del codigo del producto para las busquedas
        }
    }
}
