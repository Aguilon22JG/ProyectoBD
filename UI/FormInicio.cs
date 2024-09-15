using BLL.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormInicio : Form
    {
        private readonly IServiceUsuarios _serviceUsuarios;
        public FormInicio(IServiceUsuarios serviceUsuarios)
        {
            InitializeComponent();
            _serviceUsuarios = serviceUsuarios;
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contrasena = textBox2.Text;

            bool isAuthenticated = _serviceUsuarios.autenticar(usuario, contrasena);

            if (isAuthenticated)
            {
                MessageBox.Show("Login exitoso!");
                // Abre el formulario principal o el siguiente paso en la aplicación
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
