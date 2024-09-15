namespace UI
{
    partial class FormCreacionUsuario
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
            dataGridView1 = new DataGridView();
            buttonListarUsuariosCreados = new Button();
            buttonGrabarUsuarioCreado = new Button();
            buttonActualizarUsuario = new Button();
            textBox1 = new TextBox();
            labelId = new Label();
            labelLugarId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            comboBoxRoles = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(312, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(779, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonListarUsuariosCreados
            // 
            buttonListarUsuariosCreados.Location = new Point(12, 409);
            buttonListarUsuariosCreados.Name = "buttonListarUsuariosCreados";
            buttonListarUsuariosCreados.Size = new Size(94, 29);
            buttonListarUsuariosCreados.TabIndex = 1;
            buttonListarUsuariosCreados.Text = "Listar";
            buttonListarUsuariosCreados.UseVisualStyleBackColor = true;
            buttonListarUsuariosCreados.Click += buttonListarUsuariosCreados_Click;
            // 
            // buttonGrabarUsuarioCreado
            // 
            buttonGrabarUsuarioCreado.Location = new Point(112, 409);
            buttonGrabarUsuarioCreado.Name = "buttonGrabarUsuarioCreado";
            buttonGrabarUsuarioCreado.Size = new Size(94, 29);
            buttonGrabarUsuarioCreado.TabIndex = 2;
            buttonGrabarUsuarioCreado.Text = "Grabar";
            buttonGrabarUsuarioCreado.UseVisualStyleBackColor = true;
            buttonGrabarUsuarioCreado.Click += buttonGrabarUsuarioCreado_Click;
            // 
            // buttonActualizarUsuario
            // 
            buttonActualizarUsuario.Location = new Point(212, 409);
            buttonActualizarUsuario.Name = "buttonActualizarUsuario";
            buttonActualizarUsuario.Size = new Size(94, 29);
            buttonActualizarUsuario.TabIndex = 3;
            buttonActualizarUsuario.Text = "Actualizar";
            buttonActualizarUsuario.UseVisualStyleBackColor = true;
            buttonActualizarUsuario.Click += buttonActualizarUsuario_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 4;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(12, 9);
            labelId.Name = "labelId";
            labelId.Size = new Size(31, 20);
            labelId.TabIndex = 5;
            labelId.Text = "ID: ";
            // 
            // labelLugarId
            // 
            labelLugarId.AutoSize = true;
            labelLugarId.Location = new Point(49, 9);
            labelLugarId.Name = "labelLugarId";
            labelLugarId.Size = new Size(0, 20);
            labelLugarId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 7;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 8;
            label3.Text = "Contrasena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 166);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 9;
            label4.Text = "Rol";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 10;
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Location = new Point(131, 163);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(175, 28);
            comboBoxRoles.TabIndex = 11;
            comboBoxRoles.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(73, 220);
            button1.Name = "button1";
            button1.Size = new Size(174, 49);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(73, 297);
            button2.Name = "button2";
            button2.Size = new Size(174, 49);
            button2.TabIndex = 13;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormCreacionUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxRoles);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelLugarId);
            Controls.Add(labelId);
            Controls.Add(textBox1);
            Controls.Add(buttonActualizarUsuario);
            Controls.Add(buttonGrabarUsuarioCreado);
            Controls.Add(buttonListarUsuariosCreados);
            Controls.Add(dataGridView1);
            Name = "FormCreacionUsuario";
            Text = "FormCreacionUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonListarUsuariosCreados;
        private Button buttonGrabarUsuarioCreado;
        private Button buttonActualizarUsuario;
        private TextBox textBox1;
        private Label labelId;
        private Label labelLugarId;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private ComboBox comboBoxRoles;
        private Button button1;
        private Button button2;
    }
}