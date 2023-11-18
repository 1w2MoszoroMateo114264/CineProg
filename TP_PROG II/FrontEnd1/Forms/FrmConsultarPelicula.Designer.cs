namespace FrontEnd1.Forms
{
    partial class FrmConsultarPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarPelicula));
            lblTitulo = new Label();
            cboGenero = new ComboBox();
            label2 = new Label();
            lblEdad = new Label();
            cboEdad = new ComboBox();
            dataGridView1 = new DataGridView();
            colTitulo = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            colEdad = new DataGridViewTextBoxColumn();
            colAlternarEstado = new DataGridViewTextBoxColumn();
            txtTitulo = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            btnConsultar = new Button();
            lblEstadoPelicula = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(252, 144);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(85, 25);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Titulo :";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // cboGenero
            // 
            cboGenero.Anchor = AnchorStyles.Top;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(358, 184);
            cboGenero.Margin = new Padding(4, 3, 4, 3);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(196, 23);
            cboGenero.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(235, 182);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 4;
            label2.Text = "Genero :";
            // 
            // lblEdad
            // 
            lblEdad.Anchor = AnchorStyles.Top;
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEdad.ForeColor = Color.White;
            lblEdad.Location = new Point(258, 220);
            lblEdad.Margin = new Padding(4, 0, 4, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(80, 25);
            lblEdad.TabIndex = 9;
            lblEdad.Text = "Edad :";
            // 
            // cboEdad
            // 
            cboEdad.Anchor = AnchorStyles.Top;
            cboEdad.FormattingEnabled = true;
            cboEdad.Location = new Point(358, 223);
            cboEdad.Margin = new Padding(4, 3, 4, 3);
            cboEdad.Name = "cboEdad";
            cboEdad.Size = new Size(134, 23);
            cboEdad.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colTitulo, colEstado, colGenero, colEdad, colAlternarEstado });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(201, 328);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(634, 172);
            dataGridView1.TabIndex = 13;
            // 
            // colTitulo
            // 
            colTitulo.HeaderText = "Título";
            colTitulo.Name = "colTitulo";
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            // 
            // colGenero
            // 
            colGenero.HeaderText = "Género";
            colGenero.Name = "colGenero";
            // 
            // colEdad
            // 
            colEdad.HeaderText = "Edad";
            colEdad.Name = "colEdad";
            // 
            // colAlternarEstado
            // 
            colAlternarEstado.HeaderText = "AlternarEstado";
            colAlternarEstado.Name = "colAlternarEstado";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top;
            txtTitulo.Location = new Point(358, 146);
            txtTitulo.Margin = new Padding(4, 3, 4, 3);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(303, 23);
            txtTitulo.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(11, 7, 17);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 75);
            panel1.TabIndex = 26;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(359, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(297, 33);
            label6.TabIndex = 0;
            label6.Text = "Consulte su pelicula";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(235, 5, 75);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(-1, 68);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 12);
            panel2.TabIndex = 27;
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
            panel3.TabIndex = 38;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 87);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top;
            btnConsultar.BackColor = Color.FromArgb(11, 7, 17);
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(728, 291);
            btnConsultar.Margin = new Padding(4, 3, 4, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(106, 30);
            btnConsultar.TabIndex = 40;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // lblEstadoPelicula
            // 
            lblEstadoPelicula.Anchor = AnchorStyles.Top;
            lblEstadoPelicula.AutoSize = true;
            lblEstadoPelicula.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoPelicula.ForeColor = Color.White;
            lblEstadoPelicula.Location = new Point(239, 266);
            lblEstadoPelicula.Margin = new Padding(4, 0, 4, 0);
            lblEstadoPelicula.Name = "lblEstadoPelicula";
            lblEstadoPelicula.Size = new Size(99, 25);
            lblEstadoPelicula.TabIndex = 41;
            lblEstadoPelicula.Text = "Estado :";
            // 
            // FrmConsultarPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1066, 580);
            Controls.Add(lblEstadoPelicula);
            Controls.Add(btnConsultar);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(lblEdad);
            Controls.Add(cboEdad);
            Controls.Add(cboGenero);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitulo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmConsultarPelicula";
            Text = "FrmConsultarPelicula";
            Load += FrmConsultarPelicula_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox cboGenero;
        private Label label2;
        private Label lblEdad;
        private ComboBox cboEdad;
        private DataGridView dataGridView1;
        private TextBox txtTitulo;
        private DataGridViewTextBoxColumn colTitulo;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colGenero;
        private DataGridViewTextBoxColumn colEdad;
        private DataGridViewTextBoxColumn colAlternarEstado;
        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button btnConsultar;
        private Label lblEstadoPelicula;
    }
}