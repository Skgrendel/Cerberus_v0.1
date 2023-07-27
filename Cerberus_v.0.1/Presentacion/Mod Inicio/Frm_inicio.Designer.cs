namespace Presentacion.Mod_Inicio
{
    partial class Frm_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_inicio));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bar_ini = new ProgressBar();
            tim_bar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo_blanco;
            pictureBox1.Location = new Point(172, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yeseva One", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(198, 216);
            label1.Name = "label1";
            label1.Size = new Size(253, 40);
            label1.TabIndex = 1;
            label1.Text = "CERBERUS I.S.S";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 345);
            label2.Name = "label2";
            label2.Size = new Size(157, 16);
            label2.TabIndex = 2;
            label2.Text = "Cargando Espere.......";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(540, 345);
            label3.Name = "label3";
            label3.Size = new Size(96, 16);
            label3.TabIndex = 3;
            label3.Text = "Version 0.0.1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(176, 272);
            label4.Name = "label4";
            label4.Size = new Size(275, 16);
            label4.TabIndex = 4;
            label4.Text = " Todos los derechos Reservados 2023";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(274, 288);
            label5.Name = "label5";
            label5.Size = new Size(90, 16);
            label5.TabIndex = 5;
            label5.Text = " © Copyright";
            // 
            // bar_ini
            // 
            bar_ini.BackColor = Color.IndianRed;
            bar_ini.Cursor = Cursors.AppStarting;
            bar_ini.ForeColor = Color.Red;
            bar_ini.Location = new Point(172, 261);
            bar_ini.Maximum = 110;
            bar_ini.Name = "bar_ini";
            bar_ini.Size = new Size(293, 5);
            bar_ini.Style = ProgressBarStyle.Continuous;
            bar_ini.TabIndex = 6;
            // 
            // tim_bar
            // 
            tim_bar.Enabled = true;
            tim_bar.Tick += tim_bar_Tick;
            // 
            // Frm_inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.splash_inicio;
            ClientSize = new Size(637, 364);
            Controls.Add(bar_ini);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_inicio";
            Load += Frm_inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ProgressBar bar_ini;
        private System.Windows.Forms.Timer tim_bar;
    }
}