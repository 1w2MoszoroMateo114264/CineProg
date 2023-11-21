namespace FrontEnd1.Forms
{
    partial class FrmInsModPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsModPelicula));
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            label2 = new Label();
            cboGenero = new ComboBox();
            cboClasificacion = new ComboBox();
            lblClasificacion = new Label();
            txtDuracion = new TextBox();
            lblDuracion = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            lstbPeliculas = new ListBox();
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            btnNuevo = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top;
            txtTitulo.Location = new Point(357, 180);
            txtTitulo.Margin = new Padding(4, 3, 4, 3);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(257, 23);
            txtTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(251, 178);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(85, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(233, 216);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 2;
            label2.Text = "Genero :";
            // 
            // cboGenero
            // 
            cboGenero.Anchor = AnchorStyles.Top;
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(357, 218);
            cboGenero.Margin = new Padding(4, 3, 4, 3);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(162, 23);
            cboGenero.TabIndex = 1;
            // 
            // cboClasificacion
            // 
            cboClasificacion.Anchor = AnchorStyles.Top;
            cboClasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClasificacion.FormattingEnabled = true;
            cboClasificacion.Location = new Point(357, 257);
            cboClasificacion.Margin = new Padding(4, 3, 4, 3);
            cboClasificacion.Name = "cboClasificacion";
            cboClasificacion.Size = new Size(162, 23);
            cboClasificacion.TabIndex = 2;
            // 
            // lblClasificacion
            // 
            lblClasificacion.Anchor = AnchorStyles.Top;
            lblClasificacion.AutoSize = true;
            lblClasificacion.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblClasificacion.ForeColor = Color.White;
            lblClasificacion.Location = new Point(175, 255);
            lblClasificacion.Margin = new Padding(4, 0, 4, 0);
            lblClasificacion.Name = "lblClasificacion";
            lblClasificacion.Size = new Size(161, 25);
            lblClasificacion.TabIndex = 5;
            lblClasificacion.Text = "Clasificacion :";
            // 
            // txtDuracion
            // 
            txtDuracion.Anchor = AnchorStyles.Top;
            txtDuracion.Location = new Point(357, 299);
            txtDuracion.Margin = new Padding(4, 3, 4, 3);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(75, 23);
            txtDuracion.TabIndex = 3;
            txtDuracion.TextChanged += textBox1_TextChanged;
            // 
            // lblDuracion
            // 
            lblDuracion.Anchor = AnchorStyles.Top;
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDuracion.ForeColor = Color.White;
            lblDuracion.Location = new Point(216, 297);
            lblDuracion.Margin = new Padding(4, 0, 4, 0);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(120, 25);
            lblDuracion.TabIndex = 7;
            lblDuracion.Text = "Duracion :";
            lblDuracion.Click += label1_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top;
            txtDescripcion.Location = new Point(357, 339);
            txtDescripcion.Margin = new Padding(4, 3, 4, 3);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(353, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.Top;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(186, 337);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(150, 25);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Descripcion :";
            // 
            // lstbPeliculas
            // 
            lstbPeliculas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lstbPeliculas.BackColor = Color.FromArgb(11, 7, 17);
            lstbPeliculas.ForeColor = Color.White;
            lstbPeliculas.FormattingEnabled = true;
            lstbPeliculas.ItemHeight = 15;
            lstbPeliculas.Location = new Point(783, 102);
            lstbPeliculas.Margin = new Padding(4, 3, 4, 3);
            lstbPeliculas.Name = "lstbPeliculas";
            lstbPeliculas.Size = new Size(224, 409);
            lstbPeliculas.TabIndex = 5;
            lstbPeliculas.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(11, 7, 17);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, -2);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 75);
            panel1.TabIndex = 24;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(265, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(461, 33);
            label6.TabIndex = 0;
            label6.Text = "Agregue o modifique su pelicula";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(235, 5, 75);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(0, 66);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 12);
            panel2.TabIndex = 25;
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
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.FromArgb(235, 5, 75);
            panel3.Location = new Point(-6, 75);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(12, 512);
            panel3.TabIndex = 37;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top;
            btnNuevo.BackColor = Color.FromArgb(11, 7, 17);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(219, 481);
            btnNuevo.Margin = new Padding(4, 3, 4, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(106, 30);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
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
            btnAgregar.Location = new Point(332, 481);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 30);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top;
            btnEditar.BackColor = Color.FromArgb(11, 7, 17);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(509, 481);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(106, 30);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.FromArgb(11, 7, 17);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(622, 481);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 30);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 87);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmInsModPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1066, 580);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(btnNuevo);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(lstbPeliculas);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDuracion);
            Controls.Add(txtDuracion);
            Controls.Add(lblClasificacion);
            Controls.Add(cboClasificacion);
            Controls.Add(cboGenero);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmInsModPelicula";
            Text = "AM Peliculas";
            Load += FrmInsModPelicula_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ListBox lstbPeliculas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}