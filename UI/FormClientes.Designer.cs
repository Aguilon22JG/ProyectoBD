namespace UI
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelLugarId = new Label();
            labelId = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtDireccionCliente = new TextBox();
            txtEmailCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtNitCliente = new TextBox();
            txtNombreCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btActualizarCliente = new Button();
            btGrabarCliente = new Button();
            btListarClientes = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelLugarId
            // 
            labelLugarId.AutoSize = true;
            labelLugarId.Location = new Point(53, 336);
            labelLugarId.Name = "labelLugarId";
            labelLugarId.Size = new Size(0, 20);
            labelLugarId.TabIndex = 41;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(18, 336);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 20);
            labelId.TabIndex = 40;
            labelId.Text = "Id: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 160);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 39;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 127);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 38;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 94);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 37;
            label3.Text = "Telefono";
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Location = new Point(195, 157);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(289, 27);
            txtDireccionCliente.TabIndex = 36;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(195, 124);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(289, 27);
            txtEmailCliente.TabIndex = 35;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(195, 91);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(289, 27);
            txtTelefonoCliente.TabIndex = 34;
            // 
            // txtNitCliente
            // 
            txtNitCliente.Location = new Point(195, 58);
            txtNitCliente.Name = "txtNitCliente";
            txtNitCliente.Size = new Size(289, 27);
            txtNitCliente.TabIndex = 33;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(195, 25);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(289, 27);
            txtNombreCliente.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 31;
            label2.Text = "Nit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 30;
            label1.Text = "Nombre";
            // 
            // btActualizarCliente
            // 
            btActualizarCliente.Location = new Point(218, 422);
            btActualizarCliente.Name = "btActualizarCliente";
            btActualizarCliente.Size = new Size(94, 29);
            btActualizarCliente.TabIndex = 28;
            btActualizarCliente.Text = "Actualizar";
            btActualizarCliente.UseVisualStyleBackColor = true;
            btActualizarCliente.Click += btActualizarCliente_Click;
            // 
            // btGrabarCliente
            // 
            btGrabarCliente.Location = new Point(118, 422);
            btGrabarCliente.Name = "btGrabarCliente";
            btGrabarCliente.Size = new Size(94, 29);
            btGrabarCliente.TabIndex = 27;
            btGrabarCliente.Text = "Grabar";
            btGrabarCliente.UseVisualStyleBackColor = true;
            btGrabarCliente.Click += btGrabarCliente_Click;
            // 
            // btListarClientes
            // 
            btListarClientes.Location = new Point(18, 422);
            btListarClientes.Name = "btListarClientes";
            btListarClientes.Size = new Size(94, 29);
            btListarClientes.TabIndex = 42;
            btListarClientes.Text = "Listar";
            btListarClientes.UseVisualStyleBackColor = true;
            btListarClientes.Click += btListarClientes_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(504, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(921, 434);
            dataGridView1.TabIndex = 43;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 486);
            Controls.Add(dataGridView1);
            Controls.Add(btListarClientes);
            Controls.Add(labelLugarId);
            Controls.Add(labelId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDireccionCliente);
            Controls.Add(txtEmailCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtNitCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btActualizarCliente);
            Controls.Add(btGrabarCliente);
            Name = "FormClientes";
            Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLugarId;
        private Label labelId;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtDireccionCliente;
        private TextBox txtEmailCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtNitCliente;
        private TextBox txtNombreCliente;
        private Label label2;
        private Label label1;
        private Button btActualizarCliente;
        private Button btGrabarCliente;
        private Button btListarClientes;
        private DataGridView dataGridView1;
    }
}