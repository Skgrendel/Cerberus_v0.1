using Control.Cache;
using Negocio.Funciones_estudiantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Mod_Usuario
{

    public partial class Frm_usuario : Form
    {
        private int counter = 0;
        string msn = "";
        Cls_funciones oFunciones = new Cls_funciones();
        public Frm_usuario()
        {
            InitializeComponent();
            txt_documento.Focus();
        }
        private void fnt_validar_existencia()
        {

            oFunciones.fnt_validar_existencia(txt_documento.Text);
        }
        private void fnt_validar_primer_registro()
        {

            oFunciones.consultar_primer_registro(Cls_Cache.str_pkusuario, txt_documento.Text);
        }
        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_documento.MaxLength = 10;
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_documento.Text))
            {

                msn = "Debe ingresar la información requerida";
                lbl_mensaje.Text = msn;
                lbl_mensaje.Visible = true;
            }
            else
            {
                fnt_validar_existencia();
                if (oFunciones.getValidar_e())
                {
                    lbl_mensaje.Visible = false;
                    fnt_ingresar();
                }
                else
                {
                    msn = "Estudiante No Registrado en Sistema";
                    lbl_mensaje.Visible = true;
                    lbl_mensaje.Text = msn;
                    timer_star();
                }
            }


        }
        private void fnt_ingresar()
        {
            fnt_validar_primer_registro();
            oFunciones.fnt_consultar_estudiante(txt_documento.Text);
            txt_nombres.Text = oFunciones.getnombres();
            txt_apellidos.Text = oFunciones.getapellidos();
            txt_curso.Text = oFunciones.getcurso();
            txt_grupo.Text = oFunciones.getgrupo();
            txt_jornada.Text = oFunciones.getjornada();
            lbl_mensaje.Visible = true;
            lbl_mensaje.Text = oFunciones.getMensaje();

            timer_star();

        }
        private void timer_star()
        {
            counter = 0;
            timerl.Interval = 1000;
            timerl.Enabled = true;
            this.timerl.Tick += new System.EventHandler(this.timerl_Tick);
        }
        private void fnt_limpiar()
        {
            txt_nombres.Clear();
            txt_apellidos.Clear();
            txt_curso.Clear();
            txt_grupo.Clear();
            txt_jornada.Clear();
            txt_documento.Clear();
            lbl_mensaje.Text = "";
            txt_documento.Focus();

        }
        private void timerl_Tick(object sender, EventArgs e)
        {
            if (counter >= 4)
            {
                timerl.Enabled = false;
                counter = 0;
                timerl.Stop();
                fnt_limpiar();
            }
            else
            {
                counter = counter + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fnt_limpiar();
        }

        private void txt_documento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fnt_validar_existencia();


                if (oFunciones.getValidar_e())
                {

                    lbl_mensaje.Visible = false;
                    fnt_ingresar();



                }
                else
                {
                    msn = "Estudiante No Registrado en Sistema";
                    lbl_mensaje.Visible = true;
                    lbl_mensaje.Text = msn;
                    timer_star();
                }

            }
        }
    }
}
