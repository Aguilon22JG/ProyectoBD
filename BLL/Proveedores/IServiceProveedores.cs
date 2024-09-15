using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Empleados
{
    internal interface IServiceProveedores
    {
        IEnumerable<dynamic> ListarProveedores();
        string NuevoProveedor(string nombre, string contacto, string tel, string email, string direc);
        string ActualizaProveedor(string id, string nombre, string contacto, string tel, string email, string direc);
    }
}
