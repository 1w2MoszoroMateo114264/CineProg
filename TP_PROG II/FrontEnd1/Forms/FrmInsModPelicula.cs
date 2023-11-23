using BackEnd.Dominio;
using FrontEnd1.HTTP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd1.Forms
{
    public partial class FrmInsModPelicula : Form
    {
        private Peliculas oPelicula;
        bool esNuevo = false;
        List<Peliculas> lst;
        public FrmInsModPelicula()
        {
            InitializeComponent();
            lst = new List<Peliculas>();
            oPelicula = new Peliculas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int elegido = lstbPeliculas.SelectedIndex;

            if (elegido != -1)
            {
                Peliculas oPeli = lst[elegido];
                txtTitulo.Text = oPeli.Titulo.ToString();
                txtDescripcion.Text = oPeli.Descripcion.ToString();
                txtDuracion.Text = oPeli.Duracion.ToString();
                cboClasificacion.SelectedValue = oPeli.IdEdad;
                cboGenero.SelectedValue = oPeli.IdGenero;
                //string estado = oPeli.EstadoPelicula.ToString();
                if (oPeli.EstadoPelicula == "Disponible")
                {
                    rbtDisponible.Checked = true;
                }
                else if (oPeli.EstadoPelicula == "No Disponible")
                {
                    rbtNoDisponible.Checked = true;
                }
                btnEditar.Enabled = true;
                btnNuevo.Enabled = false;
                btnCancelar.Enabled = true;
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (esNuevo == true)
                {
                    await GuardarPeliculaNuevaAsync();
                }
                else if (esNuevo == false)
                {
                    await ActualizarPeliculaAsync();
                }
                        
            }



        }

        private async Task ActualizarPeliculaAsync()
        {
            int elegido = lstbPeliculas.SelectedIndex;
            Peliculas oPeli = lst[elegido];
            oPeli.Titulo = txtTitulo.Text;
            oPeli.IdGenero = (int)cboGenero.SelectedValue;
            oPeli.IdEdad = (int)cboClasificacion.SelectedValue;
            oPeli.Duracion = int.Parse(txtDuracion.Text);
            oPeli.Descripcion = txtDescripcion.Text;
            if (rbtDisponible.Checked == true)
            {
                oPeli.EstadoPelicula = "Disponible";
            }
            else if (rbtNoDisponible.Checked == true)
            {
                oPeli.EstadoPelicula = "No Disponible";
            }
            string bodyContent = JsonConvert.SerializeObject(oPeli);

            string url = "https://localhost:7246/Modificar Pelicula";
            var resultado = await ClienteSingleton.GetInstance().PutAsync(url, bodyContent);

            if (!string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show("Pelicula Actualizada con Exito", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPeliculasEnListBox();
                Habilitar(true);
                Limpiar();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo Actualizar la Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GuardarPeliculaNuevaAsync()
        {
            Peliculas oPelicula = new Peliculas();
            oPelicula.Titulo = txtTitulo.Text;
            oPelicula.IdGenero = (int)cboGenero.SelectedValue;
            oPelicula.IdEdad = (int)cboClasificacion.SelectedValue;
            oPelicula.Duracion = int.Parse(txtDuracion.Text);
            oPelicula.Descripcion = txtDescripcion.Text;
            if (rbtDisponible.Checked == true)
            {
                oPelicula.EstadoPelicula = "Disponible";
            }
            else if (rbtNoDisponible.Checked == true)
            {
                oPelicula.EstadoPelicula = "No Disponible";
            }
            string bodyContent = JsonConvert.SerializeObject(oPelicula);
        
            string url = "https://localhost:7246/Crear Pelicula";
            var resultado = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (!string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show("Pelicula registrado con Exito!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPeliculasEnListBox();
                Habilitar(true);
                Limpiar();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar()
        {
            if (cboClasificacion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Clasificacion!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Genero!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtTitulo.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe ingresar un Titulo valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtDuracion.Text == "" && int.TryParse(txtDuracion.Text, out _))
            {
                MessageBox.Show("Debe ingresar una duracion valida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtDescripcion.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar una Descripcion valida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            foreach (var item in lstbPeliculas.Items)
            {
                if (item.ToString().Equals(txtTitulo.Text))
                {
                    MessageBox.Show("Pelicula: " + txtTitulo.Text + " ya se encuentra en la lista!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
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
                Limpiar();
                Habilitar(true);
                esNuevo = false;
            }
            else
            {
                return;
            }
        }

        private void FrmInsModPelicula_Load(object sender, EventArgs e)
        {
            Habilitar(true);
            CargarGenerosAsync();
            CargarCategoriasAsync();
            CargarPeliculasEnListBox();
        }

        private async Task CargarPeliculasEnListBox()
        {
            try
            {
                string url = "https://localhost:7246/Obtener Peliculas";
                var result = await ClienteSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(result))
                {
                    lst = JsonConvert.DeserializeObject<List<Peliculas>>(result);


                    lstbPeliculas.Items.Clear();

                    lstbPeliculas.Items.AddRange(lst.ToArray());

                    lstbPeliculas.SelectedIndex = -1;
                }
                else
                {
                    Console.WriteLine("Error: La respuesta del servidor está vacía.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener películas: " + ex.Message);
            }
        }

        private void Habilitar(bool v)
        {
            txtTitulo.Enabled = !v;
            cboGenero.Enabled = !v;
            cboClasificacion.Enabled = !v;
            txtDuracion.Enabled = !v;
            txtDescripcion.Enabled = !v;
            rbtDisponible.Enabled = !v;
            rbtNoDisponible.Enabled = !v;
            btnNuevo.Enabled = v;
            btnGrabar.Enabled = !v;
            btnEditar.Enabled = v;
            lstbPeliculas.Enabled = v;
            btnCancelar.Enabled = !v;
        }

        private async Task CargarGenerosAsync()
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

        private async Task CargarCategoriasAsync()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(false);
            esNuevo = true;
        }

        private void Limpiar()
        {
            cboClasificacion.SelectedIndex = -1;
            txtTitulo.Text = string.Empty;
            cboGenero.SelectedIndex = -1;
            txtDuracion.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            rbtDisponible.Checked = false;
            rbtNoDisponible.Checked = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstbPeliculas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la Pelicula que desea editar.");
            }
            else
            {
                esNuevo = false;
                Habilitar(false);

            }
        }
    }
}
