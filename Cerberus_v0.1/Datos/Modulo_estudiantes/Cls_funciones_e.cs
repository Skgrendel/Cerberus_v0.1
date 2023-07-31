using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modulo_estudiantes
{
    public class Cls_funciones_e
    {
        #region Variables
        private string rfid;
        private int intTipo;
        private int str_usuario;
        private string str_rfid;
        private string str_id;
        public string str_estado_1;
        public string str_registro;
        public string str_estado;
        public string str_mensaje;
        private string strID;
        private DataTable dts;
        private DataTable dt;
        private string strNombres;
        private string strApellidos;
        private string strContacto;
        private string strCorreo;
        private string strCurso;
        private string strGrupo;
        private string strJornada;
        private Bitmap imagen;
        private string mensaje;
        private bool val;
        private bool vals;
        #endregion
        #region crud estudiante

        #region mostrar tabla de estudiante
        public void ver_tabla()
        {

            Cls_conexion ob_con = new Cls_conexion();
            ob_con.fnt_conectar();
            string consulta = "select tbl_tipo.Nombre as 'Tipo Documento',tbl_personas.Identificacion,tbl_personas.Nombres,tbl_personas.Apellidos,tbl_personas.Contacto,tbl_personas.Correo,tbl_curso.Nombre as Curso,tbl_grupo.Nombre as Grupo,tbl_jornadas.Nombre as Jornada,tbl_personas.PKRFID from tbl_personas,tbl_curso,tbl_grupo,tbl_jornadas,tbl_tipo  where tbl_curso.PKCodigo=tbl_personas.FKCodigo_tbl_Curso and tbl_grupo.PKCodigo=tbl_personas.FKCodigo_tbl_grupo and tbl_jornadas.PKCodigo=tbl_personas.FKCodigo_tbl_Jornada and tbl_tipo.PKCodigo=tbl_personas.FKCodigo_tbl_tipo";
            MySqlCommand cmd = new MySqlCommand(consulta, ob_con.conexion);
            dts = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, ob_con.conexion);
            da.Fill(dts);
            ob_con.fnt_Desconectar();
        }
        #endregion
        #region Validar registro de estudiantes 
        public void Validar_Registro_estudiantes(string ID)
        {
            Cls_conexion ob_con = new Cls_conexion();
            ob_con.fnt_conectar();
            string consulta = "SELECT * FROM tbl_personas WHERE Identificacion = @Identificacion";
            MySqlCommand cmd = new MySqlCommand(consulta, ob_con.conexion);
            cmd.Parameters.AddWithValue("Identificacion", ID);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                // El registro ya existe
                vals = true;
            }
            else
            {
                // El registro no existe
                vals = false;
            }
            ob_con.fnt_Desconectar();
        }
        #endregion
        #region registrar estudiantes
        public void Fnt_registrar(string rfid, int tipo, string id, string nombres, string apellidos, string contacto, string correo, int curso, int grupo, int jornada)
        {
            Cls_conexion objConexion = new Cls_conexion();
            objConexion.fnt_conectar();
            string Insert = "INSERT INTO tbl_personas VALUES(@PKRFID,@FKCodigo_tbl_tipo,@Identificacion,@Nombres,@Apellidos,@Contacto,@Correo,@FKCodigo_tbl_Curso,@FKCodigo_tbl_grupo,@FKCodigo_tbl_Jornada)";
            MySqlCommand cmd = new MySqlCommand(Insert, objConexion.conexion);
            cmd.Parameters.AddWithValue("@PKRFID", rfid);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_tipo", tipo);
            cmd.Parameters.AddWithValue("@Identificacion", id);
            cmd.Parameters.AddWithValue("@Nombres", nombres);
            cmd.Parameters.AddWithValue("@Apellidos", apellidos);
            cmd.Parameters.AddWithValue("@Contacto", contacto);
            cmd.Parameters.AddWithValue("@Correo", correo);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_Curso", curso);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_grupo", grupo);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_Jornada", jornada);
            cmd.ExecuteNonQuery();
            objConexion.fnt_Desconectar();
        }
        #endregion
        #region Editar estudiantes
        public void fntEditar(string strRFID, int tipo, string id, string nombres, string apellidos, string contacto, string correo, int curso, int grupo, int jornada)
        {
            Cls_conexion objConexionDB = new Cls_conexion();
            objConexionDB.fnt_conectar();
            string comando = "update tbl_personas set FKCodigo_tbl_tipo=@FKCodigo_tbl_tipo,Identificacion=@Identificacion,Nombres=@Nombres,Apellidos=@Apellidos,Contacto=@Contacto,Correo=@Correo,FKCodigo_tbl_curso=@FKCodigo_tbl_curso,FKCodigo_tbl_grupo=@FKCodigo_tbl_grupo,FKCodigo_tbl_jornada=@FKCodigo_tbl_jornada where PKRFID=@PKRFID";
            MySqlCommand cmd = new MySqlCommand(comando, objConexionDB.conexion);
            cmd.Parameters.AddWithValue("@PKRFID", strRFID);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_tipo", tipo);
            cmd.Parameters.AddWithValue("@Identificacion", id);
            cmd.Parameters.AddWithValue("@Nombres", nombres);
            cmd.Parameters.AddWithValue("@Apellidos", apellidos);
            cmd.Parameters.AddWithValue("@Contacto", contacto);
            cmd.Parameters.AddWithValue("@Correo", correo);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_curso", curso);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_grupo", grupo);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_jornada", jornada);
            cmd.ExecuteNonQuery();
            objConexionDB.fnt_Desconectar();
        }
        #endregion
        #region Funcion eliminar estudiantes 
        public string fnt_eliminar(string rfid)
        {
            Cls_conexion objConexionDB = new Cls_conexion();
            objConexionDB.fnt_conectar();
            string comando = "delete from Tbl_personas where PKRFID= @rfid";
            MySqlCommand cmd = new MySqlCommand(comando, objConexionDB.conexion);
            cmd.Parameters.AddWithValue("@rfid", rfid);
            cmd.ExecuteNonQuery();
            objConexionDB.fnt_Desconectar();
            mensaje = "Eliminado Con exito";
            return mensaje;
        }
        #endregion        
        #region funciones de ingreso
        #region Función Consultar de la ventana de ingresos de personal
        public void fnt_consultar(string id)
        {
            Cls_conexion ob_con = new Cls_conexion();
            ob_con.fnt_conectar();
            String sql = "select tbl_personas.Nombres as 'nombre',tbl_personas.Apellidos as 'apellidos',tbl_curso.nombre as 'curso',tbl_jornadas.nombre as 'jornada',tbl_grupo.nombre as 'grupo' from tbl_personas,tbl_curso,tbl_jornadas,tbl_grupo where tbl_jornadas.PKCodigo = tbl_personas.FKCodigo_tbl_jornada and tbl_curso.PKCodigo =FKCodigo_tbl_Curso and tbl_grupo.PKCodigo = FKCodigo_tbl_grupo and  PKRFID ='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, ob_con.conexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                //MemoryStream ms = new MemoryStream((byte[])reader["Foto"]);

                this.strNombres = reader["nombre"].ToString();
                this.strApellidos = reader["apellidos"].ToString();
                this.strCurso = reader["curso"].ToString();
                this.strGrupo = reader["grupo"].ToString();
                this.strJornada = reader["jornada"].ToString();
                //this.imagen = new Bitmap(ms);
            }
        }
        #endregion
        #region Validar existencia de estudiante
        public void Validar_Existencia_estudiantes(string ID)
        {
            Cls_conexion ob_con = new Cls_conexion();
            ob_con.fnt_conectar();
            string consulta = "SELECT * FROM tbl_personas WHERE PKRFID = @PKRFID";
            MySqlCommand cmd = new MySqlCommand(consulta, ob_con.conexion);
            cmd.Parameters.AddWithValue("PKRFID", ID);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                // El registro ya existe
                val = true;
            }
            else
            {
                // El registro no existe
                val = false;
            }
            ob_con.fnt_Desconectar();
        }
        #endregion
        #region Primera Busqueda
        public void fnt_busqueda_primer_ingreso(string rfid, string id)
        {


            Cls_conexion oConexion = new Cls_conexion();
            oConexion.fnt_conectar();
            string count = "select count(*) as 'cantidad' from tbl_registros where FKRFID_tbl_personas='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(count, oConexion.conexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                this.str_usuario = Convert.ToInt16(reader["cantidad"].ToString());

            }

            if (this.str_usuario == 0)
            {
                str_estado = "1";
                registro_de_ingreso(rfid, id);

                this.str_mensaje = "Asistencia Registrada con Exito";


            }
            if (this.str_usuario > 0)
            {
                consulta_estado(id);
            }
            oConexion.fnt_Desconectar();


        }
        #endregion
        #region Registro de ingreso
        public void registro_de_ingreso(string str_rfid, string str_id)
        {

            Cls_conexion oConexion = new Cls_conexion();
            oConexion.fnt_conectar();
            string registrar = "INSERT INTO tbl_registros(FKUsuario_tbl_usuarios,FKRFID_tbl_personas,Fecha_Ingreso,Hora_Ingreso,FKCodigo_tbl_estado) values ('" + str_rfid + "','" + str_id + "',current_date(),current_time(),'" + str_estado + "')";
            MySqlCommand cmd = new MySqlCommand(registrar, oConexion.conexion);
            cmd.ExecuteNonQuery();
            oConexion.fnt_Desconectar();
        }
        #endregion
        #region consulta_de_estado

        private void consulta_estado(string id)
        {
            Cls_conexion oConexion = new Cls_conexion();
            oConexion.fnt_conectar();
            string count = "select max(PKN_Ingresos) as 'Registro', min(FKCodigo_tbl_estado) as 'estado',FKUsuario_tbl_usuarios as 'usuario' from tbl_registros where FKRFID_tbl_personas='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(count, oConexion.conexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                this.str_registro = reader["Registro"].ToString();
                this.str_estado_1 = reader["estado"].ToString();
                this.str_rfid = reader["usuario"].ToString();
                Console.WriteLine(this.str_estado_1);
            }

            if (this.str_estado_1 == "1")
            {
                str_estado = "2";
                update_ingreso();
                this.str_mensaje = "Salida Registrada con Exito";

            }
            if (this.str_estado_1 == "2")
            {
                str_estado = "1";
                registro_de_ingreso(str_rfid, id);
                this.str_mensaje = "Asistencia Registrada con Exito";
            }
            oConexion.fnt_Desconectar();
        }

        #region Update de ingreso
        public void update_ingreso()
        {
            Cls_conexion oConexion = new Cls_conexion();
            oConexion.fnt_conectar();
            string registrar = "update tbl_registros set Fecha_Salida = current_date(),Hora_Salida = current_time(),FKCodigo_tbl_estado = '" + str_estado + "' where PKN_Ingresos = '" + this.str_registro + "'";
            MySqlCommand cmd = new MySqlCommand(registrar, oConexion.conexion);
            cmd.ExecuteNonQuery();
            oConexion.fnt_Desconectar();
        }

        #endregion
        #endregion
        #endregion
        #endregion
        #region Getters
        public string getrfid() { return this.rfid; }
        public DataTable getdts() { return this.dts; }
        public DataTable getDt() { return this.dt; }
        public bool getval() { return this.val; }
        public bool getvals() { return this.vals; }
        public string getid() { return this.strID; }
        public string getnombres() { return this.strNombres; }
        public string getapellidos() { return this.strApellidos; }
        public string getcontacto() { return this.strContacto; }
        public string getcorreo() { return this.strCorreo; }
        public string getcurso() { return this.strCurso; }
        public string getgrupo() { return this.strGrupo; }
        public string getjornada() { return this.strJornada; }
        public Bitmap getBitmap() { return this.imagen; }
        public string GetMensaje() { return this.mensaje; }
        public int Getstr_usuario() { return this.str_usuario; }
        public string Getstr_mensaje() { return this.str_mensaje; }
        #endregion
    }
}
