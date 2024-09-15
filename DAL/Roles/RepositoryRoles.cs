using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Roles
{
    public class RepositoryRoles:IRepositoryRoles
    {
        private readonly IDbConnection _conexion = new ConexionBD().Cadena();
        public IEnumerable<dynamic> GetRoles()
        {
            using (var connection = _conexion)
            {
                connection.Open();
                return connection.Query<dynamic>("SELECT * FROM Roles");

            }
        }
        public void Agregar(string nombre, string nivel, string estado)
        {
            using (var connection = _conexion)
            {
                var sql = "INSERT INTO Roles (Nombre_Rol, Nivel_Acceso_Rol, Estado) VALUES (@Nombre_Rol, @Nivel_Acceso_Rol, @Estado)";
                connection.Execute(sql, new { Nombre_Rol = nombre, Nivel_Acceso_Rol = nivel, Estado = estado});
            }
        }
        public string Actualiza(string id, string nombre, string nivel, string estado)
        {
            using (var connection = _conexion)
            {
                var sql = "UPDATE Roles SET Nombre_Rol=@Nombre_Rol, Nivel_Acceso_Rol=@Nivel_Acceso_Rol, Estado=@Estado WHERE Id_Rol=@Id_Rol";
                connection.Execute(sql, new { Id_Rol = id, Nombre_Rol = nombre, Nivel_Acceso_Rol = nivel, Estado = estado });

                return "Se actualizo la informacion";
            }
        }
    }
}
