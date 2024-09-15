using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Empleados
{
    internal interface IRepositoryClientes
    {
        IEnumerable<dynamic> GetClientes();
        void Agregar(string nombre, string nit, string tel, string email, string direc);
        string Actualiza(string id, string nombre, string nit, string tel, string email, string direc);
    }
}
