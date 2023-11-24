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
            Limpiar();
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
                Limpiar();
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
            Funciones fun = cboFunciones.SelectedItem as Funciones;
            detalle.Funcion = fun.NroFuncion;
            detalle.TipoEntrada = int.Parse(cboTipoEntrada.SelectedValue.ToString());
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

                nuevo.QuitarDetalle(dataGridView.CurrentRow.Index);
                dataGridView.Rows.Remove(dataGridView.CurrentRow);
                //CalcularTotal();
            }
            CalcularyMostrarTotal();
        }
        private void CalcularyMostrarTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow && double.TryParse(row.Cells["ColPrecio"].Value.ToString(), out double monto))
                {
                    total += monto;
                }
            }
            lblMonto.Text = total.ToString("N2");
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            Funciones oFuncion = cboFunciones.SelectedItem as Funciones;

            ValidarFactura();
            await GenerarFactura();
            await ActualizarButacas(oFuncion);
        }
        private async Task GenerarFactura()
        {
            nuevo.IdFormaPago = int.Parse(cboFormaPago.SelectedValue.ToString());
            nuevo.Fecha = DateTime.Parse(dtpFecha.Value.ToString("dd/MM/yyyy"));
            nuevo.DniCliente = int.Parse(txtDni.Text.ToString());
            nuevo.Total = double.Parse(lblMonto.Text);
            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "https://localhost:7246/Insertar Factura";
            var resultado = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (!string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show("Transacción registrado con Exito!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //CargarPeliculasEnListBox();
                //Habilitar(true);
                
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo Realizar la Transacción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task ActualizarButacas(Funciones oFuncion)
        {
            List<CheckBox> lista = new List<CheckBox>();
            List<ButacasXFunciones> lstButacas = new List<ButacasXFunciones>();
            lista = CargarListaButacas();
            int indice = 1;

            CheckBox checkBox = Controls.Find($"butaca{indice}", true).FirstOrDefault() as CheckBox;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Checked==true && lista[i].BackColor == Color.Blue)
                {

                    switch (oFuncion.NroSala)
                    {

                        case 101:
                            
                            ButacasXFunciones but = new ButacasXFunciones();
                            switch ($"butaca{indice}")
                            {
                                case $"butaca1":
                                    but.IdButaca = 1;
                                    break;
                                case $"butaca2":
                                    but.IdButaca = 2;
                                    break;
                                case $"butaca3":
                                    but.IdButaca = 3;
                                    break;
                                case $"butaca4":
                                    but.IdButaca = 4;
                                    break;
                                case $"butaca5":
                                    but.IdButaca = 5;
                                    break;
                                case $"butaca6":
                                    but.IdButaca = 6;
                                    break;
                                case $"butaca7":
                                    but.IdButaca = 7;
                                    break;
                                case $"butaca8":
                                    but.IdButaca = 8;
                                    break;
                                case $"butaca9":
                                    but.IdButaca = 9;
                                    break;

                            }
                            but.NroFunciones = oFuncion.NroFuncion;
                            lstButacas.Add(but);
                            break;
                        case 102:
                            CheckBox checkBox1 = Controls.Find($"butaca{indice}", true).FirstOrDefault() as CheckBox;
                            ButacasXFunciones but1 = new ButacasXFunciones();
                            switch ($"butaca{indice}")
                            {
                                case $"butaca1":
                                    but1.IdButaca = 10;
                                    break;
                                case $"butaca2":
                                    but1.IdButaca = 11;
                                    break;
                                case $"butaca3":
                                    but1.IdButaca = 12;
                                    break;
                                case $"butaca4":
                                    but1.IdButaca = 13;
                                    break;
                                case $"butaca5":
                                    but1.IdButaca = 14;
                                    break;
                                case $"butaca6":
                                    but1.IdButaca = 15;
                                    break;
                                case $"butaca7":
                                    but1.IdButaca = 16;
                                    break;
                                case $"butaca8":
                                    but1.IdButaca = 17;
                                    break;
                                case $"butaca9":
                                    but1.IdButaca = 18;
                                    break;
                            }
                            but1.NroFunciones = oFuncion.NroFuncion;
                            lstButacas.Add(but1);


                            break;
                        case 103:

                            CheckBox checkBox2 = Controls.Find($"butaca{indice}", true).FirstOrDefault() as CheckBox;

                            ButacasXFunciones but2 = new ButacasXFunciones();
                            switch ($"butaca{indice}")
                            {
                                case $"butaca1":
                                    but2.IdButaca = 19;
                                    break;
                                case $"butaca2":
                                    but2.IdButaca = 20;
                                    break;
                                case $"butaca3":
                                    but2.IdButaca = 21;
                                    break;
                                case $"butaca4":
                                    but2.IdButaca = 22;
                                    break;
                                case $"butaca5":
                                    but2.IdButaca = 23;
                                    break;
                                case $"butaca6":
                                    but2.IdButaca = 24;
                                    break;
                                case $"butaca7":
                                    but2.IdButaca = 25;
                                    break;
                                case $"butaca8":
                                    but2.IdButaca = 26;
                                    break;
                                case $"butaca9":
                                    but2.IdButaca = 27;
                                    break;
                            }
                            but2.NroFunciones = oFuncion.NroFuncion;
                            lstButacas.Add(but2);


                            break;
                        case 201:

                            CheckBox checkBox3 = Controls.Find($"butaca{indice}", true).FirstOrDefault() as CheckBox;

                            ButacasXFunciones but3 = new ButacasXFunciones();
                            switch ($"butaca{indice}")
                            {
                                case $"butaca1":
                                    but3.IdButaca = 28;
                                    break;
                                case $"butaca2":
                                    but3.IdButaca = 29;
                                    break;
                                case $"butaca3":
                                    but3.IdButaca = 30;
                                    break;
                                case $"butaca4":
                                    but3.IdButaca = 31;
                                    break;
                                case $"butaca5":
                                    but3.IdButaca = 32;
                                    break;
                                case $"butaca6":
                                    but3.IdButaca = 33;
                                    break;
                                case $"butaca7":
                                    but3.IdButaca = 34;
                                    break;
                                case $"butaca8":
                                    but3.IdButaca = 35;
                                    break;
                                case $"butaca9":
                                    but3.IdButaca = 36;
                                    break;
                            }
                            but3.NroFunciones = oFuncion.NroFuncion;
                            lstButacas.Add(but3);


                            break;
                        case 202:

                            CheckBox checkBox4 = Controls.Find($"butaca{indice}", true).FirstOrDefault() as CheckBox;

                            ButacasXFunciones but4 = new ButacasXFunciones();
                            switch ($"butaca{indice}")
                            {
                                case $"butaca1":
                                    but4.IdButaca = 37;
                                    break;
                                case $"butaca2":
                                    but4.IdButaca = 38;
                                    break;
                                case $"butaca3":
                                    but4.IdButaca = 39;
                                    break;
                                case $"butaca4":
                                    but4.IdButaca = 40;
                                    break;
                                case $"butaca5":
                                    but4.IdButaca = 41;
                                    break;
                                case $"butaca6":
                                    but4.IdButaca = 42;
                                    break;
                                case $"butaca7":
                                    but4.IdButaca = 43;
                                    break;
                                case $"butaca8":
                                    but4.IdButaca = 44;
                                    break;
                                case $"butaca9":
                                    but4.IdButaca = 45;
                                    break;
                            }
                            but4.NroFunciones = oFuncion.NroFuncion;
                            lstButacas.Add(but4);


                            break;
                        case 203:

                            CheckBox checkBox5 = Controls.Find($"butaca{indice}", true).FirstOrDefault() as CheckBox;

                            ButacasXFunciones but5 = new ButacasXFunciones();
                            switch ($"butaca{indice}")
                            {
                                case $"butaca1":
                                    but5.IdButaca = 46;
                                    break;
                                case $"butaca2":
                                    but5.IdButaca = 47;
                                    break;
                                case $"butaca3":
                                    but5.IdButaca = 48;
                                    break;
                                case $"butaca4":
                                    but5.IdButaca = 49;
                                    break;
                                case $"butaca5":
                                    but5.IdButaca = 50;
                                    break;
                                case $"butaca6":
                                    but5.IdButaca = 51;
                                    break;
                                case $"butaca7":
                                    but5.IdButaca = 52;
                                    break;
                                case $"butaca8":
                                    but5.IdButaca = 53;
                                    break;
                                case $"butaca9":
                                    but5.IdButaca = 54;
                                    break;
                            }
                            but5.NroFunciones = oFuncion.NroFuncion;
                            lstButacas.Add(but5);


                            break;
                        default:
                            break;
                    }
                    indice++;
                }
            }

            string bodyContent = JsonConvert.SerializeObject(lstButacas);

            string url = "https://localhost:7246/Modificar Estado de Butaca";
            var resultado = await ClienteSingleton.GetInstance().PutAsync(url, bodyContent);

            if (!string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show("Butacas Actualizadas con Exito!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo Actualizar las Butacas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Limpiar()
        {
            cboTipoEntrada.SelectedIndex = -1;
            txtDni.Text = string.Empty;
            cboFunciones.SelectedIndex = -1;
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
            butaca1.BackColor = Color.White;
            butaca2.BackColor = Color.White;
            butaca3.BackColor = Color.White;
            butaca4.BackColor = Color.White;
            butaca5.BackColor = Color.White;
            butaca6.BackColor = Color.White;
            butaca7.BackColor = Color.White;
            butaca8.BackColor = Color.White;
            butaca9.BackColor = Color.White;
            lblMonto.Text = "0,00";
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

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularyMostrarTotal();
        }
    }
}

