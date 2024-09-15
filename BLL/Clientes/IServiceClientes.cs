using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Empleados
{
    internal interface IServiceClientes
    {
        IEnumerable<dynamic> ListarClientes();
        string NuevoCliente(string nombre, string nit, string tel, string email, string direc);
        string ActualizaCliente(string id, string nombre, string nit, string tel, string email, string direc);
    }
}
