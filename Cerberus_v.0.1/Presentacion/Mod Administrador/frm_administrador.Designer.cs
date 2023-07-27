namespace Presentacion.Mod_Administrador
{
    partial class frm_administrador
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_administrador));
            pnl_principal = new Panel();
            panel4 = new Panel();
            lbl_hora = new Label();
            pictureBox3 = new PictureBox();
            lbl_fecha = new Label();
            pictureBox2 = new PictureBox();
            horafecha = new System.Windows.Forms.Timer(components);
            lbl_pag = new Label();
            btn_config = new Button();
            pnl_nav = new Panel();
            panel1 = new Panel();
            btn_ingreso = new Button();
            btn_sesion = new Button();
            btn_personal = new Button();
            btn_home = new Button();
            panel2 = new Panel();
            lbl_rol_u = new Label();
            lbl_correo_u = new Label();
            lbl_nombre_u = new Label();
            pictureBox1 = new PictureBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnl_principal
            // 
            pnl_principal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_principal.BackColor = Color.FromArgb(46, 51, 73);
            pnl_principal.Location = new Point(186, 63);
            pnl_principal.Name = "pnl_principal";
            pnl_principal.Size = new Size(764, 507);
            pnl_principal.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbl_hora);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(lbl_fecha);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(186, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(764, 30);
            panel4.TabIndex = 2;
            // 
            // lbl_hora
            // 
            lbl_hora.AutoSize = true;
            lbl_hora.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_hora.ForeColor = Color.White;
            lbl_hora.Location = new Point(576, 4);
            lbl_hora.Name = "lbl_hora";
            lbl_hora.Size = new Size(50, 19);
            lbl_hora.TabIndex = 4;
            lbl_hora.Text = "Hora";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.cerrar_simbolo_de_boton_circular;
            pictureBox3.Location = new Point(740, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 16);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_fecha.ForeColor = Color.White;
            lbl_fecha.Location = new Point(6, 6);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(56, 19);
            lbl_fecha.TabIndex = 3;
            lbl_fecha.Text = "Fecha";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.minimizar;
            pictureBox2.Location = new Point(718, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick_1;
            // 
            // lbl_pag
            // 
            lbl_pag.AutoSize = true;
            lbl_pag.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pag.ForeColor = Color.White;
            lbl_pag.Location = new Point(518, 33);
            lbl_pag.Name = "lbl_pag";
            lbl_pag.Size = new Size(95, 27);
            lbl_pag.TabIndex = 5;
            lbl_pag.Text = "Pagina";
            // 
            // btn_config
            // 
            btn_config.BackColor = Color.FromArgb(24, 30, 54);
            btn_config.Cursor = Cursors.Hand;
            btn_config.FlatAppearance.BorderSize = 0;
            btn_config.FlatStyle = FlatStyle.Flat;
            btn_config.ForeColor = Color.White;
            btn_config.Image = Properties.Resources.equipo;
            btn_config.ImageAlign = ContentAlignment.MiddleLeft;
            btn_config.Location = new Point(834, 34);
            btn_config.Name = "btn_config";
            btn_config.Size = new Size(108, 23);
            btn_config.TabIndex = 6;
            btn_config.Text = "Configuracion";
            btn_config.TextAlign = ContentAlignment.MiddleLeft;
            btn_config.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_config.UseVisualStyleBackColor = false;
            btn_config.Visible = false;
            btn_config.Click += btn_config_Click;
            // 
            // pnl_nav
            // 
            pnl_nav.BackColor = Color.FromArgb(0, 126, 249);
            pnl_nav.Location = new Point(0, 193);
            pnl_nav.Name = "pnl_nav";
            pnl_nav.Size = new Size(3, 100);
            pnl_nav.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(btn_ingreso);
            panel1.Controls.Add(pnl_nav);
            panel1.Controls.Add(btn_sesion);
            panel1.Controls.Add(btn_personal);
            panel1.Controls.Add(btn_home);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 570);
            panel1.TabIndex = 0;
            // 
            // btn_ingreso
            // 
            btn_ingreso.BackColor = Color.FromArgb(24, 30, 54);
            btn_ingreso.Cursor = Cursors.Hand;
            btn_ingreso.Dock = DockStyle.Top;
            btn_ingreso.FlatAppearance.BorderSize = 0;
            btn_ingreso.FlatStyle = FlatStyle.Flat;
            btn_ingreso.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ingreso.ForeColor = Color.White;
            btn_ingreso.Image = Properties.Resources.usuario;
            btn_ingreso.Location = new Point(0, 271);
            btn_ingreso.Name = "btn_ingreso";
            btn_ingreso.Size = new Size(186, 42);
            btn_ingreso.TabIndex = 5;
            btn_ingreso.Text = "Ingreso";
            btn_ingreso.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_ingreso.UseVisualStyleBackColor = false;
            btn_ingreso.Visible = false;
            // 
            // btn_sesion
            // 
            btn_sesion.BackColor = Color.FromArgb(24, 30, 54);
            btn_sesion.Cursor = Cursors.Hand;
            btn_sesion.Dock = DockStyle.Bottom;
            btn_sesion.FlatAppearance.BorderSize = 0;
            btn_sesion.FlatStyle = FlatStyle.Flat;
            btn_sesion.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sesion.ForeColor = Color.White;
            btn_sesion.Image = Properties.Resources.cerrar_sesion;
            btn_sesion.Location = new Point(0, 528);
            btn_sesion.Name = "btn_sesion";
            btn_sesion.Size = new Size(186, 42);
            btn_sesion.TabIndex = 3;
            btn_sesion.Text = "Cerrar Sesion     ";
            btn_sesion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_sesion.UseVisualStyleBackColor = false;
            btn_sesion.Click += button2_Click;
            btn_sesion.Leave += btn_sesion_Leave;
            // 
            // btn_personal
            // 
            btn_personal.BackColor = Color.FromArgb(24, 30, 54);
            btn_personal.Cursor = Cursors.Hand;
            btn_personal.Dock = DockStyle.Top;
            btn_personal.FlatAppearance.BorderSize = 0;
            btn_personal.FlatStyle = FlatStyle.Flat;
            btn_personal.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_personal.ForeColor = Color.White;
            btn_personal.Image = Properties.Resources.usuario;
            btn_personal.Location = new Point(0, 229);
            btn_personal.Name = "btn_personal";
            btn_personal.Size = new Size(186, 42);
            btn_personal.TabIndex = 2;
            btn_personal.Text = "Personal";
            btn_personal.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_personal.UseVisualStyleBackColor = false;
            btn_personal.Visible = false;
            btn_personal.Click += btn_personal_Click;
            btn_personal.Leave += btn_personal_Leave;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(24, 30, 54);
            btn_home.Cursor = Cursors.Hand;
            btn_home.Dock = DockStyle.Top;
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_home.ForeColor = Color.White;
            btn_home.Image = Properties.Resources.home_icon_silhouette_1_;
            btn_home.Location = new Point(0, 187);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(186, 42);
            btn_home.TabIndex = 1;
            btn_home.Text = "Home     ";
            btn_home.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Visible = false;
            btn_home.Click += btn_home_Click;
            btn_home.Leave += btn_home_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_rol_u);
            panel2.Controls.Add(lbl_correo_u);
            panel2.Controls.Add(lbl_nombre_u);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 187);
            panel2.TabIndex = 0;
            // 
            // lbl_rol_u
            // 
            lbl_rol_u.AutoSize = true;
            lbl_rol_u.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_rol_u.ForeColor = Color.White;
            lbl_rol_u.Location = new Point(8, 142);
            lbl_rol_u.Name = "lbl_rol_u";
            lbl_rol_u.Size = new Size(23, 13);
            lbl_rol_u.TabIndex = 3;
            lbl_rol_u.Text = "Rol";
            // 
            // lbl_correo_u
            // 
            lbl_correo_u.AutoSize = true;
            lbl_correo_u.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_correo_u.ForeColor = Color.White;
            lbl_correo_u.Location = new Point(8, 123);
            lbl_correo_u.Name = "lbl_correo_u";
            lbl_correo_u.Size = new Size(44, 13);
            lbl_correo_u.TabIndex = 2;
            lbl_correo_u.Text = "Correo";
            // 
            // lbl_nombre_u
            // 
            lbl_nombre_u.AutoSize = true;
            lbl_nombre_u.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombre_u.ForeColor = Color.White;
            lbl_nombre_u.Location = new Point(8, 102);
            lbl_nombre_u.Name = "lbl_nombre_u";
            lbl_nombre_u.Size = new Size(62, 16);
            lbl_nombre_u.TabIndex = 1;
            lbl_nombre_u.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario_2_;
            pictureBox1.Location = new Point(57, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frm_administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(950, 570);
            Controls.Add(btn_config);
            Controls.Add(lbl_pag);
            Controls.Add(panel4);
            Controls.Add(pnl_principal);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_administrador";
            Load += frm_administrador_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnl_principal;
        private Panel panel4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lbl_fecha;
        private Label lbl_hora;
        private System.Windows.Forms.Timer horafecha;
        private Label lbl_pag;
        private Button btn_config;
        private Panel pnl_nav;
        private Panel panel1;
        private Button btn_sesion;
        private Button btn_personal;
        private Button btn_home;
        private Panel panel2;
        private Label lbl_rol_u;
        private Label lbl_correo_u;
        private Label lbl_nombre_u;
        private PictureBox pictureBox1;
        private Button btn_ingreso;
    }
}