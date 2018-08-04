using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upc.order.presentation
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void generarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FrmVenta = new Form1();            
            
            FrmVenta.MdiParent = this;
            
            FrmVenta.Show();
        }

        private void registroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro FrmCliente = new frmRegistro();

            FrmCliente.MdiParent = this;

            FrmCliente.Show();
        }
    }
}
