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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void btListarClientes_Click(object sender, EventArgs e)
        {
            var logica = new ServiceClientes();
            var datos = logica.ListarClientes();
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }

        private void btGrabarCliente_Click(object sender, EventArgs e)
        {
            var logica = new ServiceClientes();
            string resultado;
            resultado = logica.NuevoCliente(txtNombreCliente.Text, txtNitCliente.Text, txtTelefonoCliente.Text, txtEmailCliente.Text, txtDireccionCliente.Text);
            MessageBox.Show(resultado);
        }

        private void btActualizarCliente_Click(object sender, EventArgs e)
        {
            var logica = new ServiceClientes();
            string resultado;
            resultado = logica.ActualizaCliente(labelLugarId.Text, txtNombreCliente.Text, txtNitCliente.Text, txtTelefonoCliente.Text, txtEmailCliente.Text, txtDireccionCliente.Text);
            MessageBox.Show(resultado);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                labelLugarId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombreCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDireccionCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTelefonoCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmailCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNitCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
    }
}
