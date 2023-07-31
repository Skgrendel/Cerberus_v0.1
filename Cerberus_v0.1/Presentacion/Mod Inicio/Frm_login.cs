using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Control.Cache;
using Presentacion.Mod_Administrador;
using Negocio.Funciones_usuarios;
using System.Diagnostics;
using System.Text;
using System.Security.Cryptography;

namespace Presentacion.Mod_Inicio
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            int borderRadius = 10; // Define el radio de las esquinas redondeadas

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); // Esquina superior izquierda
            path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90); // Esquina superior derecha
            path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90); // Esquina inferior derecha
            path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90); // Esquina inferior izquierda

            this.Region = new System.Drawing.Region(path);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            lbl_ip.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este Sofware Fue Desarrollado por Adso07, estudiante Bryan Andion, Sena Sede MetalMecanica Malambo 2023, todos los derechos Reservados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            fnt_entrar();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacte con su Administrador de Usuarios \n al siguiente Correo: kitsune.solutionsystem@gmail.com", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        //Mover la Ventana 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Frm_login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void fnt_cerrar_sesion(object sender, FormClosedEventArgs e)
        {

            txt_usuario.Text = "";
            txt_contraseña.Text = "";
            lbl_error.Visible = false;
            this.Show();
            txt_usuario.Focus();
        }
        private void fnt_msnError(string msg)
        {
            lbl_error.Text = "" + msg;
            lbl_error.Visible = true;

            // Iniciar temporizador

            timer2.Start();

        }
        public static string fnt_Convertirsha256(string pass)
        {
            StringBuilder Sb = new StringBuilder();
            using (SHA256 hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(pass));
                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }
            return Sb.ToString();
        }
        private void fnt_entrar()
        {
            string contraseña;
            if (txt_usuario.Text != "")
            {
                if (txt_contraseña.Text != "")
                {
                    if (string.IsNullOrEmpty(Cls_Cache.str_ip))
                    {
                        MessageBox.Show("Debe ingresar su configuracion ip Antes de continuar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        Cls_login val = new Cls_login();
                        contraseña = fnt_Convertirsha256(txt_contraseña.Text);
                        var validalogin = val.fnt_login(txt_usuario.Text, contraseña);
                        if (validalogin == true)
                        {
                            if (Cls_Cache.str_rol == "Administrador")
                            {
                                frm_administrador main = new frm_administrador();
                                MessageBox.Show("" + Cls_Cache.str_nombre + " " + Cls_Cache.str_apellido, " Bienvenido a Cerberus I.S.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                main.Show();
                                main.FormClosed += fnt_cerrar_sesion;
                                this.Hide();
                            }

                            if (Cls_Cache.str_rol == "Usuario")
                            {
                                frm_administrador main = new frm_administrador();
                                MessageBox.Show("" + Cls_Cache.str_nombre + " " + Cls_Cache.str_apellido, " Bienvenido a Cerberus I.S.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                main.Show();
                                main.FormClosed += fnt_cerrar_sesion;
                                this.Hide();
                            }


                        }
                        else
                        {
                            fnt_msnError("Su Usuario o Contraseña no son Correctos.\n Intentelo Nuevamente");
                            txt_contraseña.Text = "";
                            txt_contraseña.UseSystemPasswordChar = false;
                            txt_usuario.Focus();
                        }
                    }
                }
                else fnt_msnError("Por favor ingrese su contraseña");

            }
            else fnt_msnError("Por favor ingrese su usuario");

        }

        private void txt_contraseña_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                fnt_entrar();

            }


        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            timer2.Stop();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pnl_ip.Visible = true;
        }

        private void ptb_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            lbl_ip.Visible = false;
        }

        private void ptb_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptb_ip2_Click(object sender, EventArgs e)
        {
            pnl_ip.Visible = false;
        }

        private void btn_asignar_Click(object sender, EventArgs e)
        {
            lbl_ip.Visible = true;
            lbl_ip2.Visible = true;
            lbl_ip.Text = txt_configip.Text;
            Cls_Cache.str_ip = lbl_ip.Text;
            lbl_ip2.Text = Cls_Cache.str_ip;
            txt_configip.Clear();
            txt_configip.Focus();
        }
    }
}
