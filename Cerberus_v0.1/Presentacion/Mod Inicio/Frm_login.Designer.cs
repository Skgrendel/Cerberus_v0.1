namespace Presentacion.Mod_Inicio
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            txt_usuario = new TextBox();
            txt_contraseña = new TextBox();
            btn_entrar = new Button();
            lbl_error = new Label();
            linkLabel1 = new LinkLabel();
            timer2 = new System.Windows.Forms.Timer(components);
            pnl_ip = new Panel();
            lbl_ip = new Label();
            label7 = new Label();
            btn_asignar = new Button();
            txt_configip = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            pictureBox13 = new PictureBox();
            label5 = new Label();
            pictureBox12 = new PictureBox();
            ptb_ip2 = new PictureBox();
            ptb_min = new PictureBox();
            ptb_cerrar = new PictureBox();
            lbl_ip2 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            pnl_ip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_ip2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_cerrar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_blanco;
            pictureBox1.Location = new Point(110, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 87);
            label1.Name = "label1";
            label1.Size = new Size(92, 13);
            label1.TabIndex = 1;
            label1.Text = "CERBERUS I.S.S";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(58, 119);
            label2.Name = "label2";
            label2.Size = new Size(201, 27);
            label2.TabIndex = 2;
            label2.Text = "Inicio de Sesion";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.cerrar_simbolo_de_boton_circular;
            pictureBox2.Location = new Point(285, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.informacion;
            pictureBox3.Location = new Point(242, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 16);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.minimizar;
            pictureBox4.Location = new Point(264, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(16, 16);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.direccion_ip;
            pictureBox5.Location = new Point(6, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.usuario_1_;
            pictureBox6.Location = new Point(23, 197);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.candado;
            pictureBox7.Location = new Point(23, 273);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 32);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(23, 311);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(23, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 180);
            label3.Name = "label3";
            label3.Size = new Size(64, 13);
            label3.TabIndex = 11;
            label3.Text = "USUARIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 256);
            label4.Name = "label4";
            label4.Size = new Size(92, 13);
            label4.TabIndex = 12;
            label4.Text = "CONTRASEÑA";
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = Color.FromArgb(46, 51, 73);
            txt_usuario.BorderStyle = BorderStyle.None;
            txt_usuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.ForeColor = Color.White;
            txt_usuario.Location = new Point(60, 197);
            txt_usuario.MaxLength = 15;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(213, 32);
            txt_usuario.TabIndex = 1;
            // 
            // txt_contraseña
            // 
            txt_contraseña.BackColor = Color.FromArgb(46, 51, 73);
            txt_contraseña.BorderStyle = BorderStyle.None;
            txt_contraseña.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_contraseña.ForeColor = Color.White;
            txt_contraseña.Location = new Point(60, 272);
            txt_contraseña.MaxLength = 15;
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.PasswordChar = '*';
            txt_contraseña.Size = new Size(213, 32);
            txt_contraseña.TabIndex = 2;
            txt_contraseña.KeyUp += txt_contraseña_KeyUp;
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.FromArgb(24, 30, 54);
            btn_entrar.Cursor = Cursors.Hand;
            btn_entrar.FlatAppearance.BorderSize = 0;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_entrar.ForeColor = Color.White;
            btn_entrar.Location = new Point(61, 362);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(201, 36);
            btn_entrar.TabIndex = 3;
            btn_entrar.Text = "INGRESAR";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += button1_Click;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_error.ForeColor = Color.Crimson;
            lbl_error.Location = new Point(23, 326);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(90, 16);
            lbl_error.TabIndex = 16;
            lbl_error.Text = "Mensaje error";
            lbl_error.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(99, 406);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(136, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Olvidaste tu contraseña?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 4000;
            timer2.Tick += timer2_Tick_1;
            // 
            // pnl_ip
            // 
            pnl_ip.BackColor = Color.FromArgb(46, 51, 73);
            pnl_ip.Controls.Add(lbl_ip);
            pnl_ip.Controls.Add(label7);
            pnl_ip.Controls.Add(btn_asignar);
            pnl_ip.Controls.Add(txt_configip);
            pnl_ip.Controls.Add(label6);
            pnl_ip.Controls.Add(panel4);
            pnl_ip.Controls.Add(pictureBox13);
            pnl_ip.Controls.Add(label5);
            pnl_ip.Controls.Add(pictureBox12);
            pnl_ip.Controls.Add(ptb_ip2);
            pnl_ip.Controls.Add(ptb_min);
            pnl_ip.Controls.Add(ptb_cerrar);
            pnl_ip.Location = new Point(0, 0);
            pnl_ip.Name = "pnl_ip";
            pnl_ip.Size = new Size(313, 454);
            pnl_ip.TabIndex = 17;
            pnl_ip.Visible = false;
            // 
            // lbl_ip
            // 
            lbl_ip.AutoSize = true;
            lbl_ip.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ip.ForeColor = Color.White;
            lbl_ip.Location = new Point(128, 431);
            lbl_ip.Name = "lbl_ip";
            lbl_ip.Size = new Size(109, 14);
            lbl_ip.TabIndex = 19;
            lbl_ip.Text = "Configuracion IP";
            lbl_ip.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(4, 432);
            label7.Name = "label7";
            label7.Size = new Size(118, 13);
            label7.TabIndex = 18;
            label7.Text = "Direcion IP Actual:";
            // 
            // btn_asignar
            // 
            btn_asignar.BackColor = Color.FromArgb(24, 30, 54);
            btn_asignar.Cursor = Cursors.Hand;
            btn_asignar.FlatAppearance.BorderSize = 0;
            btn_asignar.FlatStyle = FlatStyle.Flat;
            btn_asignar.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_asignar.ForeColor = Color.White;
            btn_asignar.Location = new Point(58, 367);
            btn_asignar.Name = "btn_asignar";
            btn_asignar.Size = new Size(201, 36);
            btn_asignar.TabIndex = 17;
            btn_asignar.Text = "Asignar";
            btn_asignar.UseVisualStyleBackColor = false;
            btn_asignar.Click += btn_asignar_Click;
            // 
            // txt_configip
            // 
            txt_configip.BackColor = Color.FromArgb(46, 51, 73);
            txt_configip.BorderStyle = BorderStyle.None;
            txt_configip.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_configip.ForeColor = Color.White;
            txt_configip.Location = new Point(66, 238);
            txt_configip.MaxLength = 15;
            txt_configip.Name = "txt_configip";
            txt_configip.Size = new Size(213, 32);
            txt_configip.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 221);
            label6.Name = "label6";
            label6.Size = new Size(105, 13);
            label6.TabIndex = 16;
            label6.Text = "Configuracion IP";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(31, 276);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 1);
            panel4.TabIndex = 15;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.direccion_ip;
            pictureBox13.Location = new Point(29, 236);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(31, 35);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 14;
            pictureBox13.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(15, 119);
            label5.Name = "label5";
            label5.Size = new Size(286, 27);
            label5.TabIndex = 12;
            label5.Text = "Asignar IP del Sistema";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.logo_blanco;
            pictureBox12.Location = new Point(110, 2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(100, 100);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 11;
            pictureBox12.TabStop = false;
            // 
            // ptb_ip2
            // 
            ptb_ip2.Cursor = Cursors.Hand;
            ptb_ip2.Image = (Image)resources.GetObject("ptb_ip2.Image");
            ptb_ip2.Location = new Point(6, 5);
            ptb_ip2.Name = "ptb_ip2";
            ptb_ip2.Size = new Size(16, 16);
            ptb_ip2.SizeMode = PictureBoxSizeMode.Zoom;
            ptb_ip2.TabIndex = 10;
            ptb_ip2.TabStop = false;
            ptb_ip2.Click += ptb_ip2_Click;
            // 
            // ptb_min
            // 
            ptb_min.Cursor = Cursors.Hand;
            ptb_min.Image = Properties.Resources.minimizar;
            ptb_min.Location = new Point(264, 7);
            ptb_min.Name = "ptb_min";
            ptb_min.Size = new Size(16, 16);
            ptb_min.SizeMode = PictureBoxSizeMode.AutoSize;
            ptb_min.TabIndex = 9;
            ptb_min.TabStop = false;
            ptb_min.Click += ptb_min_Click;
            // 
            // ptb_cerrar
            // 
            ptb_cerrar.Cursor = Cursors.Hand;
            ptb_cerrar.Image = Properties.Resources.cerrar_simbolo_de_boton_circular;
            ptb_cerrar.Location = new Point(285, 7);
            ptb_cerrar.Name = "ptb_cerrar";
            ptb_cerrar.Size = new Size(16, 16);
            ptb_cerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            ptb_cerrar.TabIndex = 7;
            ptb_cerrar.TabStop = false;
            ptb_cerrar.Click += ptb_cerrar_Click;
            // 
            // lbl_ip2
            // 
            lbl_ip2.AutoSize = true;
            lbl_ip2.Font = new Font("Corbel Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ip2.ForeColor = Color.White;
            lbl_ip2.Location = new Point(93, 432);
            lbl_ip2.Name = "lbl_ip2";
            lbl_ip2.Size = new Size(86, 14);
            lbl_ip2.TabIndex = 23;
            lbl_ip2.Text = "Configuracion IP";
            lbl_ip2.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Corbel Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(6, 433);
            label9.Name = "label9";
            label9.Size = new Size(87, 13);
            label9.TabIndex = 22;
            label9.Text = "Direcion IP Actual:";
            // 
            // Frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(313, 450);
            Controls.Add(pnl_ip);
            Controls.Add(lbl_ip2);
            Controls.Add(label9);
            Controls.Add(linkLabel1);
            Controls.Add(lbl_error);
            Controls.Add(btn_entrar);
            Controls.Add(txt_contraseña);
            Controls.Add(txt_usuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cerberus I.S.S";
            Load += Frm_login_Load;
            MouseDown += Frm_login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            pnl_ip.ResumeLayout(false);
            pnl_ip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_ip2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private TextBox txt_usuario;
        private TextBox txt_contraseña;
        private Button btn_entrar;
        private Label lbl_error;
        private LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer2;
        private Panel pnl_ip;
        private TextBox txt_configip;
        private Label label6;
        private Panel panel4;
        private PictureBox pictureBox13;
        private Label label5;
        private PictureBox pictureBox12;
        private PictureBox ptb_ip2;
        private PictureBox ptb_min;
        private PictureBox ptb_cerrar;
        private Label lbl_ip;
        private Label label7;
        private Button btn_asignar;
        private Label lbl_ip2;
        private Label label9;
    }
}