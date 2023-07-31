using System.Data;

namespace Negocio.Funciones_estudiantes
{
    public class Cls_cargar_box
    {
        #region Variables
        private DataTable dtTipoDocumento,cursos,jornadas,grupo,rol;
        private string conteo;
        #endregion
        #region Funciones de Carga
        public void fntCargarDocumento()
        {
            Datos.Modulo_estudiantes.Cls_cargar_box oCargarDocumento = new Datos.Modulo_estudiantes.Cls_cargar_box();
            oCargarDocumento.fnt_CargarDocumento();
            this.dtTipoDocumento = oCargarDocumento.getTipoDocumento();
        }
        public void fntCursos()
        {
            Datos.Modulo_estudiantes.Cls_cargar_box oCargarCurso = new Datos.Modulo_estudiantes.Cls_cargar_box();
            oCargarCurso.fnt_CargarCurso();
            this.cursos = oCargarCurso.getCurso();
        }
        public void fntjornadas()
        {
            Datos.Modulo_estudiantes.Cls_cargar_box oCargarJornadas = new Datos.Modulo_estudiantes.Cls_cargar_box();
            oCargarJornadas.fnt_CargarJornada();
            this.jornadas = oCargarJornadas.getJornada();
        }
        public void fntGrupo()
        {
            Datos.Modulo_estudiantes.Cls_cargar_box oCargarGrupo = new Datos.Modulo_estudiantes.Cls_cargar_box();
            oCargarGrupo.fnt_CargarGrupo();
            this.grupo = oCargarGrupo.getGrupo();
        }
        public void fntRol()
        {
            Datos.Modulo_estudiantes.Cls_cargar_box oCargarRol = new Datos.Modulo_estudiantes.Cls_cargar_box();
            oCargarRol.fnt_CargarRol();
            this.rol = oCargarRol.getRol();
        }
        public void fntConteo() 
        {
            Datos.Modulo_estudiantes.Cls_cargar_box oConteo = new Datos.Modulo_estudiantes.Cls_cargar_box();
            oConteo.fnt_Conteo();
            this.conteo = oConteo.getConteo();
        }
        #endregion
        #region Getters
        public DataTable GetTipoDocumento() { return this.dtTipoDocumento; }
        public DataTable GetCursos() { return this.cursos; }
        public DataTable GetJornadas() { return this.jornadas; }
        public DataTable GetGrupo() { return this.grupo; }
        public DataTable GetRol() { return this.rol; }
        public string getConteo() { return this.conteo; }
        #endregion
    }
}
