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
    public class RepositoryClientes:IRepositoryClientes
    {
        private readonly IDbConnection _conexion = new ConexionBD().Cadena();
        public IEnumerable<dynamic> GetClientes()
        {
            using (var connection = _conexion)
            {
                connection.Open();
                return connection.Query<dynamic>("SELECT * FROM Clientes");

            }
        }
        public void Agregar(string nombre, string nit, string tel, string email, string direc)
        {
            using (var connection = _conexion)
            {
                var sql = "INSERT INTO Clientes (Nombre_Cliente, Nit_Cliente, Telefono_Cliente, Email_Cliente, Direccion_Facturacion_Cliente) VALUES (@Nombre_Cliente, @Nit_Cliente, @Telefono_Cliente, @Email_Cliente, @Direccion_Facturacion_Cliente)";
                connection.Execute(sql, new { Nombre_Cliente = nombre, Nit_Cliente = nit, Telefono_Cliente = tel, Email_Cliente = email, Direccion_Facturacion_Cliente = direc});
            }
        }
        public string Actualiza(string id, string nombre, string nit, string tel, string email, string direc)
        {
            using (var connection = _conexion)
            { 
                var sql = "UPDATE Clientes SET Nombre_Cliente=@Nombre_Cliente, Nit_Cliente=@Nit_Cliente, Telefono_Cliente=@Telefono_Cliente, Email_Cliente=@Email_Cliente, Direccion_Facturacion_Cliente=@Direccion_Facturacion_Cliente WHERE Id_Cliente=@Id_Cliente";
                connection.Execute(sql, new { Id_Cliente=id, Nombre_Cliente = nombre, Nit_Cliente = nit, Telefono_Cliente = tel, Email_Cliente = email, Direccion_Facturacion_Cliente = direc });

                return "Se actualizo la informacion";
            }
        }
    }
}
