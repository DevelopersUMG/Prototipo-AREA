namespace ADST_Colchoneria.Forms.Areas.Comercial
{
    partial class frm_modulofactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_modulofactura));
            this.button1 = new System.Windows.Forms.Button();
            this.cmbdepto = new System.Windows.Forms.ComboBox();
            this.cmbmuni = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbdepto
            // 
            this.cmbdepto.FormattingEnabled = true;
            this.cmbdepto.Items.AddRange(new object[] {
            "Guatemala",
            "Escuintla"});
            this.cmbdepto.Location = new System.Drawing.Point(108, 92);
            this.cmbdepto.Name = "cmbdepto";
            this.cmbdepto.Size = new System.Drawing.Size(121, 21);
            this.cmbdepto.TabIndex = 1;
            // 
            // cmbmuni
            // 
            this.cmbmuni.FormattingEnabled = true;
            this.cmbmuni.Items.AddRange(new object[] {
            "Mixco",
            "San Miguel Petapa",
            "Villa Nueva"});
            this.cmbmuni.Location = new System.Drawing.Point(306, 92);
            this.cmbmuni.Name = "cmbmuni";
            this.cmbmuni.Size = new System.Drawing.Size(121, 21);
            this.cmbmuni.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Municipio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Departamento:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(108, 62);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(452, 20);
            this.txtdireccion.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Direccion:";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(108, 36);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(452, 20);
            this.txtcliente.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Destinatario:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl1,
            this.cl2});
            this.dataGridView1.Location = new System.Drawing.Point(28, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 153);
            this.dataGridView1.TabIndex = 14;
            // 
            // cl1
            // 
            this.cl1.HeaderText = "Codigo_Producto";
            this.cl1.Name = "cl1";
            // 
            // cl2
            // 
            this.cl2.HeaderText = "Cantidad";
            this.cl2.Name = "cl2";
            // 
            // frm_modulofactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 306);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbmuni);
            this.Controls.Add(this.cmbdepto);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_modulofactura";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbdepto;
        private System.Windows.Forms.ComboBox cmbmuni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2;
    }
}