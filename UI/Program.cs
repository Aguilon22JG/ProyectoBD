using BLL.Usuarios;
using DAL.Usuarios;
using DAL;
using System.Data;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            /*IDbConnection conexionBD = new ConexionBD().Cadena();
            var repositoryUsuarios = new RepositoryUsuarios(conexionBD);
            var serviceUsuarios = new ServiceUsuarios(repositoryUsuarios);

            Application.Run(new FormInicio(serviceUsuarios));*/

            //Aqui modificas el formulario que se va a ejecutar al iniciar la aplicacion
            Application.Run(new FormCreacionUsuario());
        }
    }
}