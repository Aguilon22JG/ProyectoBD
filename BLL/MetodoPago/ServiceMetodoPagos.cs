using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MetodoPagos;

namespace BLL.MetodoPagos
{
    public class ServiceMetodoPagos:IServiceMetodoPagos
    {
        private readonly RepositoryMetodoPagos _MetodoPagosDAL = new RepositoryMetodoPagos();
        public IEnumerable<dynamic> ListarMetodoPagos()
        {
            return _MetodoPagosDAL.GetMetodoPagos();
        }
        public string NuevoMetodoPago(string tipo, string nombretitular, string estado)
        {
            string resultado = "";
            try
            {
                _MetodoPagosDAL.Agregar(tipo, nombretitular, estado);
                resultado = "Se agrego nuevo Metodo de pago: " + tipo;
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;
        }
        public string ActualizaMetodoPago(string id, string tipo, string nombretitular, string estado)
        {
            string resultado = "";
            try
            {
                if (id != null && id != "")
                {
                    _MetodoPagosDAL.Actualiza(id, tipo, nombretitular, estado);
                    resultado = "Se actualizo el medio de pago con codigo: " + id;
                }
                else
                {
                    resultado = "El codigo no existe";
                }
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;
        }
    }
}
