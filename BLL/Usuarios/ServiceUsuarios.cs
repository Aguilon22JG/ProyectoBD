using DAL.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Usuarios
{
    public class ServiceUsuarios:IServiceUsuarios
    {
        private readonly IRepositoryUsuarios _usuariosDAL;
        public ServiceUsuarios(IRepositoryUsuarios repositoryUsuarios)
        {
            _usuariosDAL = repositoryUsuarios;
        }
        public bool autenticar(string usuario, string contrasena)
        {
            return _usuariosDAL.Login(usuario, contrasena);
        }
    }
}
