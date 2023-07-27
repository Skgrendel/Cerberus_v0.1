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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
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
            pictureBox3.Location = new Point(241, 7);
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
            pictureBox4.Location = new Point(263, 7);
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
            pictureBox5.Visible = false;
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
            btn_entrar.Location = new Point(61, 368);
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
            linkLabel1.Location = new Point(99, 415);
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
            // Frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(308, 450);
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
            Text = "Frm_login";
            Load += Frm_login_Load;
            MouseDown += Frm_login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
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
    }
}