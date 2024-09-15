namespace UI
{
    partial class FormMetodoPagos
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
            bttActualizarMedioPago = new Button();
            bttGrabarMedioPago = new Button();
            bttListarMedioPago = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEstado = new TextBox();
            txtTitular = new TextBox();
            txtTipo = new TextBox();
            labelLugarId = new Label();
            labelId = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bttActualizarMedioPago
            // 
            bttActualizarMedioPago.Location = new Point(328, 184);
            bttActualizarMedioPago.Name = "bttActualizarMedioPago";
            bttActualizarMedioPago.Size = new Size(94, 29);
            bttActualizarMedioPago.TabIndex = 23;
            bttActualizarMedioPago.Text = "Actualizar";
            bttActualizarMedioPago.UseVisualStyleBackColor = true;
            bttActualizarMedioPago.Click += bttActualizarMedioPago_Click;
            // 
            // bttGrabarMedioPago
            // 
            bttGrabarMedioPago.Location = new Point(228, 184);
            bttGrabarMedioPago.Name = "bttGrabarMedioPago";
            bttGrabarMedioPago.Size = new Size(94, 29);
            bttGrabarMedioPago.TabIndex = 22;
            bttGrabarMedioPago.Text = "Grabar";
            bttGrabarMedioPago.UseVisualStyleBackColor = true;
            bttGrabarMedioPago.Click += bttGrabarMedioPago_Click;
            // 
            // bttListarMedioPago
            // 
            bttListarMedioPago.Location = new Point(128, 184);
            bttListarMedioPago.Name = "bttListarMedioPago";
            bttListarMedioPago.Size = new Size(94, 29);
            bttListarMedioPago.TabIndex = 21;
            bttListarMedioPago.Text = "Listar";
            bttListarMedioPago.UseVisualStyleBackColor = true;
            bttListarMedioPago.Click += bttListarMedioPago_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 137);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 20;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 85);
            label2.Name = "label2";
            label2.Size = new Size(114, 40);
            label2.TabIndex = 19;
            label2.Text = "Nombre Titular \r\nMedio Pago";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 52);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 18;
            label1.Text = "Tipo Medio de Pago:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(163, 134);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(259, 27);
            txtEstado.TabIndex = 17;
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(163, 94);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(259, 27);
            txtTitular.TabIndex = 16;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(162, 49);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(259, 27);
            txtTipo.TabIndex = 15;
            // 
            // labelLugarId
            // 
            labelLugarId.AutoSize = true;
            labelLugarId.Location = new Point(46, 9);
            labelLugarId.Name = "labelLugarId";
            labelLugarId.Size = new Size(0, 20);
            labelLugarId.TabIndex = 14;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(9, 9);
            labelId.Name = "labelId";
            labelId.Size = new Size(31, 20);
            labelId.TabIndex = 13;
            labelId.Text = "ID: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(451, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(790, 426);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FormMetodoPagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 459);
            Controls.Add(bttActualizarMedioPago);
            Controls.Add(bttGrabarMedioPago);
            Controls.Add(bttListarMedioPago);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEstado);
            Controls.Add(txtTitular);
            Controls.Add(txtTipo);
            Controls.Add(labelLugarId);
            Controls.Add(labelId);
            Controls.Add(dataGridView1);
            Name = "FormMetodoPagos";
            Text = "FormMetodoPagos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttActualizarMedioPago;
        private Button bttGrabarMedioPago;
        private Button bttListarMedioPago;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEstado;
        private TextBox txtTitular;
        private TextBox txtTipo;
        private Label labelLugarId;
        private Label labelId;
        private DataGridView dataGridView1;
    }
}