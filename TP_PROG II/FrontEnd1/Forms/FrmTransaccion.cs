using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd1.Forms
{
    public partial class Transaccion : Form
    {
        public Transaccion()
        {
            InitializeComponent();
        }

        private void FrmTransaccion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que volver al menu principal?", "Volver al menu principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de querer cancelar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtDni.Text = string.Empty;
                cboPelicula.SelectedIndex = -1;
                cboFunciones.SelectedIndex = -1;
                cboTipoEntrada.SelectedIndex = -1;
                cboFormaPago.SelectedIndex = -1;
                dataGridView.Rows.Clear();
                butaca1.Checked = false;
                butaca2.Checked = false;
                butaca3.Checked = false;
                butaca4.Checked = false;
                butaca5.Checked = false;
                butaca6.Checked = false;
                butaca7.Checked = false;
                butaca8.Checked = false;
                butaca9.Checked = false;
            }
            else
            {
                return;
            }
        }
    }
}
