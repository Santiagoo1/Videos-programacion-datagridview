namespace Videos_programacion
{
    partial class FormularioProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cargar = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.ColumnaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LabelStock = new System.Windows.Forms.Label();
            this.ButtomCargar = new System.Windows.Forms.Button();
            this.radioButtonEgreso = new System.Windows.Forms.RadioButton();
            this.radioButtonIngreso = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "stock";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(530, 137);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(75, 23);
            this.Cargar.TabIndex = 3;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(75, 30);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(163, 20);
            this.textBoxCodigo.TabIndex = 4;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(75, 140);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(142, 20);
            this.textBoxStock.TabIndex = 5;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(98, 91);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(301, 20);
            this.textBoxDescripcion.TabIndex = 6;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaDescripcion,
            this.ColumnaCodigo,
            this.ColumnaStock});
            this.dataGridViewProductos.Location = new System.Drawing.Point(74, 221);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(733, 240);
            this.dataGridViewProductos.TabIndex = 7;
            // 
            // ColumnaDescripcion
            // 
            this.ColumnaDescripcion.HeaderText = "Descripcion";
            this.ColumnaDescripcion.Name = "ColumnaDescripcion";
            // 
            // ColumnaCodigo
            // 
            this.ColumnaCodigo.HeaderText = "Codigo";
            this.ColumnaCodigo.Name = "ColumnaCodigo";
            // 
            // ColumnaStock
            // 
            this.ColumnaStock.HeaderText = "Stock";
            this.ColumnaStock.Name = "ColumnaStock";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(74, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(733, 215);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxCodigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Cargar);
            this.tabPage1.Controls.Add(this.textBoxStock);
            this.tabPage1.Controls.Add(this.textBoxDescripcion);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carga de productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LabelStock);
            this.tabPage2.Controls.Add(this.ButtomCargar);
            this.tabPage2.Controls.Add(this.radioButtonEgreso);
            this.tabPage2.Controls.Add(this.radioButtonIngreso);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.labelDescripcion);
            this.tabPage2.Controls.Add(this.labelCodigo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(725, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movimiento de productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LabelStock
            // 
            this.LabelStock.AutoSize = true;
            this.LabelStock.Location = new System.Drawing.Point(48, 85);
            this.LabelStock.Name = "LabelStock";
            this.LabelStock.Size = new System.Drawing.Size(35, 13);
            this.LabelStock.TabIndex = 7;
            this.LabelStock.Text = "label5";
            // 
            // ButtomCargar
            // 
            this.ButtomCargar.Location = new System.Drawing.Point(502, 112);
            this.ButtomCargar.Name = "ButtomCargar";
            this.ButtomCargar.Size = new System.Drawing.Size(75, 23);
            this.ButtomCargar.TabIndex = 6;
            this.ButtomCargar.Text = "Aceptar";
            this.ButtomCargar.UseVisualStyleBackColor = true;
            this.ButtomCargar.Click += new System.EventHandler(this.ButtomCargar_Click);
            // 
            // radioButtonEgreso
            // 
            this.radioButtonEgreso.AutoSize = true;
            this.radioButtonEgreso.Location = new System.Drawing.Point(300, 118);
            this.radioButtonEgreso.Name = "radioButtonEgreso";
            this.radioButtonEgreso.Size = new System.Drawing.Size(58, 17);
            this.radioButtonEgreso.TabIndex = 5;
            this.radioButtonEgreso.TabStop = true;
            this.radioButtonEgreso.Text = "Egreso";
            this.radioButtonEgreso.UseVisualStyleBackColor = true;
            // 
            // radioButtonIngreso
            // 
            this.radioButtonIngreso.AutoSize = true;
            this.radioButtonIngreso.Location = new System.Drawing.Point(300, 95);
            this.radioButtonIngreso.Name = "radioButtonIngreso";
            this.radioButtonIngreso.Size = new System.Drawing.Size(60, 17);
            this.radioButtonIngreso.TabIndex = 4;
            this.radioButtonIngreso.TabStop = true;
            this.radioButtonIngreso.Text = "Ingreso";
            this.radioButtonIngreso.UseVisualStyleBackColor = true;
            this.radioButtonIngreso.CheckedChanged += new System.EventHandler(this.radioButtonIngreso_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cantidad";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(48, 56);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(35, 13);
            this.labelDescripcion.TabIndex = 1;
            this.labelDescripcion.Text = "label5";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(48, 21);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(35, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "label4";
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 514);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridViewProductos);
            this.Name = "FormularioProductos";
            this.Text = "FormularioProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ButtomCargar;
        private System.Windows.Forms.RadioButton radioButtonEgreso;
        private System.Windows.Forms.RadioButton radioButtonIngreso;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label LabelStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaStock;
    }
}