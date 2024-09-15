using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Empleados;

namespace BLL.Empleados
{
    public class ServiceClientes:IServiceClientes
    {
        private readonly RepositoryClientes _ClientesDAL = new RepositoryClientes();
        public IEnumerable<dynamic> ListarClientes()
        {
            return _ClientesDAL.GetClientes();
        }
        public string NuevoCliente(string nombre, string nit, string tel, string email, string direc)
        {
            string resultado = "";
            try
            {
                _ClientesDAL.Agregar(nombre, nit, tel, email, direc);
                resultado = "Se agrego al nuevo Cliente: " + nombre;
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;
        }
        public string ActualizaCliente(string id, string nombre, string nit, string tel, string email, string direc)
        {
            string resultado = "";
            try
            {
                if (id != null && id != "")
                {
                    _ClientesDAL.Actualiza(id, nombre, nit, tel, email, direc);
                    resultado = "Se actualizo al Cliente con codigo: " + id;
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
