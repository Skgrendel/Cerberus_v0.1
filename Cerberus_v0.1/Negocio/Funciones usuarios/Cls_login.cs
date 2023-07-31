using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Funciones_usuarios
{
    public class Cls_login
    {
        #region Variables
        private Bitmap Foto;
        Datos.Modulo_login.Cls_login user = new Datos.Modulo_login.Cls_login();
        #endregion
        #region Funciones generales
        public bool fnt_login(string usuario, string contraseña)
        {
            return user.login(usuario, contraseña);

        }
        #endregion
    }
}
