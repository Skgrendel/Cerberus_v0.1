using System.Drawing;
using Datos;
using MySql.Data.MySqlClient;
using Control;
using Control.Cache;

namespace Datos.Modulo_login
{

    public class Cls_login
    {
        #region Variables
        private Bitmap foto;
        #endregion
        #region Funciones
        public bool login(string usuario, string contraseña)
        {
            Cls_conexion ob_con = new Cls_conexion();
            ob_con.fnt_conectar();
            string validar = "select tbl_rol.Nombre as Rol, tbl_usuarios.Nombre, tbl_usuarios.Apellido, tbl_usuarios.Correo,tbl_usuarios.PKUsuario from tbl_usuarios,tbl_rol where tbl_usuarios.PKUsuario =@usuario and tbl_usuarios.Contraseña =@contraseña and tbl_rol.PKCodigo = tbl_usuarios.FKCodigo_tbl_rol";
            MySqlCommand cmd = new MySqlCommand(validar, ob_con.conexion);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string str_v = reader.GetString(0);

                Cls_Cache.str_nombre= reader.GetString(1);
                Cls_Cache.str_apellido = reader.GetString(2);
                Cls_Cache.str_correo = reader.GetString(3);
                Cls_Cache.str_pkusuario = reader.GetString(4);
                Cls_Cache.str_rol = reader.GetString(0);


                reader.Close();
                ob_con.fnt_Desconectar();

                return true;
            }
            else
            {

                reader.Close();
                ob_con.fnt_Desconectar();

                return false;

            }

        }
        #endregion
    }
}