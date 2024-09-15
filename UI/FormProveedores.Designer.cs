namespace UI
{
    partial class FormProveedores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonListarEmpleados = new Button();
            buttonGrabarEmpleado = new Button();
            buttonActualizarEmpleados = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelId = new Label();
            labelLugarId = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(484, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(864, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonListarEmpleados
            // 
            buttonListarEmpleados.Location = new Point(12, 409);
            buttonListarEmpleados.Name = "buttonListarEmpleados";
            buttonListarEmpleados.Size = new Size(94, 29);
            buttonListarEmpleados.TabIndex = 1;
            buttonListarEmpleados.Text = "Listar";
            buttonListarEmpleados.UseVisualStyleBackColor = true;
            buttonListarEmpleados.Click += buttonListarEmpleados_Click;
            // 
            // buttonGrabarEmpleado
            // 
            buttonGrabarEmpleado.Location = new Point(112, 409);
            buttonGrabarEmpleado.Name = "buttonGrabarEmpleado";
            buttonGrabarEmpleado.Size = new Size(94, 29);
            buttonGrabarEmpleado.TabIndex = 2;
            buttonGrabarEmpleado.Text = "Grabar";
            buttonGrabarEmpleado.UseVisualStyleBackColor = true;
            buttonGrabarEmpleado.Click += buttonGrabarEmpleado_Click;
            // 
            // buttonActualizarEmpleados
            // 
            buttonActualizarEmpleados.Location = new Point(212, 409);
            buttonActualizarEmpleados.Name = "buttonActualizarEmpleados";
            buttonActualizarEmpleados.Size = new Size(94, 29);
            buttonActualizarEmpleados.TabIndex = 3;
            buttonActualizarEmpleados.Text = "Actualizar";
            buttonActualizarEmpleados.UseVisualStyleBackColor = true;
            buttonActualizarEmpleados.Click += buttonActualizarEmpleados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "Contacto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(189, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(189, 111);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(289, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(189, 144);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(289, 27);
            textBox5.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 16;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 17;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 147);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 18;
            label5.Text = "Direccion";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(12, 323);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 20);
            labelId.TabIndex = 23;
            labelId.Text = "Id: ";
            // 
            // labelLugarId
            // 
            labelLugarId.AutoSize = true;
            labelLugarId.Location = new Point(47, 323);
            labelLugarId.Name = "labelLugarId";
            labelLugarId.Size = new Size(0, 20);
            labelLugarId.TabIndex = 24;
            // 
            // button4
            // 
            button4.Location = new Point(312, 409);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 450);
            Controls.Add(labelLugarId);
            Controls.Add(labelId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(buttonActualizarEmpleados);
            Controls.Add(buttonGrabarEmpleado);
            Controls.Add(buttonListarEmpleados);
            Controls.Add(dataGridView1);
            Name = "FormProveedores";
            Text = "Form1";
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonListarEmpleados;
        private Button buttonGrabarEmpleado;
        private Button buttonActualizarEmpleados;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelId;
        private Label labelLugarId;
        private Button button4;
    }
}
