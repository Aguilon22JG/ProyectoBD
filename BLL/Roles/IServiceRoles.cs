using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Roles
{
    internal interface IServiceRoles
    {
        IEnumerable<dynamic> ListarRoles();
        string NuevoRol(string nombre, string nivel, string estado);
        string ActualizaRol(string id, string nombre, string nivel, string estado);
    }
}
