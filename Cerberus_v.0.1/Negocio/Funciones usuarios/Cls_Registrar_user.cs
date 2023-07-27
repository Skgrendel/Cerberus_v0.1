using Datos.Modulo_estudiantes;
using Datos.Modulo_usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Funciones_usuarios
{
    public class Cls_Registrar_user
    {
        #region Variables
        private string strMensaje;
        #endregion
        #region Registrar
        public void Registrar_e(string usuario, string contraseña, int rol, int estado, string id, string nombres, string apellidos, string contacto, string correo)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidos) || string.IsNullOrEmpty(contacto) || string.IsNullOrEmpty(correo))
            {
                this.strMensaje = "DEBE INGRESAR LA INFORMACIÓN REQUERIDA";
            }
            else
            {
                Cls_funciones_u oRegistrar = new Cls_funciones_u();
                oRegistrar.Fnt_registrar( usuario,contraseña, rol, estado,  id,  nombres,  apellidos,  contacto, correo);
                this.strMensaje = "USUARIO REGISTRADO CON ÉXITO";
            }
        }
        #endregion
        #region getters
        public string getMensaje() { return this.strMensaje; }
        #endregion
    }
}
