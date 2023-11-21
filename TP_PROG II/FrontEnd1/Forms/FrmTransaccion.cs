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
    public partial class Transaccion : Form
    {
        string NrPelicula;
        public Transaccion()
        {
            InitializeComponent();
            NrPelicula = "";
        }

        private void FrmTransaccion_Load(object sender, EventArgs e)
        {
            CargarTipoEntradaAsync();
            CargarFormaPagoAsync();
            CargarPeliculasAsync();
        }

        private async void CargarFuncionesAsync()
        {
            string NrPelicula = cboPelicula.SelectedValue?.ToString();

            if (!string.IsNullOrEmpty(NrPelicula))
            {
                string url = "https://localhost:7246/Funciones%20Filtradas%20x%20Pelicula?idPelicula=" + NrPelicula;
                var result = await ClienteSingleton.GetInstance().GetAsync(url);
                var lst = JsonConvert.DeserializeObject<List<Funciones>>(result);

                cboFunciones.DataSource = lst;
                cboFunciones.ValueMember = "NroFuncion";
                cboFunciones.DisplayMember = "ToString";
                cboFunciones.SelectedIndex = -1;
                cboFunciones.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarPeliculasAsync()
        {
            string url = "https://localhost:7246/Obtener%20Peliculas%20Disponibles";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Peliculas>>(result);

            cboPelicula.DataSource = lst;
            cboPelicula.ValueMember = "IdPelicula";
            cboPelicula.DisplayMember = "Titulo";
            //cboPelicula.SelectedIndex = -1;
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void CargarFormaPagoAsync()
        {
            string url = "https://localhost:7246/Formas%20de%20Pago";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Forma_de_pagos>>(result);

            cboFormaPago.DataSource = lst;
            cboFormaPago.ValueMember = "IdPago";
            cboFormaPago.DisplayMember = "FormaPago";
            cboFormaPago.SelectedIndex = -1;
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void CargarTipoEntradaAsync()
        {
            string url = "https://localhost:7246/Tipo%20De%20Entradas";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Tipo_Entrada>>(result);

            cboTipoEntrada.DataSource = lst;
            cboTipoEntrada.ValueMember = "IdEntrada";
            cboTipoEntrada.DisplayMember = "TipoEntrada";
            cboTipoEntrada.SelectedIndex = -1;
            cboTipoEntrada.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private async void cboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPelicula.SelectedIndex != -1)
            {
                cboFunciones.Enabled = true;
                CargarFuncionesAsync();
            }
        }

        private async void cboFunciones_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
