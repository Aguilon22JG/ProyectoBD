using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CrearUsuario
{
    internal interface IServiceCrearUsuarios
    {
        IEnumerable<dynamic> ListarUsuariosCreados();
        string NuevoUsuario(string usuario, string contrasena, string rol);
        string ActualizaUsuario(string id, string usuario, string contrasena, string rol);
    }
}
