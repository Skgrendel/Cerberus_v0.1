using Negocio.Funciones_estudiantes;
using Negocio.Funciones_usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Mod_Administrador
{
    public partial class Frm_Rusuario : Form
    {

        public Frm_Rusuario()
        {
            InitializeComponent();
            Fnt_grupos();
            fnt_verTabla();

        }

        private void btn_regresar_1_Click(object sender, EventArgs e)
        {
            this.Close();
            txt_usuario.Enabled = true;
            txt_contraseña.Enabled = true;
            txt_documento.Enabled = true;
        }
        public void fnt_limpiar()
        {
            txt_usuario.Text = "";
            txt_contraseña.Text = "";
            cbx_rol.Text = "";
            txt_documento.Text = "";
            txt_nombres.Text = "";
            txt_apellidos.Text = "";
            txt_contacto.Text = "";
            txt_correo.Text = "";
            txt_usuario.Focus();
            txt_usuario.Enabled = true;
            txt_contraseña.Enabled = true;
            txt_documento.Enabled = true;
        }
        private void fnt_verTabla()
        {
            Cls_funciones oVerTabla = new Cls_funciones();
            oVerTabla.fnt_ver_tabla_usuario();
            dtg_usuario.DataSource = oVerTabla.getDtsu();
        }
        public void Fnt_grupos()
        {
            Cls_cargar_box ogrupos = new Cls_cargar_box();
            ogrupos.fntRol();
            cbx_rol.ValueMember = "PKCodigo";
            cbx_rol.DisplayMember = "Nombre";
            cbx_rol.DataSource = ogrupos.GetRol();
        }
        private void fnt_editar()
        {
            if (dtg_usuario.SelectedRows.Count > 0)
            {
                int fila = dtg_usuario.CurrentRow.Index;
                txt_usuario.Text = Convert.ToString(dtg_usuario.Rows[fila].Cells[0].Value);
                txt_contraseña.Text = Convert.ToString(dtg_usuario.Rows[fila].Cells[1].Value);
                cbx_rol.Text = Convert.ToString(dtg_usuario.Rows[fila].Cells[2].Value);
                txt_documento.Text = Convert.ToString(dtg_usuario.Rows[fila].Cells[4].Value);
                txt_nombres.Text = Convert.ToString(dtg_usuario.Rows[fila].Cells[5].Value);
                txt_apellidos.Text = Convert.ToString(dtg_usuario.Rows[fila].Cells[6].Value);
                txt_contacto.Text = Convert.ToString(dtg_usuario.Rows[fila].Cells[7].Value);
                txt_correo.Text = Convert.ToString(dtg_usuario.Rows[fila].Cells[8].Value);
                txt_usuario.Enabled = false;
                txt_contraseña.Enabled = false;
                txt_documento.Enabled = false;
            }

        }
        private void fnt_eliminar_e()
        {
            if (dtg_usuario.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar este usuario?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cls_funciones oEliminar = new Cls_funciones();
                    oEliminar.fnt_Eliminar_u(dtg_usuario.CurrentRow.Cells[4].Value.ToString());
                    MessageBox.Show("Usuario eliminado con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fnt_verTabla();
                }
            }
        }
        private void fnt_editar_u()
        {

            int fila = dtg_usuario.CurrentRow.Index;
            Cls_funciones oEditar = new Cls_funciones();
            oEditar.Editar_u(txt_usuario.Text, txt_contraseña.Text, cbx_rol.SelectedIndex, 3, Convert.ToString(dtg_usuario.Rows[fila].Cells[4].Value), txt_nombres.Text, txt_apellidos.Text, txt_contacto.Text, txt_correo.Text);
            MessageBox.Show($"{oEditar.getMensaje()}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fnt_verTabla();
            fnt_limpiar();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            fnt_eliminar_e();
            fnt_verTabla();
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            fnt_editar_u();
            fnt_limpiar();
            fnt_verTabla();

        }

        private void dtg_usuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fnt_editar();
        }

        private void Frm_Rusuario_Load(object sender, EventArgs e)
        {
            fnt_verTabla();
            dtg_usuario.Columns[1].Visible = false;
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string contrañesa;

            contrañesa = fnt_Convertirsha256(txt_contraseña.Text);
            Cls_Registrar_user oGuardar = new Cls_Registrar_user();
            oGuardar.Registrar_e(txt_usuario.Text, contrañesa, cbx_rol.SelectedIndex + 1, 3, txt_documento.Text, txt_nombres.Text, txt_apellidos.Text, txt_contacto.Text, txt_correo.Text);
            MessageBox.Show($"{oGuardar.getMensaje()}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fnt_verTabla();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            fnt_limpiar();
        }
    }
}
