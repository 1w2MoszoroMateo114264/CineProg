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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FrontEnd1.Forms
{
    public partial class Transaccion : Form
    {
        private List<Funciones> lstFunciones;
        private List<Tipo_Entrada> lstTiposEntradas;
        private string NrPelicula;
        private Factura nuevo;

        public Transaccion()
        {
            InitializeComponent();
            NrPelicula = "";
            nuevo = new Factura();
            lstFunciones = new List<Funciones>();
            lstTiposEntradas = new List<Tipo_Entrada>();
        }

        private void FrmTransaccion_Load(object sender, EventArgs e)
        {
            CargarTipoEntradaAsync();
            CargarFormaPagoAsync();
            CargarPeliculasAsync();
            CalcularyMostrarTotal();
        }


        private async Task CargarFuncionesAsync()
        {
            string NrPelicula = cboPelicula.SelectedValue?.ToString();

            if (!string.IsNullOrEmpty(NrPelicula))
            {
                string url = "https://localhost:7246/Funciones%20Filtradas%20x%20Pelicula?idPelicula=" + NrPelicula;
                var result = await ClienteSingleton.GetInstance().GetAsync(url);
                var lst = JsonConvert.DeserializeObject<List<Funciones>>(result);

                lstFunciones = lst;

                cboFunciones.DataSource = lst;
                cboFunciones.ValueMember = "NroFuncion";
                cboFunciones.DisplayMember = "ToString";
                //cboFunciones.SelectedIndex = -1;
                cboFunciones.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarPeliculasAsync()
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

        private async Task CargarFormaPagoAsync()
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

        private async Task CargarTipoEntradaAsync()
        {
            string url = "https://localhost:7246/Tipo%20De%20Entradas";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Tipo_Entrada>>(result);

            lstTiposEntradas = lst;

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
            if (cboFunciones.SelectedIndex != -1)
            {
                HabilitarDeshabilitarChk();
            }
            dataGridView.Rows.Clear();
        }

        private async void HabilitarDeshabilitarChk()
        {
            string nroFuncion = cboFunciones.SelectedValue.ToString();
            List<ButacasXFunciones> lstDisp = new List<ButacasXFunciones>();
            List<ButacasXFunciones> lstNoDisp = new List<ButacasXFunciones>();
            List<CheckBox> listachk = CargarListaButacas();


            int index = 1;

            string url = "https://localhost:7246/Butacas S/Funcion?nroFuncion=" + nroFuncion;
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<ButacasXFunciones>>(result);

            foreach (ButacasXFunciones butaca in lst)
            {
                string nombreCheckBox = $"butaca{index}";

                if (butaca.Estado.Equals("Disponibles"))
                {
                    foreach (CheckBox c in listachk)
                    {
                        if (c.Name == nombreCheckBox)
                        {
                            c.Enabled = true;
                            c.Checked = false;
                            c.BackColor = Color.Green;
                            c.FlatStyle = FlatStyle.Flat;
                            c.ForeColor = Color.Black;
                        }
                    }
                }
                if (butaca.Estado.Equals("No Disponible"))
                {
                    foreach (CheckBox c in listachk)
                    {
                        if (c.Name == nombreCheckBox)
                        {
                            c.Enabled = false;
                            c.Checked = false;
                            c.BackColor = Color.Red;
                            c.FlatStyle = FlatStyle.Flat;
                        }
                    }
                }
                index++;
            }


        }

        private List<CheckBox> CargarListaButacas()
        {
            List<CheckBox> listachk = new List<CheckBox>();
            listachk.Clear();
            listachk.Add(butaca1);
            listachk.Add(butaca2);
            listachk.Add(butaca3);
            listachk.Add(butaca4);
            listachk.Add(butaca5);
            listachk.Add(butaca6);
            listachk.Add(butaca7);
            listachk.Add(butaca8);
            listachk.Add(butaca9);
            return listachk;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int nroSala = 0;
            double precio = 0;
            bool funcionEncontrada = false;
            bool tipoEntradaEncontrado = false;

            // Validar el resto de la información
            if (!Validar())
            {
                return;
            }
            // Buscar la función seleccionada
            foreach (Funciones f in lstFunciones)
            {
                if (f.NroFuncion == int.Parse(cboFunciones.SelectedValue.ToString()))
                {
                    nroSala = f.NroSala;
                    break; // Salir del bucle una vez encontrada la función
                }
            }

            // Buscar el tipo de entrada seleccionado

            foreach (Tipo_Entrada t in lstTiposEntradas)
            {
                if (t.IdEntrada == int.Parse(cboTipoEntrada.SelectedValue.ToString()))
                {
                    precio = t.Precio;
                    break; // Salir del bucle una vez encontrado el tipo de entrada
                }
            }

            // Crear el detalle
            Detalle_factura detalle = new Detalle_factura();
            detalle.Funcion = int.Parse(cboFunciones.SelectedValue.ToString());

            // Encontrar la butaca marcada
            for (int i = 1; i <= 9; i++)
            {
                CheckBox checkBox = Controls.Find($"butaca{i}", true).FirstOrDefault() as CheckBox;
                if (checkBox != null && checkBox.Checked && checkBox.Enabled == true)
                {
                    detalle.Butaca = i;
                    checkBox.Enabled = false;
                    checkBox.BackColor = Color.Blue;
                    break;
                }
            }

            // Validar que la butaca esté seleccionada
            if (detalle.Butaca == 0)
            {
                MessageBox.Show("Debe seleccionar una butaca.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Verificar si la butaca ya está en el DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["colButaca"].Value) == detalle.Butaca)
                {
                    MessageBox.Show($"La butaca {detalle.Butaca} ya se encuentra como detalle.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            CalcularyMostrarTotal();

            nuevo.AgregarDetalle(detalle);
            dataGridView.Rows.Add(new object[] { detalle.Funcion, nroSala, detalle.Butaca, cboTipoEntrada.Text, precio, "Quitar" });

        }

        private bool Validar()
        {
            if (cboPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una película.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboTipoEntrada.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de entrada.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboFunciones.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una función.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una forma de pago.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.ColumnIndex == 5)
            {
                List<CheckBox> listachk = CargarListaButacas();
                for (int i = 1; i <= 9; i++)
                {
                    CheckBox checkBox = Controls.Find($"butaca{i}", true).FirstOrDefault() as CheckBox;
                    if (checkBox != null && checkBox.Checked && checkBox.Enabled == false)
                    {
                        checkBox.Enabled = true;
                        checkBox.Checked = false;
                        checkBox.BackColor = Color.Green;
                        break;
                    }
                }
                CalcularyMostrarTotal();
                nuevo.QuitarDetalle(dataGridView.CurrentRow.Index);
                dataGridView.Rows.Remove(dataGridView.CurrentRow);
                //CalcularTotal();
            }
        }
        private void CalcularyMostrarTotal()
        {
            double total = 0;
            foreach (DataGridViewRow precio in dataGridView.Rows)
            {
                total = total + Convert.ToDouble(precio.Cells["ColPrecio"].Value);

            }
            lblMonto.Text = total.ToString();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            ValidarFactura();
            await GenerarFactura();
        }

        private async Task GenerarFactura()
        {
            nuevo.IdFormaPago = int.Parse(cboFormaPago.SelectedValue.ToString());
            nuevo.Fecha = DateTime.Parse(dtpFecha.Value.ToString("dd/MM/yyyy"));
            nuevo.DniCliente = int.Parse(txtDni.Text.ToString());
            nuevo.Total = int.Parse(lblMonto.text);
            string bodyContent = JsonConvert.SerializeObject(nuevo);
        }

        private bool ValidarFactura()
        {
            if (string.IsNullOrEmpty(txtDni.Text) || !int.TryParse(txtDni.Text, out _))
            {
                MessageBox.Show("El campo DNI no debe estar vacío y solo debe contener números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una Butaca!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
    }
}

