using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using Datos;
using Datos.Modulo_estudiantes;
using static System.Net.Mime.MediaTypeNames;
using Datos.Modulo_usuario;

namespace Negocio.Funciones_estudiantes
{
    public class Cls_funciones
    {
        #region Variables
        private bool validar;
        private bool validar_e;
        private string strMensaje;
        private string rfid,id;
        private DataTable dts, dtsu;
        private int str_usuario;
        private string nombres;
        private string apellidos;
        private string curso;
        private string grupo;
        private string jornada;
        
       

        #endregion
        #region Funciones Estudiantes
        #region Monstrar Tabla Estudiantes
        public void fnt_ver_tabla()
        {
            Cls_funciones_e oTabla = new Cls_funciones_e();
            oTabla.ver_tabla();

            this.dts = oTabla.getdts();
        }
        #endregion
        #region Validar Registro
        public void fnt_validar(string ID)
        {
           
           Cls_funciones_e ob_con = new Cls_funciones_e();
            ob_con.Validar_Registro_estudiantes(ID);
            validar = ob_con.getvals();
        }
        public void fnt_validar_existencia(string ID)
        {
            Cls_funciones_e ob_con = new Cls_funciones_e();
            ob_con.Validar_Existencia_estudiantes(ID);
            validar_e = ob_con.getval();
        }
        #endregion
        #region Registrar
        public void Registrar_e(string rfid, int tipo, string Id, string nombre, string apellido, string contacto, string correo, int curso, int grupo, int jornada)
        {
            if (string.IsNullOrEmpty(rfid) || string.IsNullOrEmpty(Convert.ToString(tipo)) || string.IsNullOrEmpty(Id) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                this.strMensaje = "DEBE INGRESAR LA INFORMACIÓN REQUERIDA";
            }
            else
            {
               Cls_funciones_e oRegistrar = new Cls_funciones_e();
                oRegistrar.Fnt_registrar(rfid, tipo, Id, nombre, apellido, contacto, correo, curso, grupo, jornada);
                this.strMensaje = "USUARIO REGISTRADO CON ÉXITO";
            }
        }
        #endregion
        #region Editar
        public void Editar_e(string rfid, int tipo, string Id, string nombre, string apellido, string contacto, string correo, int curso, int grupo, int jornada)
        {
            if (string.IsNullOrEmpty(rfid) || string.IsNullOrEmpty(Id) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                this.strMensaje = "DEBE INGRESAR LA INFORMACIÓN SOLICITADA";
            }
            else
            {
                Cls_funciones_e oEditar = new Cls_funciones_e();
               oEditar.fntEditar(rfid, tipo, Id, nombre, apellido, contacto, correo, curso, grupo, jornada);
                strMensaje = "ESTUDIANTE ACTUALIZADO CON EXÍTO";
            }
        }
        #endregion
        #region Eliminar
        
        public string fnt_Eliminar(string rfid)
        {
           Cls_funciones_e oEliminar = new Cls_funciones_e();
            oEliminar.fnt_eliminar(rfid);
            this.rfid = oEliminar.getrfid();
            return this.rfid;
        }
        #endregion
        #region primer registro
        public void consultar_primer_registro(string rfid, string id)
        {
            Cls_funciones_e fnt = new Cls_funciones_e();
            fnt.fnt_busqueda_primer_ingreso(rfid, id);
            str_usuario = fnt.Getstr_usuario();
            strMensaje = fnt.Getstr_mensaje();
        }
        #endregion
        #region Validar Existencia
        public void fnt_validar_e(string ID)
        {
            Cls_funciones_e ob_con = new Cls_funciones_e();
            ob_con.Validar_Existencia_estudiantes(ID);
            validar_e = ob_con.getval();

        }
        #endregion
        #region Consultar Estudiante
        public void fnt_consultar_estudiante(string id)
        {

            if (id == "")
            {
                strMensaje = "Debe Ingresar Su Numero de identidicacion";
            }
            else
            {

               Cls_funciones_e ob_con = new Cls_funciones_e();
                ob_con.fnt_consultar(id);
                this.nombres = ob_con.getnombres();
                this.apellidos = ob_con.getapellidos();
                this.curso = ob_con.getcurso();
                this.grupo = ob_con.getgrupo();
                this.jornada = ob_con.getjornada();
                

            }
        }
        #endregion
        #endregion
        #region Funciones Usuario
        #region Ver tabla
        public void fnt_ver_tabla_usuario()
        {
            Cls_funciones_u oTabla = new Cls_funciones_u();
            oTabla.ver_tabla();

            this.dtsu = oTabla.getdts();
        }
        #endregion
        #region Editar Usuario
       
        public void Editar_u(string usuario, string contraseña, int rol, int estado, string id, string nombres, string apellidos, string contacto, string correo)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidos) || string.IsNullOrEmpty(contacto) || string.IsNullOrEmpty(correo))
            {
                this.strMensaje = "DEBE INGRESAR LA INFORMACIÓN SOLICITADA";
            }
            else
            {
                Cls_funciones_u oEditar = new Cls_funciones_u();
                oEditar.fntEditar(usuario, contraseña, rol, estado, id, nombres, apellidos, contacto, correo);
                strMensaje = "USUARIO ACTUALIZADO CON EXÍTO";
            }
        }
        
        #endregion
        #region Eliminar
        public string fnt_Eliminar_u(string id)
        {
            Cls_funciones_u oEliminar = new Cls_funciones_u();
            oEliminar.fnt_eliminar(id);
            this.id = oEliminar.getid();
            return this.id;
        }
        #endregion
        #endregion
        #region Getters
        public bool getValidar() { return this.validar; }
        public bool getValidar_e() { return this.validar_e; }
        public string getMensaje() { return this.strMensaje; }
        public DataTable getDts() { return this.dts; }
        public DataTable getDtsu() { return this.dtsu; }
        public int Getstr_usuario() { return this.str_usuario; }
        public string getnombres() { return this.nombres; }
        public string getapellidos() { return this.apellidos; }
        public string getcurso() { return this.curso; }
        public string getgrupo() { return this.grupo; }
        public string getjornada() { return this.jornada; }

        #endregion
    }
}
