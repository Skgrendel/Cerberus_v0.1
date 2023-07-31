using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Mod_Inicio
{
    public partial class Frm_inicio : Form
    {
        public Frm_inicio()
        {
            InitializeComponent();
        }

        private void tim_bar_Tick(object sender, EventArgs e)
        {
            tim_bar.Enabled = true;
            bar_ini.Increment(2);
            if (bar_ini.Value == 110)
            {
                tim_bar.Enabled = false;
                Frm_login inicio = new Frm_login();
                inicio.Show();
                this.Hide();

            }
        }

        private void Frm_inicio_Load(object sender, EventArgs e)
        {
            int borderRadius = 15; // Define el radio de las esquinas redondeadas

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); // Esquina superior izquierda
            path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90); // Esquina superior derecha
            path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90); // Esquina inferior derecha
            path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90); // Esquina inferior izquierda

            this.Region = new System.Drawing.Region(path);
        }
    }
}
