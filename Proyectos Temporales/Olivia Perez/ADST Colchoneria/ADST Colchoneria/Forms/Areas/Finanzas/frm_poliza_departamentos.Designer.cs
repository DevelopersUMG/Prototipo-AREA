namespace ADST_Colchoneria.Forms.Areas.Finanzas
{
    partial class frm_poliza_departamentos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datagvdepto = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.datagvencabezado = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbhaber = new System.Windows.Forms.CheckBox();
            this.cbdebe = new System.Windows.Forms.CheckBox();
            this.datagvdetalle = new System.Windows.Forms.DataGridView();
            this.cmbdiario = new System.Windows.Forms.ComboBox();
            this.lbldiario = new System.Windows.Forms.Label();
            this.barra1 = new Navegador.Barra();
            this.lblfecha = new System.Windows.Forms.Label();
            this.datetpfecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtconcepto = new System.Windows.Forms.TextBox();
            this.lblconcepto = new System.Windows.Forms.Label();
            this.lblpoliza = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtdepto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbfactura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldepto = new System.Windows.Forms.Label();
            this.cmbdepto = new System.Windows.Forms.ComboBox();
            this.lbldepartamento = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.cmbcuenta = new System.Windows.Forms.ComboBox();
            this.lblcuenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvdepto)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvencabezado)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvdetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblestado);
            this.tabPage1.Controls.Add(this.txtdepto);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbfactura);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbldepto);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.datagvdepto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Poliza Departamentos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // datagvdepto
            // 
            this.datagvdepto.AllowUserToAddRows = false;
            this.datagvdepto.AllowUserToDeleteRows = false;
            this.datagvdepto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagvdepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvdepto.Location = new System.Drawing.Point(6, 287);
            this.datagvdepto.Name = "datagvdepto";
            this.datagvdepto.ReadOnly = true;
            this.datagvdepto.Size = new System.Drawing.Size(664, 187);
            this.datagvdepto.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.datagvencabezado);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(705, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Poliza Encabezado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // datagvencabezado
            // 
            this.datagvencabezado.AllowUserToAddRows = false;
            this.datagvencabezado.AllowUserToDeleteRows = false;
            this.datagvencabezado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagvencabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvencabezado.Location = new System.Drawing.Point(33, 196);
            this.datagvencabezado.Name = "datagvencabezado";
            this.datagvencabezado.ReadOnly = true;
            this.datagvencabezado.Size = new System.Drawing.Size(644, 162);
            this.datagvencabezado.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.datagvdetalle);
            this.tabPage3.Controls.Add(this.cmbdiario);
            this.tabPage3.Controls.Add(this.lbldiario);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(705, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Poliza Detalle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbhaber);
            this.panel1.Controls.Add(this.cbdebe);
            this.panel1.Location = new System.Drawing.Point(329, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 21);
            this.panel1.TabIndex = 9;
            // 
            // cbhaber
            // 
            this.cbhaber.AutoSize = true;
            this.cbhaber.Location = new System.Drawing.Point(130, 1);
            this.cbhaber.Name = "cbhaber";
            this.cbhaber.Size = new System.Drawing.Size(55, 17);
            this.cbhaber.TabIndex = 1;
            this.cbhaber.Text = "Haber";
            this.cbhaber.UseVisualStyleBackColor = true;
            // 
            // cbdebe
            // 
            this.cbdebe.AutoSize = true;
            this.cbdebe.Location = new System.Drawing.Point(15, 1);
            this.cbdebe.Name = "cbdebe";
            this.cbdebe.Size = new System.Drawing.Size(52, 17);
            this.cbdebe.TabIndex = 0;
            this.cbdebe.Text = "Debe";
            this.cbdebe.UseVisualStyleBackColor = true;
            // 
            // datagvdetalle
            // 
            this.datagvdetalle.AllowUserToAddRows = false;
            this.datagvdetalle.AllowUserToDeleteRows = false;
            this.datagvdetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvdetalle.Location = new System.Drawing.Point(17, 205);
            this.datagvdetalle.Name = "datagvdetalle";
            this.datagvdetalle.ReadOnly = true;
            this.datagvdetalle.Size = new System.Drawing.Size(661, 150);
            this.datagvdetalle.TabIndex = 8;
            // 
            // cmbdiario
            // 
            this.cmbdiario.FormattingEnabled = true;
            this.cmbdiario.Location = new System.Drawing.Point(154, 162);
            this.cmbdiario.Name = "cmbdiario";
            this.cmbdiario.Size = new System.Drawing.Size(121, 21);
            this.cmbdiario.TabIndex = 7;
            // 
            // lbldiario
            // 
            this.lbldiario.AutoSize = true;
            this.lbldiario.Location = new System.Drawing.Point(41, 162);
            this.lbldiario.Name = "lbldiario";
            this.lbldiario.Size = new System.Drawing.Size(80, 13);
            this.lbldiario.TabIndex = 3;
            this.lbldiario.Text = "No. Libro Diario";
            this.lbldiario.Click += new System.EventHandler(this.label10_Click);
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(7, 11);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(268, 42);
            this.barra1.TabIndex = 1;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            this.barra1.click_editar_button += new Navegador.Barra.delegadoButton(this.barra1_click_editar_button);
            this.barra1.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra1_click_buscar_button);
            this.barra1.click_eliminar_button += new Navegador.Barra.delegadoButton(this.barra1_click_eliminar_button);
            this.barra1.click_actualizar_button += new Navegador.Barra.delegadoButton(this.barra1_click_actualizar_button);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(15, 20);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(37, 13);
            this.lblfecha.TabIndex = 11;
            this.lblfecha.Text = "Fecha";
            // 
            // datetpfecha
            // 
            this.datetpfecha.Location = new System.Drawing.Point(72, 18);
            this.datetpfecha.Name = "datetpfecha";
            this.datetpfecha.Size = new System.Drawing.Size(213, 20);
            this.datetpfecha.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblfecha);
            this.groupBox1.Controls.Add(this.lblpoliza);
            this.groupBox1.Controls.Add(this.lblconcepto);
            this.groupBox1.Controls.Add(this.datetpfecha);
            this.groupBox1.Location = new System.Drawing.Point(6, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 75);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbcuenta);
            this.groupBox2.Controls.Add(this.lblcuenta);
            this.groupBox2.Controls.Add(this.txttotal);
            this.groupBox2.Controls.Add(this.lbltotal);
            this.groupBox2.Controls.Add(this.cmbdepto);
            this.groupBox2.Controls.Add(this.lbldepartamento);
            this.groupBox2.Controls.Add(this.txtconcepto);
            this.groupBox2.Location = new System.Drawing.Point(6, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 75);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // txtconcepto
            // 
            this.txtconcepto.Location = new System.Drawing.Point(70, -33);
            this.txtconcepto.Multiline = true;
            this.txtconcepto.Name = "txtconcepto";
            this.txtconcepto.ReadOnly = true;
            this.txtconcepto.Size = new System.Drawing.Size(267, 27);
            this.txtconcepto.TabIndex = 13;
            // 
            // lblconcepto
            // 
            this.lblconcepto.AutoSize = true;
            this.lblconcepto.Location = new System.Drawing.Point(15, 47);
            this.lblconcepto.Name = "lblconcepto";
            this.lblconcepto.Size = new System.Drawing.Size(53, 13);
            this.lblconcepto.TabIndex = 12;
            this.lblconcepto.Text = "Concepto";
            // 
            // lblpoliza
            // 
            this.lblpoliza.AutoSize = true;
            this.lblpoliza.Location = new System.Drawing.Point(316, 25);
            this.lblpoliza.Name = "lblpoliza";
            this.lblpoliza.Size = new System.Drawing.Size(49, 13);
            this.lblpoliza.TabIndex = 14;
            this.lblpoliza.Text = "ID Poliza";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(522, 20);
            this.textBox1.TabIndex = 16;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(405, 38);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(0, 13);
            this.lblestado.TabIndex = 20;
            // 
            // txtdepto
            // 
            this.txtdepto.Location = new System.Drawing.Point(78, 18);
            this.txtdepto.Name = "txtdepto";
            this.txtdepto.ReadOnly = true;
            this.txtdepto.Size = new System.Drawing.Size(121, 20);
            this.txtdepto.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Factura";
            // 
            // cmbfactura
            // 
            this.cmbfactura.FormattingEnabled = true;
            this.cmbfactura.Location = new System.Drawing.Point(78, 44);
            this.cmbfactura.Name = "cmbfactura";
            this.cmbfactura.Size = new System.Drawing.Size(121, 21);
            this.cmbfactura.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            // 
            // lbldepto
            // 
            this.lbldepto.AutoSize = true;
            this.lbldepto.Location = new System.Drawing.Point(21, 25);
            this.lbldepto.Name = "lbldepto";
            this.lbldepto.Size = new System.Drawing.Size(35, 13);
            this.lbldepto.TabIndex = 14;
            this.lbldepto.Text = "Poliza";
            // 
            // cmbdepto
            // 
            this.cmbdepto.FormattingEnabled = true;
            this.cmbdepto.Location = new System.Drawing.Point(18, 31);
            this.cmbdepto.Name = "cmbdepto";
            this.cmbdepto.Size = new System.Drawing.Size(121, 21);
            this.cmbdepto.TabIndex = 15;
            // 
            // lbldepartamento
            // 
            this.lbldepartamento.AutoSize = true;
            this.lbldepartamento.Location = new System.Drawing.Point(69, 15);
            this.lbldepartamento.Name = "lbldepartamento";
            this.lbldepartamento.Size = new System.Drawing.Size(35, 13);
            this.lbldepartamento.TabIndex = 14;
            this.lbldepartamento.Text = "Poliza";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(533, 32);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(121, 20);
            this.txttotal.TabIndex = 17;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(563, 15);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 16;
            this.lbltotal.Text = "Total";
            // 
            // cmbcuenta
            // 
            this.cmbcuenta.FormattingEnabled = true;
            this.cmbcuenta.Location = new System.Drawing.Point(145, 32);
            this.cmbcuenta.Name = "cmbcuenta";
            this.cmbcuenta.Size = new System.Drawing.Size(251, 21);
            this.cmbcuenta.TabIndex = 19;
            // 
            // lblcuenta
            // 
            this.lblcuenta.AutoSize = true;
            this.lblcuenta.Location = new System.Drawing.Point(197, 15);
            this.lblcuenta.Name = "lblcuenta";
            this.lblcuenta.Size = new System.Drawing.Size(41, 13);
            this.lblcuenta.TabIndex = 18;
            this.lblcuenta.Text = "Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cargo/Abono";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(402, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(401, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // frm_poliza_departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 566);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_poliza_departamentos";
            this.Text = "Poliza Departamentos";
            this.Load += new System.EventHandler(this.frm_poliza_departamentos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvdepto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvencabezado)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvdetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView datagvdepto;
        private Navegador.Barra barra1;
        private System.Windows.Forms.DataGridView datagvencabezado;
        private System.Windows.Forms.Label lbldiario;
        private System.Windows.Forms.DataGridView datagvdetalle;
        private System.Windows.Forms.ComboBox cmbdiario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbhaber;
        private System.Windows.Forms.CheckBox cbdebe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DateTimePicker datetpfecha;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtdepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbfactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldepto;
        private System.Windows.Forms.ComboBox cmbdepto;
        private System.Windows.Forms.Label lbldepartamento;
        private System.Windows.Forms.TextBox txtconcepto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblpoliza;
        private System.Windows.Forms.Label lblconcepto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcuenta;
        private System.Windows.Forms.Label lblcuenta;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}