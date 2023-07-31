namespace Presentacion.Mod_Usuario
{
    partial class Frm_usuario
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
            panel1 = new Panel();
            button1 = new Button();
            btn_entrar = new Button();
            panel3 = new Panel();
            lbl_mensaje = new Label();
            txt_documento = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            panel9 = new Panel();
            txt_jornada = new TextBox();
            panel8 = new Panel();
            label1 = new Label();
            txt_grupo = new TextBox();
            panel4 = new Panel();
            txt_curso = new TextBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            panel6 = new Panel();
            label8 = new Label();
            label4 = new Label();
            txt_apellidos = new TextBox();
            txt_nombres = new TextBox();
            label5 = new Label();
            panel7 = new Panel();
            timerl = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_entrar);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txt_documento);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(1080, 720);
            panel1.MinimumSize = new Size(748, 468);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 468);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(481, 78);
            button1.Name = "button1";
            button1.Size = new Size(201, 36);
            button1.TabIndex = 87;
            button1.Text = "LIMPIAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.FromArgb(24, 30, 54);
            btn_entrar.Cursor = Cursors.Hand;
            btn_entrar.FlatAppearance.BorderSize = 0;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_entrar.ForeColor = Color.White;
            btn_entrar.Location = new Point(481, 33);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(201, 36);
            btn_entrar.TabIndex = 86;
            btn_entrar.Text = "INGRESAR";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(24, 30, 54);
            panel3.Controls.Add(lbl_mensaje);
            panel3.Location = new Point(35, 348);
            panel3.Name = "panel3";
            panel3.Size = new Size(680, 108);
            panel3.TabIndex = 85;
            // 
            // lbl_mensaje
            // 
            lbl_mensaje.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_mensaje.AutoSize = true;
            lbl_mensaje.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_mensaje.ForeColor = Color.White;
            lbl_mensaje.Location = new Point(12, 13);
            lbl_mensaje.Name = "lbl_mensaje";
            lbl_mensaje.Size = new Size(91, 30);
            lbl_mensaje.TabIndex = 83;
            lbl_mensaje.Text = "Mensaje";
            lbl_mensaje.Visible = false;
            // 
            // txt_documento
            // 
            txt_documento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_documento.BackColor = Color.FromArgb(46, 51, 73);
            txt_documento.BorderStyle = BorderStyle.None;
            txt_documento.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_documento.ForeColor = Color.White;
            txt_documento.Location = new Point(17, 67);
            txt_documento.MaxLength = 15;
            txt_documento.Name = "txt_documento";
            txt_documento.Size = new Size(314, 47);
            txt_documento.TabIndex = 70;
            txt_documento.KeyPress += txt_documento_KeyPress;
            txt_documento.KeyUp += txt_documento_KeyUp;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 37);
            label2.Name = "label2";
            label2.Size = new Size(345, 27);
            label2.TabIndex = 72;
            label2.Text = "NUMERO DE DOCUMENTO";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.Location = new Point(17, 116);
            panel5.Name = "panel5";
            panel5.Size = new Size(314, 1);
            panel5.TabIndex = 71;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(txt_jornada);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_grupo);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(txt_curso);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_apellidos);
            panel2.Controls.Add(txt_nombres);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel7);
            panel2.Location = new Point(14, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(722, 213);
            panel2.TabIndex = 84;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel9.BackColor = Color.White;
            panel9.Enabled = false;
            panel9.Location = new Point(387, 170);
            panel9.Name = "panel9";
            panel9.Size = new Size(281, 1);
            panel9.TabIndex = 88;
            // 
            // txt_jornada
            // 
            txt_jornada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_jornada.BackColor = Color.FromArgb(46, 51, 73);
            txt_jornada.BorderStyle = BorderStyle.None;
            txt_jornada.Enabled = false;
            txt_jornada.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_jornada.ForeColor = Color.White;
            txt_jornada.Location = new Point(387, 150);
            txt_jornada.MaxLength = 50;
            txt_jornada.Name = "txt_jornada";
            txt_jornada.Size = new Size(281, 18);
            txt_jornada.TabIndex = 87;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel8.BackColor = Color.White;
            panel8.Enabled = false;
            panel8.Location = new Point(387, 118);
            panel8.Name = "panel8";
            panel8.Size = new Size(281, 1);
            panel8.TabIndex = 85;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(389, 129);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 86;
            label1.Text = "JORNADA";
            // 
            // txt_grupo
            // 
            txt_grupo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_grupo.BackColor = Color.FromArgb(46, 51, 73);
            txt_grupo.BorderStyle = BorderStyle.None;
            txt_grupo.Enabled = false;
            txt_grupo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_grupo.ForeColor = Color.White;
            txt_grupo.Location = new Point(387, 98);
            txt_grupo.MaxLength = 50;
            txt_grupo.Name = "txt_grupo";
            txt_grupo.Size = new Size(281, 18);
            txt_grupo.TabIndex = 84;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Enabled = false;
            panel4.Location = new Point(389, 66);
            panel4.Name = "panel4";
            panel4.Size = new Size(281, 1);
            panel4.TabIndex = 83;
            // 
            // txt_curso
            // 
            txt_curso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_curso.BackColor = Color.FromArgb(46, 51, 73);
            txt_curso.BorderStyle = BorderStyle.None;
            txt_curso.Enabled = false;
            txt_curso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_curso.ForeColor = Color.White;
            txt_curso.Location = new Point(389, 48);
            txt_curso.MaxLength = 50;
            txt_curso.Name = "txt_curso";
            txt_curso.Size = new Size(281, 18);
            txt_curso.TabIndex = 82;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.usuario_2_;
            pictureBox1.Location = new Point(-118, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(389, 77);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 81;
            label10.Text = "GRUPO";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.BackColor = Color.White;
            panel6.Enabled = false;
            panel6.Location = new Point(34, 77);
            panel6.Name = "panel6";
            panel6.Size = new Size(281, 1);
            panel6.TabIndex = 74;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(389, 30);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 79;
            label8.Text = "CURSO";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(33, 11);
            label4.Name = "label4";
            label4.Size = new Size(140, 27);
            label4.TabIndex = 75;
            label4.Text = "NOMBRES";
            // 
            // txt_apellidos
            // 
            txt_apellidos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_apellidos.BackColor = Color.FromArgb(46, 51, 73);
            txt_apellidos.BorderStyle = BorderStyle.None;
            txt_apellidos.Enabled = false;
            txt_apellidos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_apellidos.ForeColor = Color.White;
            txt_apellidos.Location = new Point(32, 126);
            txt_apellidos.MaxLength = 50;
            txt_apellidos.Name = "txt_apellidos";
            txt_apellidos.Size = new Size(281, 28);
            txt_apellidos.TabIndex = 76;
            // 
            // txt_nombres
            // 
            txt_nombres.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_nombres.BackColor = Color.FromArgb(46, 51, 73);
            txt_nombres.BorderStyle = BorderStyle.None;
            txt_nombres.Enabled = false;
            txt_nombres.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombres.ForeColor = Color.White;
            txt_nombres.Location = new Point(34, 47);
            txt_nombres.MaxLength = 50;
            txt_nombres.Name = "txt_nombres";
            txt_nombres.Size = new Size(281, 28);
            txt_nombres.TabIndex = 73;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 90);
            label5.Name = "label5";
            label5.Size = new Size(157, 27);
            label5.TabIndex = 78;
            label5.Text = "APELLIDOS";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel7.BackColor = Color.White;
            panel7.Enabled = false;
            panel7.Location = new Point(32, 156);
            panel7.Name = "panel7";
            panel7.Size = new Size(281, 1);
            panel7.TabIndex = 77;
            // 
            // timerl
            // 
            timerl.Interval = 1000;
            timerl.Tick += timerl_Tick;
            // 
            // Frm_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(748, 468);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_mensaje;
        private Label label10;
        private Label label8;
        private TextBox txt_apellidos;
        private Label label5;
        private Panel panel7;
        private Label label4;
        private TextBox txt_documento;
        private Label label2;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_entrar;
        private Button button1;
        private System.Windows.Forms.Timer timerl;
        private Panel panel8;
        private TextBox txt_grupo;
        private Panel panel4;
        private TextBox txt_curso;
        private Panel panel6;
        private TextBox txt_nombres;
        private Panel panel9;
        private TextBox txt_jornada;
        private Label label1;
    }
}