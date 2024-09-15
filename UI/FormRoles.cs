using BLL.Empleados;
using BLL.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class FormRoles : Form
    {
        public FormRoles()
        {
            InitializeComponent();
        }

        private void FormRoles_Load(object sender, EventArgs e)
        {

        }

        private void buttonListarRoles_Click(object sender, EventArgs e)
        {
            var logica = new ServiceRoles();
            var datos = logica.ListarRoles();
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }

        private void buttonGrabarRoles_Click(object sender, EventArgs e)
        {
            var logica = new ServiceRoles();
            string resultado;
            resultado = logica.NuevoRol(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show(resultado);
        }

        private void buttonActualizarRoles_Click(object sender, EventArgs e)
        {
            var logica = new ServiceRoles();
            string resultado;
            resultado = logica.ActualizaRol(labelLugarId.Text, textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show(resultado);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                labelLugarId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
