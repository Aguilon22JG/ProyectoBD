using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CrearUsuario
{
    internal interface IRepositoryCrearUsuarios
    {
        IEnumerable<dynamic> GetUsuariosCreados();
        void Agregar(string usuario, string contrasena, string rol);
        string Actualiza(string id, string usuario, string contrasena, string rol);
    }
}
