namespace UI
{
    partial class FormRoles
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
            labelId = new Label();
            labelLugarId = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonListarRoles = new Button();
            buttonGrabarRoles = new Button();
            buttonActualizarRoles = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(430, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(814, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(12, 9);
            labelId.Name = "labelId";
            labelId.Size = new Size(31, 20);
            labelId.TabIndex = 1;
            labelId.Text = "ID: ";
            // 
            // labelLugarId
            // 
            labelLugarId.AutoSize = true;
            labelLugarId.Location = new Point(49, 9);
            labelLugarId.Name = "labelLugarId";
            labelLugarId.Size = new Size(0, 20);
            labelLugarId.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(294, 27);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre del rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 7;
            label2.Text = "Nivel de acceso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 8;
            label3.Text = "Estado";
            // 
            // buttonListarRoles
            // 
            buttonListarRoles.Location = new Point(130, 148);
            buttonListarRoles.Name = "buttonListarRoles";
            buttonListarRoles.Size = new Size(94, 29);
            buttonListarRoles.TabIndex = 9;
            buttonListarRoles.Text = "Listar";
            buttonListarRoles.UseVisualStyleBackColor = true;
            buttonListarRoles.Click += buttonListarRoles_Click;
            // 
            // buttonGrabarRoles
            // 
            buttonGrabarRoles.Location = new Point(230, 148);
            buttonGrabarRoles.Name = "buttonGrabarRoles";
            buttonGrabarRoles.Size = new Size(94, 29);
            buttonGrabarRoles.TabIndex = 10;
            buttonGrabarRoles.Text = "Grabar";
            buttonGrabarRoles.UseVisualStyleBackColor = true;
            buttonGrabarRoles.Click += buttonGrabarRoles_Click;
            // 
            // buttonActualizarRoles
            // 
            buttonActualizarRoles.Location = new Point(330, 148);
            buttonActualizarRoles.Name = "buttonActualizarRoles";
            buttonActualizarRoles.Size = new Size(94, 29);
            buttonActualizarRoles.TabIndex = 11;
            buttonActualizarRoles.Text = "Actualizar";
            buttonActualizarRoles.UseVisualStyleBackColor = true;
            buttonActualizarRoles.Click += buttonActualizarRoles_Click;
            // 
            // FormRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 450);
            Controls.Add(buttonActualizarRoles);
            Controls.Add(buttonGrabarRoles);
            Controls.Add(buttonListarRoles);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelLugarId);
            Controls.Add(labelId);
            Controls.Add(dataGridView1);
            Name = "FormRoles";
            Text = "FormRoles";
            Load += FormRoles_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelId;
        private Label labelLugarId;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonListarRoles;
        private Button buttonGrabarRoles;
        private Button buttonActualizarRoles;
    }
}