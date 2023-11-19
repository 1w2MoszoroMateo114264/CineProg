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
using static System.Net.WebRequestMethods;

namespace FrontEnd1.Forms
{
    public partial class FrmConsultarPelicula : Form
    {
        public FrmConsultarPelicula()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmConsultarPelicula_Load(object sender, EventArgs e)
        {
            CargarGenerosAsync();
            CargarCategoriasAsync();
        }

        private async void CargarCategoriasAsync()
        {
            string url = "https://localhost:7246/Obtener%20Clasificaciones";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Edades>>(result);
            cboEdad.DataSource = lst;
            cboEdad.ValueMember = "ID";
            cboEdad.DisplayMember = "Clasificacion";
            cboEdad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEdad.SelectedIndex = -1;
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string titulo, estado, genero, edad;

            titulo = txtTitulo.Text != null ? Uri.EscapeDataString(txtTitulo.Text) : string.Empty;
            //genero = Uri.EscapeDataString(cboGenero.SelectedValue.ToString());
            genero = cboGenero.SelectedValue != null ? Uri.EscapeDataString(cboGenero.SelectedValue.ToString()) : string.Empty;
            //edad = Uri.EscapeDataString(cboEdad.SelectedValue.ToString());
            edad = cboEdad.SelectedValue != null ? Uri.EscapeDataString(cboEdad.SelectedValue.ToString()) : string.Empty;
            estado = Uri.EscapeDataString(string.Empty);
            if (rbtDisponible.Checked)
            {
                estado = Uri.EscapeDataString("Disponible");
            }
            if (rbtNoDisponible.Checked)
            {
                estado = Uri.EscapeDataString("No Disponible");
            }
            if (rbtDisponible.Checked == false && rbtNoDisponible.Checked == false)
            {
                estado = Uri.EscapeDataString(string.Empty);
            }

            dataGridView1.Rows.Clear();
            cboEdad.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
            rbtDisponible.Checked = false;
            rbtNoDisponible.Checked = false;

            CargarPeliculasAsync(titulo, genero, edad, estado);
        }

        private async void CargarPeliculasAsync(string titulo , string genero , string edad , string estado)
        {
            string url = string.Format("https://localhost:7246/Obtener%20Peliculas%20Filtradas", titulo, genero, edad, estado);
            //if (string.IsNullOrEmpty(titulo)) 
            //{
            //    url = string.Format(url + "&cliente={0}", Titulo);

            //}
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Peliculas>>(result);
            dataGridView1.Rows.Clear();
            if (lst != null)
            {
                foreach (Peliculas pelicula in lst)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                        pelicula.Titulo,
                        pelicula.EstadoPelicula,
                        pelicula.IdGenero,
                        pelicula.IdEdad,
                    });
                }

            }
            else
            {
                MessageBox.Show("Sin datos de peliculas para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
