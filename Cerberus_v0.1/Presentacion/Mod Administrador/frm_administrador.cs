using Control.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Negocio.Funciones_estudiantes;
using Presentacion.Mod_Usuario;

namespace Presentacion.Mod_Administrador
{
    public partial class frm_administrador : Form
    {

        public frm_administrador()
        {
            InitializeComponent();
            lbl_nombre_u.Text = Cls_Cache.str_nombre + " " + Cls_Cache.str_apellido;
            lbl_correo_u.Text = Cls_Cache.str_correo;
            lbl_rol_u.Text = Cls_Cache.str_rol;
            if (Cls_Cache.str_rol == "Administrador")
            {
                btn_config.Visible = true;
                btn_personal.Visible = true;
                btn_home.Visible = true;
                fnt_home();
                fnt_abrir_formulario<frm_home>();
            }
            if (Cls_Cache.str_rol == "Usuario")
            {
                btn_config.Visible = false;
                btn_ingreso.Visible = true;
                fnt_ingreso();
                fnt_abrir_formulario<Frm_usuario>();
                //this.WindowState = FormWindowState.Maximized;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Cerrar la Sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void fnt_bordes()
        {
            int borderRadius = 10; // Define el radio de las esquinas redondeadas
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); // Esquina superior izquierda
            path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90); // Esquina superior derecha
            path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90); // Esquina inferior derecha
            path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90); // Esquina inferior izquierda

            this.Region = new System.Drawing.Region(path);
        }

        private void frm_administrador_Load(object sender, EventArgs e)
        {
            fnt_bordes();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        //Mover la Ventana 
        [DllImport("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nleftRec, int ntopRec, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void horafecha_Tick_1(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_sesion.Height;
            pnl_nav.Top = btn_sesion.Top;
            btn_sesion.BackColor = Color.FromArgb(46, 51, 73);

            if (MessageBox.Show("Seguro que desea Cerrar la Sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void fnt_abrir_formulario<miform>() where miform : Form, new()
        {
            Form formulario;
            formulario = pnl_principal.Controls.OfType<miform>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new miform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                pnl_principal.Controls.Add(formulario);
                pnl_principal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.Dock = DockStyle.Fill;
            }
            else
            {
                formulario.BringToFront();
            }

        }
        void fnt_home()
        {
            lbl_pag.Text = "Home";
            pnl_nav.Height = btn_home.Height;
            pnl_nav.Top = btn_home.Top;
            pnl_nav.Left = btn_home.Left;
            btn_home.BackColor = Color.FromArgb(46, 51, 73);
        }
        void fnt_ingreso()
        {
            lbl_pag.Text = "Ingresos";
            pnl_nav.Height = btn_ingreso.Height;
            pnl_nav.Top = btn_ingreso.Top;
            pnl_nav.Left = btn_ingreso.Left;
            btn_ingreso.BackColor = Color.FromArgb(46, 51, 73);
        }
        void fnt_config()
        {
            lbl_pag.Text = "Configuracion";

        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            fnt_home();
            fnt_abrir_formulario<frm_home>();


        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            lbl_pag.Text = "Personal";
            pnl_nav.Height = btn_personal.Height;
            pnl_nav.Top = btn_personal.Top;
            btn_personal.BackColor = Color.FromArgb(46, 51, 73);
            fnt_abrir_formulario<frm_personal>();
        }

        private void btn_home_Leave(object sender, EventArgs e)
        {
            btn_home.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_personal_Leave(object sender, EventArgs e)
        {
            btn_personal.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_sesion_Leave(object sender, EventArgs e)
        {
            btn_sesion.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            fnt_config();
            fnt_abrir_formulario<Frm_Rusuario>();
        }
    }
}
