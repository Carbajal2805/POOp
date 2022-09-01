using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjVentaBoletas
{
    public partial class VentaBoletas : Form
    {
        public VentaBoletas()

        {
            Boleta objP  = new Boleta();

            InitializeComponent();
        }

        private void VentaBoletas_Load(object sender, EventArgs e)
        {
            txtNumeroBoleta.Text = "00000";
            lblPrecio.Text ="0.00";
            mostrarFecha();
        }
        private void mostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
