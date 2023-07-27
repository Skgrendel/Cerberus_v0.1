using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos.Modulo_estudiantes
{
    public class Cls_cargar_box
    {
        #region Variables
        Cls_conexion objconexion = new Cls_conexion();
        private DataTable TP,CR,JR,GP,RL;
        private string CT;
        #endregion
        #region Funciones Generales
        public void fnt_CargarDocumento()
        {
            Cls_conexion oConexion = new Cls_conexion();
            string consulta = "select PKCodigo,Nombre from tbl_tipo";
            oConexion.fnt_conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, oConexion.conexion);
                TP = new DataTable();
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                data.Fill(TP);
            }
            catch (Exception)
            {
            }
            oConexion.fnt_Desconectar();
        }
        public void fnt_CargarCurso()
        {
            string Sql = "select PKCodigo,Nombre from tbl_curso";
            Cls_conexion oConectar = new Cls_conexion();
            oConectar.fnt_conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, oConectar.conexion);
                CR = new DataTable();
                MySqlDataAdapter objData = new MySqlDataAdapter(comando);
                objData.Fill(CR);
            }
            catch (Exception)
            {
            }
            oConectar.fnt_Desconectar();
        }
        public void fnt_CargarJornada()
        {
            string Sql = "select PKCodigo,Nombre from tbl_jornadas";
            Cls_conexion oConectar = new Cls_conexion();
            oConectar.fnt_conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, oConectar.conexion);
                JR = new DataTable();
                MySqlDataAdapter objData = new MySqlDataAdapter(comando);
                objData.Fill(JR);
            }
            catch (Exception) { }
            oConectar.fnt_Desconectar();
        }
        public void fnt_CargarGrupo()
        {
            string Sql = "select PKCodigo,Nombre from tbl_grupo";
            Cls_conexion objConectar = new Cls_conexion();
            objConectar.fnt_conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, objConectar.conexion);
                GP = new DataTable();
                MySqlDataAdapter objData = new MySqlDataAdapter(comando);
                objData.Fill(GP);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            objConectar.fnt_Desconectar();
        }
        public void fnt_CargarRol()
        {
            string Sql = "select PKCodigo,Nombre from tbl_rol";
            Cls_conexion objConectar = new Cls_conexion();
            objConectar.fnt_conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, objConectar.conexion);
                RL = new DataTable();
                MySqlDataAdapter objData = new MySqlDataAdapter(comando);
                objData.Fill(RL);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            objConectar.fnt_Desconectar();
        }
        public void fnt_Conteo()
        {
            string Sql = "SELECT COUNT(*) FROM tbl_personas";
            Cls_conexion objConectar = new Cls_conexion();
            objConectar.fnt_conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, objConectar.conexion);

                // Obtiene el recuento de registros como entero
                int count = Convert.ToInt32(comando.ExecuteScalar());

                // Convierte el recuento a texto
                this.CT = "" + count;

                // Haz lo que necesites con el valor CT (por ejemplo, mostrarlo en un Label)
                // lbl_registros.Text = CT;

                // Asegúrate de que CT tenga el valor correcto
                Console.WriteLine(CT);
            }
            catch (Exception ex)
            {
                // Manejo de errores (opcional)
                string CT = "Error: " + ex.Message;
                Console.WriteLine(CT);
            }
            finally
            {
                objConectar.fnt_Desconectar();
            }
        }
        #endregion
        #region Getters
        public DataTable getTipoDocumento() { return this.TP; }
        public DataTable getCurso() { return this.CR; }
        public DataTable getJornada() { return this.JR; }
        public DataTable getGrupo() { return this.GP; }
        public DataTable getRol() { return this.RL; }
        public string getConteo() { return this.CT; }
        #endregion
    }
}
