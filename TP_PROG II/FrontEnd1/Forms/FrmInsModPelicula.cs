using BackEnd.Dominio;
using FrontEnd1.HTTP;
using Newtonsoft.Json;
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
    public partial class FrmInsModPelicula : Form
    {
        public FrmInsModPelicula()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                btnNuevo.Enabled = true;
                btnAgregar.Enabled = true;
                cboClasificacion.SelectedIndex = -1;
                txtTitulo.Text = string.Empty;
                cboGenero.SelectedIndex = -1;
                txtDuracion.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                lstbPeliculas.DataSource = null;

            }
            else
            {
                return;
            }
        }

        private void FrmInsModPelicula_Load(object sender, EventArgs e)
        {
            CargarGenerosAsync();
            CargarCategoriasAsync();
        }

        private async void CargarGenerosAsync()
        {
            string url = "https://localhost:7246/Obtener%20Generos";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Genero_Pelis>>(result);
            cboGenero.DataSource = lst;
            cboGenero.ValueMember = "Id";
            cboGenero.DisplayMember = "Genero";
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.SelectedIndex = -1;
        }

        private async void CargarCategoriasAsync()
        {
            string url = "https://localhost:7246/Obtener%20Clasificaciones";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Edades>>(result);
            cboClasificacion.DataSource = lst;
            cboClasificacion.ValueMember = "ID";
            cboClasificacion.DisplayMember = "Clasificacion";
            cboClasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClasificacion.SelectedIndex = -1;
        }
    }
}
