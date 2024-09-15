using BLL.MetodoPagos;
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
    public partial class FormMetodoPagos : Form
    {
        public FormMetodoPagos()
        {
            InitializeComponent();
        }

        private void bttListarMedioPago_Click(object sender, EventArgs e)
        {
            var logica = new ServiceMetodoPagos();
            var datos = logica.ListarMetodoPagos();
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }

        private void bttGrabarMedioPago_Click(object sender, EventArgs e)
        {
            var logica = new ServiceMetodoPagos();
            string resultado;
            resultado = logica.NuevoMetodoPago(txtTipo.Text, txtTitular.Text, txtEstado.Text);
            MessageBox.Show(resultado);
        }

        private void bttActualizarMedioPago_Click(object sender, EventArgs e)
        {
            var logica = new ServiceMetodoPagos();
            string resultado;
            resultado = logica.ActualizaMetodoPago(labelLugarId.Text, txtTipo.Text, txtTitular.Text, txtEstado.Text);
            MessageBox.Show(resultado);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                labelLugarId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTipo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTitular.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEstado.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
