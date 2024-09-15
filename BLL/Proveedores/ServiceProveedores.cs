using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Empleados;

namespace BLL.Empleados
{
    public class ServiceProveedores:IServiceProveedores
    {
        private readonly RepositoryProveedores _proveedoresDAL = new RepositoryProveedores();
        public IEnumerable<dynamic> ListarProveedores()
        {
            return _proveedoresDAL.GetProveedores();
        }
        public string NuevoProveedor(string nombre, string contacto, string tel, string email, string direc)
        {
            string resultado = "";
            try
            {
                _proveedoresDAL.Agregar(nombre, contacto, tel, email, direc);
                resultado = "Se agrego al nuevo proveedor: " + nombre;
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;
        }
        public string ActualizaProveedor(string id, string nombre, string contacto, string tel, string email, string direc)
        {
            string resultado = "";
            try
            {
                if (id != null && id != "")
                {
                    _proveedoresDAL.Actualiza(id, nombre, contacto, tel, email, direc);
                    resultado = "Se actualizo al proveedor con codigo: " + id;
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
