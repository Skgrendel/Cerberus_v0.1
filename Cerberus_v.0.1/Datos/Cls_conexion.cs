using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    
    public class Cls_conexion
    {
        #region Variables
        public MySqlConnection conexion;
        string cadenaconexion;
        #endregion
        #region Conexion Sql Server
        //public SqlConnection con = new SqlConnection("Data Source=DESKTOP-IKED90Q\\SQLEXPRESS;Initial Catalog=dbs_Serverus;Integrated Security=True");
        #endregion
        #region Funciones generales
        public void fnt_conectar()
        {
            #region Conexión Sena
            //conexion = new MySqlConnection();
            ////************* CONEXION Server Sena ******************
            //String servidor = "bjzou8l4stzysh5slytn-mysql.services.clever-cloud.com";
            //String bd = "bjzou8l4stzysh5slytn";
            //String usuario = "ugfoqhuhbu5xyclf";
            //String contraseña = "TvKFzpLsIRNPocHlyy23";
            //String puerto = "3306";
            //cadenaconexion = "server=" + servidor + ";port=" + puerto + ";user id=" + usuario + ";password=" + contraseña + ";database=" + bd + ";";
            //try
            //{
            //    conexion.ConnectionString = cadenaconexion;
            //    conexion.Open();
            //}
            //catch (Exception){}
            #endregion
            #region Conexion Local
            conexion = new MySqlConnection();
            //************* CONEXION LOCAl ******************
            String servidor = "127.0.0.1";
            String bd = "dbs_serverus";
            String usuario = "root";
            String contraseña = "";
            String puerto = "3306";
            cadenaconexion = "server=" + servidor + ";port=" + puerto + ";user id=" + usuario + ";password=" + contraseña + ";database=" + bd + ";";
            try
            {
                conexion.ConnectionString = cadenaconexion;
                conexion.Open();
            }
            catch (Exception) { }
            #endregion
        }
        public void fnt_Desconectar() { conexion.Close(); }
        #endregion
    }
}
