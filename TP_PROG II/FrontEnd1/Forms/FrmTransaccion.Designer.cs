namespace FrontEnd1.Forms
{
    partial class Transaccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaccion));
            dtpFecha = new DateTimePicker();
            txtDni = new TextBox();
            label1 = new Label();
            cboFormaPago = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboFunciones = new ComboBox();
            butaca1 = new CheckBox();
            butaca4 = new CheckBox();
            butaca7 = new CheckBox();
            butaca8 = new CheckBox();
            butaca5 = new CheckBox();
            butaca2 = new CheckBox();
            butaca9 = new CheckBox();
            butaca6 = new CheckBox();
            butaca3 = new CheckBox();
            cboTipoEntrada = new ComboBox();
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            panel5 = new Panel();
            lblTotal = new Label();
            panel6 = new Panel();
            lblMonto = new Label();
            cboPelicula = new ComboBox();
            label9 = new Label();
            panel8 = new Panel();
            label11 = new Label();
            dataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ColNroSala = new DataGridViewTextBoxColumn();
            colButaca = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            colQuitar = new DataGridViewButtonColumn();
            btnAceptar = new Button();
            btnCancelar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnAgregar = new Button();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Top;
            dtpFecha.CalendarMonthBackground = SystemColors.WindowFrame;
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(236, 150);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(152, 23);
            dtpFecha.TabIndex = 0;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Top;
            txtDni.Location = new Point(566, 150);
            txtDni.Margin = new Padding(4, 3, 4, 3);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(152, 23);
            txtDni.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 148);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "Fecha :";
            // 
            // cboFormaPago
            // 
            cboFormaPago.Anchor = AnchorStyles.Top;
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(566, 226);
            cboFormaPago.Margin = new Padding(4, 3, 4, 3);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(152, 23);
            cboFormaPago.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(447, 221);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 4;
            label2.Text = "F Pago :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(403, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 5;
            label3.Text = "DNI Cliente :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(107, 186);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 7;
            label4.Text = "Pelicula :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(56, 224);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 25);
            label5.TabIndex = 8;
            label5.Text = "Tipo Entrada :";
            // 
            // cboFunciones
            // 
            cboFunciones.Anchor = AnchorStyles.Top;
            cboFunciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFunciones.Enabled = false;
            cboFunciones.FormattingEnabled = true;
            cboFunciones.Location = new Point(566, 188);
            cboFunciones.Margin = new Padding(4, 3, 4, 3);
            cboFunciones.Name = "cboFunciones";
            cboFunciones.Size = new Size(152, 23);
            cboFunciones.TabIndex = 3;
            cboFunciones.SelectedIndexChanged += cboFunciones_SelectedIndexChanged;
            // 
            // butaca1
            // 
            butaca1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butaca1.AutoSize = true;
            butaca1.Location = new Point(872, 165);
            butaca1.Margin = new Padding(4, 3, 4, 3);
            butaca1.Name = "butaca1";
            butaca1.Size = new Size(15, 14);
            butaca1.TabIndex = 6;
            butaca1.UseVisualStyleBackColor = true;
            // 
            // butaca4
            // 
            butaca4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butaca4.AutoSize = true;
            butaca4.Location = new Point(872, 249);
            butaca4.Margin = new Padding(4, 3, 4, 3);
            butaca4.Name = "butaca4";
            butaca4.Size = new Size(15, 14);
            butaca4.TabIndex = 9;
            butaca4.UseVisualStyleBackColor = true;
            // 
            // butaca7
            // 
            butaca7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butaca7.AutoSize = true;
            butaca7.Location = new Point(872, 335);
            butaca7.Margin = new Padding(4, 3, 4, 3);
            butaca7.Name = "butaca7";
            butaca7.Size = new Size(15, 14);
            butaca7.TabIndex = 12;
            butaca7.UseVisualStyleBackColor = true;
            // 
            // butaca8
            // 
            butaca8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butaca8.AutoSize = true;
            butaca8.Location = new Point(934, 335);
            butaca8.Margin = new Padding(4, 3, 4, 3);
            butaca8.Name = "butaca8";
            butaca8.Size = new Size(15, 14);
            butaca8.TabIndex = 13;
            butaca8.UseVisualStyleBackColor = true;
            // 
            // butaca5
            // 
            butaca5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butaca5.AutoSize = true;
            butaca5.Location = new Point(934, 249);
            butaca5.Margin = new Padding(4, 3, 4, 3);
            butaca5.Name = "butaca5";
            butaca5.Size = new Size(15, 14);
            butaca5.TabIndex = 10;
            butaca5.UseVisualStyleBackColor = true;
            // 
            // butaca2
            // 
            butaca2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butaca2.AutoSize = true;
            butaca2.Location = new Point(934, 165);
            butaca2.Margin = new Padding(4, 3, 4, 3);
            butaca2.Name = "butaca2";
            butaca2.Size = new Size(15, 14);
            butaca2.TabIndex = 7;
            butaca2.UseVisualStyleBackColor = true;
            // 
            // butaca9
            // 
            butaca9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butaca9.AutoSize = true;
            butaca9.Location = new Point(993, 335);
            butaca9.Margin = new Padding(4, 3, 4, 3);
            butaca9.Name = "butaca9";
            butaca9.Size = new Size(15, 14);
            butaca9.TabIndex = 14;
            butaca9.UseVisualStyleBackColor = true;
            // 
            // butaca6
            // 
            butaca6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butaca6.AutoSize = true;
            butaca6.Location = new Point(993, 249);
            butaca6.Margin = new Padding(4, 3, 4, 3);
            butaca6.Name = "butaca6";
            butaca6.Size = new Size(15, 14);
            butaca6.TabIndex = 11;
            butaca6.UseVisualStyleBackColor = true;
            // 
            // butaca3
            // 
            butaca3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            butaca3.AutoSize = true;
            butaca3.Location = new Point(993, 165);
            butaca3.Margin = new Padding(4, 3, 4, 3);
            butaca3.Name = "butaca3";
            butaca3.Size = new Size(15, 14);
            butaca3.TabIndex = 8;
            butaca3.UseVisualStyleBackColor = true;
            // 
            // cboTipoEntrada
            // 
            cboTipoEntrada.Anchor = AnchorStyles.Top;
            cboTipoEntrada.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoEntrada.FormattingEnabled = true;
            cboTipoEntrada.Location = new Point(236, 226);
            cboTipoEntrada.Margin = new Padding(4, 3, 4, 3);
            cboTipoEntrada.Name = "cboTipoEntrada";
            cboTipoEntrada.Size = new Size(152, 23);
            cboTipoEntrada.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(11, 7, 17);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-1, -3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 75);
            panel1.TabIndex = 21;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(366, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(320, 33);
            label6.TabIndex = 0;
            label6.Text = "Seleccione su funcion";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(235, 5, 75);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(-1, 65);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 12);
            panel2.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 9);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(12, 449);
            panel4.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(11, 7, 17);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(810, 74);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 255);
            panel3.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(90, 6);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 13);
            label7.TabIndex = 24;
            label7.Text = "BUTACAS";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel5.BackColor = Color.FromArgb(235, 5, 75);
            panel5.Location = new Point(-7, 72);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(12, 511);
            panel5.TabIndex = 24;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(11, 7, 17);
            lblTotal.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(812, 540);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(119, 25);
            lblTotal.TabIndex = 25;
            lblTotal.Text = "TOTAL : $";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(11, 7, 17);
            panel6.Controls.Add(lblMonto);
            panel6.ForeColor = Color.Transparent;
            panel6.Location = new Point(810, 527);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(257, 55);
            panel6.TabIndex = 26;
            // 
            // lblMonto
            // 
            lblMonto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.FromArgb(11, 7, 17);
            lblMonto.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMonto.ForeColor = Color.White;
            lblMonto.Location = new Point(124, 13);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(58, 25);
            lblMonto.TabIndex = 26;
            lblMonto.Text = "0.00";
            // 
            // cboPelicula
            // 
            cboPelicula.Anchor = AnchorStyles.Top;
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPelicula.FormattingEnabled = true;
            cboPelicula.Location = new Point(236, 188);
            cboPelicula.Margin = new Padding(4, 3, 4, 3);
            cboPelicula.Name = "cboPelicula";
            cboPelicula.Size = new Size(152, 23);
            cboPelicula.TabIndex = 2;
            cboPelicula.SelectedIndexChanged += cboPelicula_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(413, 186);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(135, 25);
            label9.TabIndex = 28;
            label9.Text = "Funciones :";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel8.BackColor = Color.Black;
            panel8.Controls.Add(label11);
            panel8.Location = new Point(810, 358);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(257, 102);
            panel8.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(56, 39);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(128, 25);
            label11.TabIndex = 32;
            label11.Text = "PANTALLA";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top;
            dataGridView.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, ColNroSala, colButaca, dataGridViewTextBoxColumn2, ColPrecio, colQuitar });
            dataGridView.GridColor = SystemColors.ActiveCaptionText;
            dataGridView.Location = new Point(118, 317);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(635, 198);
            dataGridView.TabIndex = 16;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            //dataGridView.CellValueChanged += dataGridView_CellValueChanged;
            dataGridView.RowsAdded += dataGridView_RowsAdded;
            //dataGridView.UserDeletedRow += dataGridView_UserDeletedRow;
            //dataGridView.UserDeletingRow += dataGridView_UserDeletingRow;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Funcion";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ColNroSala
            // 
            ColNroSala.HeaderText = "Sala";
            ColNroSala.Name = "ColNroSala";
            ColNroSala.ReadOnly = true;
            ColNroSala.Width = 80;
            // 
            // colButaca
            // 
            colButaca.HeaderText = "Butaca";
            colButaca.Name = "colButaca";
            colButaca.ReadOnly = true;
            colButaca.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tipo de entrada";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            // 
            // colQuitar
            // 
            colQuitar.HeaderText = "Quitar";
            colQuitar.Name = "colQuitar";
            colQuitar.ReadOnly = true;
            colQuitar.Text = "Quitar";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Top;
            btnAceptar.BackColor = Color.FromArgb(11, 7, 17);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAceptar.Location = new Point(174, 527);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(166, 32);
            btnAceptar.TabIndex = 17;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.FromArgb(11, 7, 17);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(525, 527);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 32);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 83);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Diseño_sin_título__1_;
            pictureBox1.Location = new Point(810, 100);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top;
            btnAgregar.BackColor = Color.FromArgb(11, 7, 17);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(646, 280);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 30);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(810, 455);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(257, 66);
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // Transaccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1066, 580);
            Controls.Add(pictureBox3);
            Controls.Add(btnAgregar);
            Controls.Add(pictureBox2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(panel8);
            Controls.Add(label9);
            Controls.Add(cboPelicula);
            Controls.Add(lblTotal);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(cboTipoEntrada);
            Controls.Add(butaca9);
            Controls.Add(butaca6);
            Controls.Add(butaca3);
            Controls.Add(butaca8);
            Controls.Add(butaca5);
            Controls.Add(butaca2);
            Controls.Add(butaca7);
            Controls.Add(butaca4);
            Controls.Add(butaca1);
            Controls.Add(pictureBox1);
            Controls.Add(cboFunciones);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboFormaPago);
            Controls.Add(label1);
            Controls.Add(txtDni);
            Controls.Add(dtpFecha);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Transaccion";
            Text = "FrmTransaccion";
            Load += FrmTransaccion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFunciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox butaca1;
        private System.Windows.Forms.CheckBox butaca4;
        private System.Windows.Forms.CheckBox butaca7;
        private System.Windows.Forms.CheckBox butaca8;
        private System.Windows.Forms.CheckBox butaca5;
        private System.Windows.Forms.CheckBox butaca2;
        private System.Windows.Forms.CheckBox butaca9;
        private System.Windows.Forms.CheckBox butaca6;
        private System.Windows.Forms.CheckBox butaca3;
        private System.Windows.Forms.ComboBox cboTipoEntrada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cboPelicula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAgregar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ColNroSala;
        private DataGridViewTextBoxColumn colButaca;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewButtonColumn colQuitar;
        private PictureBox pictureBox3;
        private Label monto;
        private Label lblMonto;
    }
}