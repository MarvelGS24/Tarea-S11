using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoSmartCloud
{
    public partial class IngresarCliente : Form
    {
        public IngresarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkTipoNacional_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTipoExtranjero.Checked)
                chkTipoExtranjero.Checked = false;
        }

        private void chkTipoExtranjero_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTipoNacional.Checked)
                chkTipoNacional.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombreCliente.Text;
            cliente.IdentificacionTributaria = txtIdentificacion.Text;
            cliente.TipoServicio = cmbTipoServicio.SelectedIndex;

            if (chkTipoNacional.Checked)
                cliente.TipoCliente = 1;

            if (chkTipoExtranjero.Checked)
                cliente.TipoCliente = 2;

            MessageBox.Show($"El cliente {cliente.Nombre} fue ingresado correctamente.");
        }
    }
}
