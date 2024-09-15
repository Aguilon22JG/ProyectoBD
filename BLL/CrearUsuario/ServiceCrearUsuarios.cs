using DAL.CrearUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CrearUsuario
{
    public class ServiceCrearUsuarios: IServiceCrearUsuarios
    {
        private readonly RepositoryCrearUsuarios _usuariosDAL = new RepositoryCrearUsuarios();
        public IEnumerable<dynamic> ListarUsuariosCreados()
        {
            return _usuariosDAL.GetUsuariosCreados();
        }
        public string NuevoUsuario(string usuario, string contrasena, string rol)
        {
            string resultado = "";
            try
            {
                _usuariosDAL.Agregar(usuario, contrasena, rol);
                resultado = "Se agrego al nuevo usuario: " + usuario;
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;
        }
        public string ActualizaUsuario(string id, string usuario, string contrasena, string rol)
        {
            string resultado = "";
            try
            {
                if (id != null && id != "")
                {
                    _usuariosDAL.Actualiza(id, usuario, contrasena, rol);
                    resultado = "Se actualizo al usuario con codigo: " + id;
                }
                else
                {
                    resultado = "El codigo no existe";
                }
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;
        }
    }
}
