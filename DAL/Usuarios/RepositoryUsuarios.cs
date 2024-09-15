using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Usuarios
{
    public class RepositoryUsuarios:IRepositoryUsuarios
    {
        private readonly IDbConnection _db;

        public RepositoryUsuarios(IDbConnection db)
        {
            _db = db;
        }

        public bool Login(string usuario, string contrasena)
        {
            string sql = "SELECT COUNT(1) FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = HASHBYTES('SHA2_256', @Contrasena)";
            var result = _db.ExecuteScalar<bool>(sql, new { Usuario = usuario, Contrasena = contrasena });
            return result;
        }
    }
}
