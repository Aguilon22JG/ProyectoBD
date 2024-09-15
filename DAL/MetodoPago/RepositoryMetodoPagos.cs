using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MetodoPagos
{
    public class RepositoryMetodoPagos:IRepositoryMetodoPagos
    {
        private readonly IDbConnection _conexion = new ConexionBD().Cadena();
        public IEnumerable<dynamic> GetMetodoPagos()
        {
            using (var connection = _conexion)
            {
                connection.Open();
                return connection.Query<dynamic>("SELECT * FROM Medio_De_Pago");

            }
        }
        public void Agregar(string tipo, string nombretitular, string estado)
        {
            using (var connection = _conexion)
            {
                var sql = "INSERT INTO Medio_De_Pago (Tipo_MedioPago, Nombre_Titular_MedioPago, Estado) VALUES (@Tipo_MedioPago, @Nombre_Titular_MedioPago, @Estado)";
                connection.Execute(sql, new { Tipo_MedioPago = tipo, Nombre_Titular_MedioPago = nombretitular, Estado = estado});
            }
        }
        public string Actualiza(string id, string tipo, string nombretitular, string estado)
        {
            using (var connection = _conexion)
            {
                var sql = "UPDATE MetodoPagos SET Tipo_MedioPago=@Tipo_MedioPago, Nombre_Titular_MedioPago=@Nombre_Titular_MedioPago, Estado=@Estado WHERE Id_Rol=@Id_Rol";
                connection.Execute(sql, new { Id_Rol = id, Tipo_MedioPago = tipo, Nombre_Titular_MedioPago = nombretitular, Estado = estado });

                return "Se actualizo la informacion";
            }
        }
    }
}
