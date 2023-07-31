using Control.Cache;
using Negocio.Funciones_estudiantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Mod_Administrador
{
    public partial class frm_personal : Form
    {
        #region Variables
        Cls_funciones oValidar = new Cls_funciones();
        #endregion
        public frm_personal()
        {
            InitializeComponent();
            RoundCorners(pnl_registrar, 10);
            RoundCorners(pnl_editar, 10);
            RoundCorners(panel1, 10);
            RoundCorners(pnl_eliminar, 10);
            RoundCorners(panel_registro, 10);
            RoundCorners(panel_registro_1, 10);
            Fnt_TipoDocumento();
            Fnt_cursos();
            Fnt_jornadas();
            Fnt_grupos();
            fnt_verTabla();
            pnl_principal.BringToFront();


        }
        #region Funcion Borde redondeado
        private void RoundCorners(Panel panel, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
            int diameter = radius * 2;

            // Crea una región elíptica para definir los bordes redondeados
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90); // Esquina superior izquierda
            path.AddArc(bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90); // Esquina superior derecha
            path.AddArc(bounds.Width - diameter, bounds.Height - diameter, diameter, diameter, 0, 90); // Esquina inferior derecha
            path.AddArc(bounds.X, bounds.Height - diameter, diameter, diameter, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            // Asigna la región al panel
            panel.Region = new Region(path);
        }
        #endregion
        #region Funciones de Carga
        public void Fnt_TipoDocumento()
        {
            Cls_cargar_box oTipoDocumento = new Cls_cargar_box();
            oTipoDocumento.fntCargarDocumento();
            cbx_tipodocumento.ValueMember = "PKCodigo";
            cbx_tipodocumento.DisplayMember = "Nombre";
            cbx_tipodocumento.DataSource = oTipoDocumento.GetTipoDocumento();
        }
        public void Fnt_cursos()
        {
            Cls_cargar_box ocursos = new Cls_cargar_box();
            ocursos.fntCursos();
            cbx_cursos.ValueMember = "PKCodigo";
            cbx_cursos.DisplayMember = "Nombre";
            cbx_cursos.DataSource = ocursos.GetCursos();
        }
        public void Fnt_jornadas()
        {
            Cls_cargar_box ojornadas = new Cls_cargar_box();
            ojornadas.fntjornadas();
            cbx_jornada.ValueMember = "PKCodigo";
            cbx_jornada.DisplayMember = "Nombre";
            cbx_jornada.DataSource = ojornadas.GetJornadas();
        }
        public void Fnt_grupos()
        {
            Cls_cargar_box ogrupos = new Cls_cargar_box();
            ogrupos.fntGrupo();
            cbx_grupo.ValueMember = "PKCodigo";
            cbx_grupo.DisplayMember = "Nombre";
            cbx_grupo.DataSource = ogrupos.GetGrupo();
        }
        private void fnt_validar_registros()
        {

            Cls_funciones oValidar = new Cls_funciones();
            oValidar.fnt_validar(txt_documento.Text);
            oValidar.fnt_validar_existencia(txt_rfid.Text);

        }
        private void fnt_limpiar()
        {
            txt_rfid.Clear();
            txt_documento.Clear();
            txt_nombres.Clear();
            txt_apellidos.Clear();
            txt_contacto.Clear();
            txt_correo.Clear();
            cbx_tipodocumento.SelectedIndex = 0;
            cbx_cursos.SelectedIndex = 0;
            cbx_grupo.SelectedIndex = 0;
            cbx_jornada.SelectedIndex = 0;
            txt_rfid.Focus();
        }

        private void frm_personal_Load(object sender, EventArgs e)
        {
            fnt_verTabla();
            dtg_estudiantes.Columns[9].Visible = false;
        }
        #endregion
        #region Fnt funciones generales
        private void fnt_guardar()
        {
            Cls_funciones oGuardar = new Cls_funciones();
            oGuardar.Registrar_e(txt_rfid.Text, cbx_tipodocumento.SelectedIndex + 1, txt_documento.Text, txt_nombres.Text, txt_apellidos.Text, txt_contacto.Text, txt_correo.Text, cbx_cursos.SelectedIndex + 1, cbx_grupo.SelectedIndex + 1, cbx_jornada.SelectedIndex + 1);
            MessageBox.Show($"{oGuardar.getMensaje()}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void fnt_verTabla()
        {
            Cls_funciones oVerTabla = new Cls_funciones();
            oVerTabla.fnt_ver_tabla();
            dtg_estudiantes.DataSource = oVerTabla.getDts();
        }
        private void fnt_buscar()
        {
            fnt_verTabla();

            if (txt_buscar.Text != "")
            {
                dtg_estudiantes.CurrentCell = null;

                foreach (DataGridViewRow r in dtg_estudiantes.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtg_estudiantes.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txt_buscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                fnt_verTabla();
            }
        }
        private void fnt_editar()
        {
            if (dtg_estudiantes.SelectedRows.Count > 0)
            {
                int fila = dtg_estudiantes.CurrentRow.Index;
                cbx_tipodocumento.Text = Convert.ToString(dtg_estudiantes.Rows[fila].Cells[0].Value);
                txt_documento.Text = Convert.ToString(dtg_estudiantes.Rows[fila].Cells[1].Value);
                txt_nombres.Text = Convert.ToString(dtg_estudiantes.Rows[fila].Cells[2].Value);
                txt_apellidos.Text = Convert.ToString(dtg_estudiantes.Rows[fila].Cells[3].Value);
                txt_contacto.Text = Convert.ToString(dtg_estudiantes.Rows[fila].Cells[4].Value);
                txt_correo.Text = Convert.ToString(dtg_estudiantes.Rows[fila].Cells[5].Value);
                cbx_cursos.Text = Convert.ToString(dtg_estudiantes.Rows[fila].Cells[6].Value);
                cbx_grupo.Text = Convert.ToString(dtg_estudiantes.Rows[fila].Cells[7].Value);
                cbx_jornada.Text = Convert.ToString(dtg_estudiantes.Rows[fila].Cells[8].Value);
                txt_rfid.Text = Convert.ToString(dtg_estudiantes.Rows[fila].Cells[9].Value);
            }

        }
        private void fnt_editar_e()
        {
            int fila = dtg_estudiantes.CurrentRow.Index;
            Cls_funciones oEditar = new Cls_funciones();
            oEditar.Editar_e(Convert.ToString(dtg_estudiantes.Rows[fila].Cells[9].Value), Convert.ToInt16(cbx_tipodocumento.SelectedValue), txt_documento.Text, txt_nombres.Text, txt_apellidos.Text, txt_contacto.Text, txt_correo.Text, Convert.ToInt16(cbx_cursos.SelectedValue), Convert.ToInt16(cbx_grupo.SelectedValue), Convert.ToInt16(cbx_jornada.SelectedValue));
            MessageBox.Show($"{oEditar.getMensaje()}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnl_funciones_2.BringToFront();
            txt_rfid.Enabled = true;
            txt_buscar.Clear();
            fnt_verTabla();
            fnt_limpiar();

        }
        private void fnt_eliminar_e()
        {
            if (dtg_estudiantes.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar este usuario?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cls_funciones oEliminar = new Cls_funciones();
                    oEliminar.fnt_Eliminar(dtg_estudiantes.CurrentRow.Cells[9].Value.ToString());
                    MessageBox.Show("Usuario eliminado con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_buscar.Clear();
                    fnt_verTabla();
                }
            }
        }
        #endregion
        #region Botones
        private void button5_Click(object sender, EventArgs e)
        {
            pnl_principal.BringToFront();
            lbl_funcion.Text = "";
            btn_guardar.Visible = false;
            btn_guardar.Location = new Point(16, 14);
            fnt_limpiar();
        }

        private void btn_regre_Click(object sender, EventArgs e)
        {
            pnl_principal.BringToFront();
            txt_buscar.Clear();
        }



        private void btn_update_Click(object sender, EventArgs e)
        {
            fnt_editar_e();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnl_funciones.BringToFront();
            lbl_funcion.Text = "Editar Estudiantes";
            btn_update.Visible = true;
            btn_update.Location = new Point(16, 63);
            btn_regresar_1.Visible = false;
            btn_6.Visible = true;
            btn_6.Location = new Point(15, 421);
            fnt_editar();
            txt_rfid.Enabled = false;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            pnl_funciones_2.BringToFront();
            txt_rfid.Enabled = true;
            txt_buscar.Clear();
            fnt_limpiar();
            fnt_verTabla();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            pnl_funciones.BringToFront();
            btn_guardar.Visible = true;
            btn_guardar.Location = new Point(16, 63);
            lbl_funcion.Text = "Registro de Estudiantes";
            btn_regresar_1.Visible = true;
            btn_6.Visible = false;

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            pnl_funciones_2.BringToFront();
            label11.Text = "Editar Estudiantes";
            btn_edit.Visible = true;
            btn_delete.Visible = false;
            btn_edit.Location = new Point(16, 63);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            pnl_funciones_2.BringToFront();
            label11.Text = "Eliminar estudiantes";
            btn_edit.Visible = false;
            btn_delete.Visible = true;
            btn_delete.Location = new Point(16, 63);

        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Cls_funciones oValidar = new Cls_funciones();
            oValidar.fnt_validar(txt_documento.Text);
            oValidar.fnt_validar_existencia(txt_rfid.Text);

            if (oValidar.getValidar_e())
            {
                MessageBox.Show("EL CÓDIGO DE INGRESO YA SE ENCUENTRA REGISTRADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (oValidar.getValidar())
                {
                    MessageBox.Show("EL DOCUMENTO DE IDENTIDAD YA SE ENCUENTRA REGISTRADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    fnt_guardar();
                    fnt_limpiar();
                }
            }
        }


        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                fnt_verTabla();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            fnt_buscar();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            fnt_eliminar_e();
        }

        #endregion
    }
}
