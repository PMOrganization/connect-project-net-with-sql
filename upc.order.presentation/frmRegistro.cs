using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using upc.order.business;
using upc.order.entities;

namespace upc.order.presentation
{
    public partial class frmRegistro : Form
    {
        
        Cliente objcliente = new Cliente();
        ICliente objClienteBusiness = new ClienteB();

        void ReaderCliente()
        {
            dgListar.DataSource = objClienteBusiness.Reader();
        }

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objcliente.Dni = int.Parse(txtDNI.Text);
            objcliente.Nombre = txtNombre.Text;

            try
            {
                bool create = objClienteBusiness.Create(objcliente);
                MessageBox.Show("Cliente Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReaderCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en registro del cliente", ex.Message, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); ;
            }
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            ReaderCliente();
        }
    }
}
