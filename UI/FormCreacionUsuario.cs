using BLL.CrearUsuario;
using BLL.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class FormCreacionUsuario : Form
    {
        public FormCreacionUsuario()
        {
            InitializeComponent();
            ConfigurarComboBox();
        }

        private void buttonListarUsuariosCreados_Click(object sender, EventArgs e)
        {
            var logica = new ServiceCrearUsuarios();
            var datos = logica.ListarUsuariosCreados();
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }

        private void buttonGrabarUsuarioCreado_Click(object sender, EventArgs e)
        {
            var logica = new ServiceCrearUsuarios();
            string resultado;
            resultado = logica.NuevoUsuario(textBox1.Text, textBox2.Text, comboBoxRoles.Text);
            MessageBox.Show(resultado);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                labelLugarId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxRoles.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ConfigurarComboBox()
        {
            comboBoxRoles.Items.Add("1");
            comboBoxRoles.Items.Add("2");
            comboBoxRoles.Items.Add("3");
            comboBoxRoles.Items.Add("4");

            comboBoxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonActualizarUsuario_Click(object sender, EventArgs e)
        {
            var logica = new ServiceCrearUsuarios();
            string resultado;
            resultado = logica.ActualizaUsuario(labelLugarId.Text, textBox1.Text, textBox2.Text, comboBoxRoles.Text);
            MessageBox.Show(resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Cliente = new FormClientes();
            Cliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form MetodoPago = new FormMetodoPagos();
            MetodoPago.Show();
        }
    }
}
