using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MetodoPagos
{
    internal interface IServiceMetodoPagos
    {
        IEnumerable<dynamic> ListarMetodoPagos();
        string NuevoMetodoPago(string tipo, string nombretitular, string estado);
        string ActualizaMetodoPago(string id, string tipo, string nombretitular, string estado);
    }
}
