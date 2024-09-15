using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Empleados
{
    internal interface IRepositoryProveedores
    {
        IEnumerable<dynamic> GetProveedores();
        void Agregar(string nombre, string contacto, string tel, string email, string direc);
        string Actualiza(string id, string nombre, string contacto, string tel, string email, string direc);
    }
}
