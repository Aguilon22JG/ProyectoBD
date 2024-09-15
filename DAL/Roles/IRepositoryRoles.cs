using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Roles
{
    internal interface IRepositoryRoles
    {
        IEnumerable<dynamic> GetRoles();
        void Agregar(string nombre, string nivel, string estado);
        string Actualiza(string id, string nombre, string nivel, string estado);
    }
}
