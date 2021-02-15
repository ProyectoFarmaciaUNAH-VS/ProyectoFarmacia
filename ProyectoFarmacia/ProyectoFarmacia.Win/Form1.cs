using ProyectoFarmacia.BL;
using System.Windows.Forms;

namespace ProyectoFarmacia.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();
            listadeProductosBindingSource.DataSource = listadeProductos;

        }
    
    }
}
