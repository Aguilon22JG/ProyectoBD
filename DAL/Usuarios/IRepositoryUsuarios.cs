using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Usuarios
{
    public interface IRepositoryUsuarios
    {
        bool Login(string usuario, string contrasena);   
    }
}
