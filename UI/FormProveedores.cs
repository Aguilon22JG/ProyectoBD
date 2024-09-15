using BLL.Empleados;

namespace UI

{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void buttonListarEmpleados_Click(object sender, EventArgs e)
        {
            var logica = new ServiceProveedores();
            var datos = logica.ListarProveedores();
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }

        private void buttonGrabarEmpleado_Click(object sender, EventArgs e)
        {
            var logica = new ServiceProveedores();
            string resultado;
            resultado = logica.NuevoProveedor(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            MessageBox.Show(resultado);
        }

        private void buttonActualizarEmpleados_Click(object sender, EventArgs e)
        {
            var logica = new ServiceProveedores();
            string resultado;
            resultado = logica.ActualizaProveedor(labelLugarId.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
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
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }
    }
}
