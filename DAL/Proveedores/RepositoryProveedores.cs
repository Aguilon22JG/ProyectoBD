using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Empleados
{
    public class RepositoryProveedores:IRepositoryProveedores
    {
        private readonly IDbConnection _conexion = new ConexionBD().Cadena();
        public IEnumerable<dynamic> GetProveedores()
        {
            using (var connection = _conexion)
            {
                connection.Open();
                return connection.Query<dynamic>("SELECT * FROM Proveedores");

            }
        }
        public void Agregar(string nombre, string contacto, string tel, string email, string direc)
        {
            using (var connection = _conexion)
            {
                var sql = "INSERT INTO Proveedores (Nombre_Proveedor, Nombre_Contacto_Proveedor, Telefono_Proveedor, Email_Proveedor, Direccion_Proveedor) VALUES (@Nombre_Proveedor, @Nombre_Contacto_Proveedor, @Telefono_Proveedor, @Email_Proveedor, @Direccion_Proveedor)";
                connection.Execute(sql, new { Nombre_Proveedor = nombre, Nombre_Contacto_Proveedor = contacto, Telefono_Proveedor = tel, Email_Proveedor = email, Direccion_Proveedor = direc});
            }
        }
        public string Actualiza(string id, string nombre, string contacto, string tel, string email, string direc)
        {
            using (var connection = _conexion)
            {
                var sql = "UPDATE Proveedores SET Nombre_Proveedor=@Nombre_Proveedor, Nombre_Contacto_Proveedor=@Nombre_Contacto_Proveedor, Telefono_Proveedor=@Telefono_Proveedor, Email_Proveedor=@Email_Proveedor, Direccion_Proveedor=@Direccion_Proveedor WHERE Id_Proveedor=@Id_Proveedor";
                connection.Execute(sql, new { Id_Proveedor=id, Nombre_Proveedor = nombre, Nombre_Contacto_Proveedor = contacto, Telefono_Proveedor = tel, Email_Proveedor = email, Direccion_Proveedor = direc });

                return "Se actualizo la informacion";
            }
        }
    }
}
