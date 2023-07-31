using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modulo_usuario
{
    public class Cls_funciones_u
    {
        #region Variables
        private DataTable dts;
        private string mensaje;
        private string id;
        #endregion
        #region Funciones
        #region mostrar tabla de Usuario
        public void ver_tabla()
        {

            Cls_conexion ob_con = new Cls_conexion();
            ob_con.fnt_conectar();
            string consulta = "select tbl_usuarios.PKUsuario as 'Usuario',tbl_usuarios.Contraseña as 'Contraseña',tbl_rol.nombre as 'Rol',tbl_estado.nombre as 'Estado',tbl_usuarios.Identificacion as 'Identificacion',tbl_usuarios.Nombre as 'Nombres',tbl_usuarios.Apellido as 'Apellidos',tbl_usuarios.Contacto as 'Contacto',tbl_usuarios.Correo as 'Correo' from tbl_usuarios,tbl_rol,tbl_estado  where tbl_rol.PKCodigo=tbl_usuarios.FKCodigo_tbl_rol and tbl_estado.PKCodigo=tbl_usuarios.FKCodigo_tbl_estado";
            MySqlCommand cmd = new MySqlCommand(consulta, ob_con.conexion);
            dts = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, ob_con.conexion);
            da.Fill(dts);
            ob_con.fnt_Desconectar();
        }
        #endregion
        #region Crear usuario
        public void Fnt_registrar(string usuario, string contraseña, int rol, int estado, string id, string nombres, string apellidos, string contacto,  string correo)
        {
            Cls_conexion objConexion = new Cls_conexion();
            objConexion.fnt_conectar();
            string Insert = "INSERT INTO tbl_usuarios VALUES (@PKUsuario, @Contraseña, @FKCodigo_tbl_rol, @FKCodigo_tbl_estado, @Identificacion, @Nombre, @Apellido, @Contacto, @Correo)";
            MySqlCommand cmd = new MySqlCommand(Insert, objConexion.conexion);
            cmd.Parameters.AddWithValue("@PKUsuario", usuario);
            cmd.Parameters.AddWithValue("@Contraseña", contraseña);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_rol", rol);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
            cmd.Parameters.AddWithValue("@Identificacion", id);
            cmd.Parameters.AddWithValue("@Nombre", nombres);
            cmd.Parameters.AddWithValue("@Apellido", apellidos);
            cmd.Parameters.AddWithValue("@Contacto", contacto);
            cmd.Parameters.AddWithValue("@Correo", correo); 
            cmd.ExecuteNonQuery();
            objConexion.fnt_Desconectar();
        }
        #endregion
        #region Editar Usuario
        public void fntEditar(string usuario, string contraseña, int rol, int estado, string id, string nombres, string apellidos, string contacto, string correo)
        {
            Cls_conexion objConexionDB = new Cls_conexion();
            objConexionDB.fnt_conectar();
            string comando = "update tbl_usuarios set PKUsuario=@PKUsuario,Contraseña=@contraseña,Identificacion=@Identificacion,Nombre=@Nombre,Apellido=@Apellido,Contacto=@Contacto,Correo=@Correo where Identificacion=@Identificacion";
            MySqlCommand cmd = new MySqlCommand(comando, objConexionDB.conexion);
            cmd.Parameters.AddWithValue("@PKUsuario", usuario);
            cmd.Parameters.AddWithValue("@Contraseña", contraseña);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_rol", rol);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
            cmd.Parameters.AddWithValue("@Identificacion", id);
            cmd.Parameters.AddWithValue("@Nombre", nombres);
            cmd.Parameters.AddWithValue("@Apellido", apellidos);
            cmd.Parameters.AddWithValue("@Contacto", contacto);
            cmd.Parameters.AddWithValue("@Correo", correo);
            cmd.ExecuteNonQuery();
            objConexionDB.fnt_Desconectar();
        }
        #endregion
        #region Eliminar usuario
        public string fnt_eliminar(string id)
        {
            Cls_conexion objConexionDB = new Cls_conexion();
            objConexionDB.fnt_conectar();
            string comando = "delete from tbl_usuarios where Identificacion=@id";
            MySqlCommand cmd = new MySqlCommand(comando, objConexionDB.conexion);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            objConexionDB.fnt_Desconectar();
            mensaje = "Eliminado Con exito";
            return mensaje;
        }
        #endregion 
        #endregion
        #region Getters
        public DataTable getdts() { return this.dts; }
        public string getid() { return this.id; }
        #endregion
    }
}
