using DAL.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Roles;

namespace BLL.Roles
{
    public class ServiceRoles:IServiceRoles
    {
        private readonly RepositoryRoles _rolesDAL = new RepositoryRoles();
        public IEnumerable<dynamic> ListarRoles()
        {
            return _rolesDAL.GetRoles();
        }
        public string NuevoRol(string nombre, string nivel, string estado)
        {
            string resultado = "";
            try
            {
                _rolesDAL.Agregar(nombre, nivel, estado);
                resultado = "Se agrego al nuevo rol: " + nombre;
            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            return resultado;
        }
        public string ActualizaRol(string id, string nombre, string nivel, string estado)
        {
            string resultado = "";
            try
            {
                if (id != null && id != "")
                {
                    _rolesDAL.Actualiza(id, nombre, nivel, estado);
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
