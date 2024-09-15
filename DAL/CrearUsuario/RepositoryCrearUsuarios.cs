using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CrearUsuario
{
    public class RepositoryCrearUsuarios:IRepositoryCrearUsuarios
    {
        private readonly IDbConnection _conexion = new ConexionBD().Cadena();
        public IEnumerable<dynamic> GetUsuariosCreados()
        {
            using (var connection = _conexion)
            {
                connection.Open();
                return connection.Query<dynamic>("SELECT Usuarios.Id_Usuario AS ID, Usuarios.Usuario AS Usuario, Usuarios.Contrasena AS Contrasena, Usuarios.Id_Rol AS 'ID rol', Roles.Nombre_Rol AS 'Nombre rol' FROM Usuarios JOIN Roles ON Usuarios.Id_Rol = Roles.Id_Rol;");

            }
        }
        public void Agregar(string usuario, string contrasena, string rol)
        {
            using (var connection = _conexion)
            {
                var sql = "INSERT INTO Usuarios (Usuario, Contrasena, Id_Rol) VALUES (@Usuario, HASHBYTES('SHA2_256', @Contrasena), @Id_Rol)";
                connection.Execute(sql, new { Usuario = usuario, Contrasena = contrasena, Id_Rol = rol});
            }
        }
        public string Actualiza(string id, string usuario, string contrasena, string rol)
        {
            using (var connection = _conexion)
            {
                var sql = "UPDATE Usuarios SET Usuario=@Usuario, Contrasena=HASHBYTES('SHA2_256', @Contrasena), Id_Rol=@Id_Rol WHERE Id_Usuario=@Id_Usuario";
                connection.Execute(sql, new { Id_Usuario=id ,Usuario = usuario, Contrasena = contrasena, Id_Rol = rol });

                return "Se actualizo la informacion";
            }
        }
    }
}
