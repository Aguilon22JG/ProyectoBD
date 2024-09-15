using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MetodoPagos
{
    internal interface IRepositoryMetodoPagos
    {
        IEnumerable<dynamic> GetMetodoPagos();
        void Agregar(string tipo, string nombretitular, string estado);
        string Actualiza(string id, string tipo, string nombretitular, string estado);
    }
}
