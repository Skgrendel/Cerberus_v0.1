namespace Presentacion.Mod_Administrador
{
    partial class frm_home
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
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            lbl_registros = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(13, 279);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 214);
            panel1.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(24, 30, 54);
            panel4.Location = new Point(514, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 250);
            panel4.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(24, 30, 54);
            panel3.Location = new Point(258, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 250);
            panel3.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lbl_registros);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(11, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 250);
            panel2.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 51, 73);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(79, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbl_registros
            // 
            lbl_registros.AutoSize = true;
            lbl_registros.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_registros.Location = new Point(76, 156);
            lbl_registros.Name = "lbl_registros";
            lbl_registros.Size = new Size(135, 40);
            lbl_registros.TabIndex = 2;
            lbl_registros.Text = "conteo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 1;
            label1.Text = "Personal Registrado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.documento;
            pictureBox1.Location = new Point(69, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frm_home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(764, 507);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_home";
            Load += frm_home_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lbl_registros;
        private Button button1;
    }
}