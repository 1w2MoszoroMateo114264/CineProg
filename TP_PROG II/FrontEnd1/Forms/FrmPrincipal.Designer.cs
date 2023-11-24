
namespace FrontEnd1
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            barraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            menuVertical = new Panel();
            panel6 = new Panel();
            bntSalir = new PictureBox();
            panel4 = new Panel();
            panel3 = new Panel();
            btnAcerca = new Button();
            btnReportes = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            btnTransaccion = new Button();
            btnSoporte = new Button();
            pictureBox2 = new PictureBox();
            panelContenedor = new Panel();
            pictureBox1 = new PictureBox();
            panelsubmenuAcerca = new Panel();
            btnDesarrollado = new Button();
            panel15 = new Panel();
            submenuSoporte = new Panel();
            btnAMPeliculas = new Button();
            panel5 = new Panel();
            btnPeliculas = new Button();
            panel8 = new Panel();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bntSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelsubmenuAcerca.SuspendLayout();
            submenuSoporte.SuspendLayout();
            SuspendLayout();
            // 
            // barraTitulo
            // 
            barraTitulo.AllowDrop = true;
            barraTitulo.BackColor = Color.FromArgb(11, 7, 17);
            barraTitulo.Controls.Add(btnRestaurar);
            barraTitulo.Controls.Add(btnMinimizar);
            barraTitulo.Controls.Add(btnMaximizar);
            barraTitulo.Controls.Add(btnCerrar);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Margin = new Padding(4, 3, 4, 3);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(1284, 35);
            barraTitulo.TabIndex = 1;
            barraTitulo.MouseDown += barraTitulo_MouseDown;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1216, 3);
            btnRestaurar.Margin = new Padding(4, 3, 4, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(24, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1185, 3);
            btnMinimizar.Margin = new Padding(4, 3, 4, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(24, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1216, 3);
            btnMaximizar.Margin = new Padding(4, 3, 4, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(24, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1247, 3);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // menuVertical
            // 
            menuVertical.BackColor = Color.FromArgb(11, 7, 17);
            menuVertical.Controls.Add(panel6);
            menuVertical.Controls.Add(bntSalir);
            menuVertical.Controls.Add(panel4);
            menuVertical.Controls.Add(panel3);
            menuVertical.Controls.Add(btnAcerca);
            menuVertical.Controls.Add(btnReportes);
            menuVertical.Controls.Add(panel2);
            menuVertical.Controls.Add(panel1);
            menuVertical.Controls.Add(btnTransaccion);
            menuVertical.Controls.Add(btnSoporte);
            menuVertical.Controls.Add(pictureBox2);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 35);
            menuVertical.Margin = new Padding(4, 3, 4, 3);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(220, 577);
            menuVertical.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Location = new Point(220, 121);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 1;
            // 
            // bntSalir
            // 
            bntSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bntSalir.Image = Properties.Resources._95036__1_;
            bntSalir.Location = new Point(0, 524);
            bntSalir.Margin = new Padding(4, 3, 4, 3);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(93, 39);
            bntSalir.SizeMode = PictureBoxSizeMode.Zoom;
            bntSalir.TabIndex = 8;
            bntSalir.TabStop = false;
            bntSalir.Click += bntSalir_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(235, 5, 75);
            panel4.Location = new Point(1, 320);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 32);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(235, 5, 75);
            panel3.Location = new Point(1, 265);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 32);
            panel3.TabIndex = 4;
            // 
            // btnAcerca
            // 
            btnAcerca.BackColor = Color.FromArgb(11, 7, 17);
            btnAcerca.FlatAppearance.BorderSize = 0;
            btnAcerca.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnAcerca.FlatStyle = FlatStyle.Flat;
            btnAcerca.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcerca.ForeColor = Color.White;
            btnAcerca.Image = (Image)resources.GetObject("btnAcerca.Image");
            btnAcerca.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcerca.Location = new Point(1, 320);
            btnAcerca.Margin = new Padding(4, 3, 4, 3);
            btnAcerca.Name = "btnAcerca";
            btnAcerca.Size = new Size(216, 32);
            btnAcerca.TabIndex = 3;
            btnAcerca.Text = "  Acerca de";
            btnAcerca.UseVisualStyleBackColor = false;
            btnAcerca.Click += btnAcerca_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(11, 7, 17);
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(1, 265);
            btnReportes.Margin = new Padding(4, 3, 4, 3);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(216, 32);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 5, 75);
            panel2.Location = new Point(1, 212);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 32);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 5, 75);
            panel1.Location = new Point(1, 158);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 32);
            panel1.TabIndex = 0;
            // 
            // btnTransaccion
            // 
            btnTransaccion.BackColor = Color.FromArgb(11, 7, 17);
            btnTransaccion.FlatAppearance.BorderSize = 0;
            btnTransaccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnTransaccion.FlatStyle = FlatStyle.Flat;
            btnTransaccion.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransaccion.ForeColor = Color.White;
            btnTransaccion.Image = (Image)resources.GetObject("btnTransaccion.Image");
            btnTransaccion.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaccion.Location = new Point(1, 212);
            btnTransaccion.Margin = new Padding(4, 3, 4, 3);
            btnTransaccion.Name = "btnTransaccion";
            btnTransaccion.Size = new Size(216, 32);
            btnTransaccion.TabIndex = 1;
            btnTransaccion.Text = "Transacción";
            btnTransaccion.UseVisualStyleBackColor = false;
            btnTransaccion.Click += btnTransaccion_Click;
            // 
            // btnSoporte
            // 
            btnSoporte.BackColor = Color.FromArgb(11, 7, 17);
            btnSoporte.FlatAppearance.BorderSize = 0;
            btnSoporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnSoporte.FlatStyle = FlatStyle.Flat;
            btnSoporte.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSoporte.ForeColor = Color.White;
            btnSoporte.Image = (Image)resources.GetObject("btnSoporte.Image");
            btnSoporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnSoporte.Location = new Point(1, 158);
            btnSoporte.Margin = new Padding(4, 3, 4, 3);
            btnSoporte.Name = "btnSoporte";
            btnSoporte.Size = new Size(216, 32);
            btnSoporte.TabIndex = 0;
            btnSoporte.Text = "Soporte";
            btnSoporte.UseVisualStyleBackColor = false;
            btnSoporte.Click += btnSoporte_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, -2);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 157);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(32, 30, 45);
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Controls.Add(panelsubmenuAcerca);
            panelContenedor.Controls.Add(submenuSoporte);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(220, 35);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1064, 577);
            panelContenedor.TabIndex = 3;
            panelContenedor.Paint += panelContenedor_Paint_2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(382, 121);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 327);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // panelsubmenuAcerca
            // 
            panelsubmenuAcerca.Controls.Add(btnDesarrollado);
            panelsubmenuAcerca.Controls.Add(panel15);
            panelsubmenuAcerca.Location = new Point(0, 317);
            panelsubmenuAcerca.Margin = new Padding(4, 3, 4, 3);
            panelsubmenuAcerca.Name = "panelsubmenuAcerca";
            panelsubmenuAcerca.Size = new Size(200, 100);
            panelsubmenuAcerca.TabIndex = 3;
            panelsubmenuAcerca.Visible = false;
            // 
            // btnDesarrollado
            // 
            btnDesarrollado.BackColor = Color.FromArgb(11, 7, 17);
            btnDesarrollado.FlatAppearance.BorderSize = 0;
            btnDesarrollado.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnDesarrollado.FlatStyle = FlatStyle.Flat;
            btnDesarrollado.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDesarrollado.ForeColor = Color.White;
            btnDesarrollado.Image = (Image)resources.GetObject("btnDesarrollado.Image");
            btnDesarrollado.ImageAlign = ContentAlignment.MiddleLeft;
            btnDesarrollado.Location = new Point(10, 3);
            btnDesarrollado.Margin = new Padding(4, 3, 4, 3);
            btnDesarrollado.Name = "btnDesarrollado";
            btnDesarrollado.Size = new Size(187, 32);
            btnDesarrollado.TabIndex = 0;
            btnDesarrollado.Text = " Hecho por";
            btnDesarrollado.UseVisualStyleBackColor = false;
            btnDesarrollado.Click += btnDesarrollado_Click;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(235, 5, 75);
            panel15.Location = new Point(4, 3);
            panel15.Margin = new Padding(4, 3, 4, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(10, 32);
            panel15.TabIndex = 4;
            // 
            // submenuSoporte
            // 
            submenuSoporte.Controls.Add(btnAMPeliculas);
            submenuSoporte.Controls.Add(panel5);
            submenuSoporte.Controls.Add(btnPeliculas);
            submenuSoporte.Controls.Add(panel8);
            submenuSoporte.Location = new Point(4, 155);
            submenuSoporte.Margin = new Padding(4, 3, 4, 3);
            submenuSoporte.Name = "submenuSoporte";
            submenuSoporte.Size = new Size(200, 157);
            submenuSoporte.TabIndex = 1;
            submenuSoporte.Visible = false;
            // 
            // btnAMPeliculas
            // 
            btnAMPeliculas.BackColor = Color.FromArgb(11, 7, 17);
            btnAMPeliculas.FlatAppearance.BorderSize = 0;
            btnAMPeliculas.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnAMPeliculas.FlatStyle = FlatStyle.Flat;
            btnAMPeliculas.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAMPeliculas.ForeColor = Color.White;
            btnAMPeliculas.Image = (Image)resources.GetObject("btnAMPeliculas.Image");
            btnAMPeliculas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAMPeliculas.Location = new Point(6, 40);
            btnAMPeliculas.Margin = new Padding(4, 3, 4, 3);
            btnAMPeliculas.Name = "btnAMPeliculas";
            btnAMPeliculas.Size = new Size(191, 32);
            btnAMPeliculas.TabIndex = 1;
            btnAMPeliculas.Text = "        AM Peliculas";
            btnAMPeliculas.UseVisualStyleBackColor = false;
            btnAMPeliculas.Click += btnCliente_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(235, 5, 75);
            panel5.Location = new Point(0, 40);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 32);
            panel5.TabIndex = 9;
            // 
            // btnPeliculas
            // 
            btnPeliculas.BackColor = Color.FromArgb(11, 7, 17);
            btnPeliculas.FlatAppearance.BorderSize = 0;
            btnPeliculas.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnPeliculas.FlatStyle = FlatStyle.Flat;
            btnPeliculas.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPeliculas.ForeColor = Color.White;
            btnPeliculas.Image = (Image)resources.GetObject("btnPeliculas.Image");
            btnPeliculas.ImageAlign = ContentAlignment.MiddleLeft;
            btnPeliculas.Location = new Point(6, 2);
            btnPeliculas.Margin = new Padding(4, 3, 4, 3);
            btnPeliculas.Name = "btnPeliculas";
            btnPeliculas.Size = new Size(191, 32);
            btnPeliculas.TabIndex = 0;
            btnPeliculas.Text = "Peliculas";
            btnPeliculas.UseVisualStyleBackColor = false;
            btnPeliculas.Click += btnPeliculas_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(235, 5, 75);
            panel8.Location = new Point(0, 2);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 32);
            panel8.TabIndex = 6;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 47, 66);
            ClientSize = new Size(1284, 612);
            Controls.Add(panelContenedor);
            Controls.Add(menuVertical);
            Controls.Add(barraTitulo);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPrincipal";
            Text = "CINE TUP";
            barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bntSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelsubmenuAcerca.ResumeLayout(false);
            submenuSoporte.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSoporte;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTransaccion;
        private System.Windows.Forms.PictureBox bntSalir;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel submenuSoporte;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelsubmenuAcerca;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnDesarrollado;
        private System.Windows.Forms.Button btnAMPeliculas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

