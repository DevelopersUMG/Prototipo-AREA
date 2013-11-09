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
            this.barra1 = new Navegador.Barra();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbdetalle = new System.Windows.Forms.GroupBox();
            this.rbcargo = new System.Windows.Forms.RadioButton();
            this.rbabono = new System.Windows.Forms.RadioButton();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbcuenta = new System.Windows.Forms.ComboBox();
            this.lbcuenta = new System.Windows.Forms.Label();
            this.gbencabezado = new System.Windows.Forms.GroupBox();
            this.tbconcepto = new System.Windows.Forms.TextBox();
            this.lbconcepto = new System.Windows.Forms.Label();
            this.datetpfecha = new System.Windows.Forms.DateTimePicker();
            this.lbfecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbpoliza = new System.Windows.Forms.TextBox();
            this.lbpoliza = new System.Windows.Forms.Label();
            this.dgpolizas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbdetalle.SuspendLayout();
            this.gbencabezado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpolizas)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(21, 14);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(268, 42);
            this.barra1.TabIndex = 1;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button_1);
            this.barra1.click_editar_button += new Navegador.Barra.delegadoButton(this.barra1_click_editar_button);
            this.barra1.click_eliminar_button += new Navegador.Barra.delegadoButton(this.barra1_click_eliminar_button);
            this.barra1.click_actualizar_button += new Navegador.Barra.delegadoButton(this.barra1_click_actualizar_button);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.gbdetalle);
            this.panel1.Controls.Add(this.gbencabezado);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(21, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 294);
            this.panel1.TabIndex = 2;
            // 
            // gbdetalle
            // 
            this.gbdetalle.Controls.Add(this.rbcargo);
            this.gbdetalle.Controls.Add(this.rbabono);
            this.gbdetalle.Controls.Add(this.tbtotal);
            this.gbdetalle.Controls.Add(this.label7);
            this.gbdetalle.Controls.Add(this.cbcuenta);
            this.gbdetalle.Controls.Add(this.lbcuenta);
            this.gbdetalle.Enabled = false;
            this.gbdetalle.Location = new System.Drawing.Point(21, 197);
            this.gbdetalle.Name = "gbdetalle";
            this.gbdetalle.Size = new System.Drawing.Size(627, 82);
            this.gbdetalle.TabIndex = 4;
            this.gbdetalle.TabStop = false;
            this.gbdetalle.Text = "Detalle";
            // 
            // rbcargo
            // 
            this.rbcargo.AutoSize = true;
            this.rbcargo.Location = new System.Drawing.Point(394, 19);
            this.rbcargo.Name = "rbcargo";
            this.rbcargo.Size = new System.Drawing.Size(53, 17);
            this.rbcargo.TabIndex = 9;
            this.rbcargo.TabStop = true;
            this.rbcargo.Text = "Cargo";
            this.rbcargo.UseVisualStyleBackColor = true;
            // 
            // rbabono
            // 
            this.rbabono.AutoSize = true;
            this.rbabono.Location = new System.Drawing.Point(394, 43);
            this.rbabono.Name = "rbabono";
            this.rbabono.Size = new System.Drawing.Size(56, 17);
            this.rbabono.TabIndex = 8;
            this.rbabono.TabStop = true;
            this.rbabono.Text = "Abono";
            this.rbabono.UseVisualStyleBackColor = true;
            // 
            // tbtotal
            // 
            this.tbtotal.Location = new System.Drawing.Point(498, 42);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(109, 20);
            this.tbtotal.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total";
            // 
            // cbcuenta
            // 
            this.cbcuenta.FormattingEnabled = true;
            this.cbcuenta.Location = new System.Drawing.Point(25, 42);
            this.cbcuenta.Name = "cbcuenta";
            this.cbcuenta.Size = new System.Drawing.Size(325, 21);
            this.cbcuenta.TabIndex = 5;
            // 
            // lbcuenta
            // 
            this.lbcuenta.AutoSize = true;
            this.lbcuenta.Location = new System.Drawing.Point(22, 20);
            this.lbcuenta.Name = "lbcuenta";
            this.lbcuenta.Size = new System.Drawing.Size(41, 13);
            this.lbcuenta.TabIndex = 4;
            this.lbcuenta.Text = "Cuenta";
            // 
            // gbencabezado
            // 
            this.gbencabezado.Controls.Add(this.tbconcepto);
            this.gbencabezado.Controls.Add(this.lbconcepto);
            this.gbencabezado.Controls.Add(this.datetpfecha);
            this.gbencabezado.Controls.Add(this.lbfecha);
            this.gbencabezado.Enabled = false;
            this.gbencabezado.Location = new System.Drawing.Point(21, 86);
            this.gbencabezado.Name = "gbencabezado";
            this.gbencabezado.Size = new System.Drawing.Size(627, 105);
            this.gbencabezado.TabIndex = 3;
            this.gbencabezado.TabStop = false;
            this.gbencabezado.Text = "Encabezado";
            this.gbencabezado.Enter += new System.EventHandler(this.gbencabezado_Enter);
            // 
            // tbconcepto
            // 
            this.tbconcepto.Location = new System.Drawing.Point(96, 63);
            this.tbconcepto.Name = "tbconcepto";
            this.tbconcepto.Size = new System.Drawing.Size(511, 20);
            this.tbconcepto.TabIndex = 8;
            // 
            // lbconcepto
            // 
            this.lbconcepto.AutoSize = true;
            this.lbconcepto.Location = new System.Drawing.Point(22, 63);
            this.lbconcepto.Name = "lbconcepto";
            this.lbconcepto.Size = new System.Drawing.Size(53, 13);
            this.lbconcepto.TabIndex = 4;
            this.lbconcepto.Text = "Concepto";
            // 
            // datetpfecha
            // 
            this.datetpfecha.Location = new System.Drawing.Point(96, 25);
            this.datetpfecha.Name = "datetpfecha";
            this.datetpfecha.Size = new System.Drawing.Size(200, 20);
            this.datetpfecha.TabIndex = 2;
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(22, 25);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(37, 13);
            this.lbfecha.TabIndex = 1;
            this.lbfecha.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbpoliza);
            this.groupBox1.Controls.Add(this.lbpoliza);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(21, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Poliza";
            // 
            // tbpoliza
            // 
            this.tbpoliza.Location = new System.Drawing.Point(149, 25);
            this.tbpoliza.Name = "tbpoliza";
            this.tbpoliza.Size = new System.Drawing.Size(100, 20);
            this.tbpoliza.TabIndex = 1;
            // 
            // lbpoliza
            // 
            this.lbpoliza.AutoSize = true;
            this.lbpoliza.Location = new System.Drawing.Point(71, 25);
            this.lbpoliza.Name = "lbpoliza";
            this.lbpoliza.Size = new System.Drawing.Size(35, 13);
            this.lbpoliza.TabIndex = 0;
            this.lbpoliza.Text = "Poliza";
            // 
            // dgpolizas
            // 
            this.dgpolizas.AllowUserToAddRows = false;
            this.dgpolizas.AllowUserToDeleteRows = false;
            this.dgpolizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgpolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpolizas.Location = new System.Drawing.Point(22, 361);
            this.dgpolizas.Name = "dgpolizas";
            this.dgpolizas.ReadOnly = true;
            this.dgpolizas.Size = new System.Drawing.Size(670, 135);
            this.dgpolizas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total de Cargos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total de Abonos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Diferencial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(165, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(407, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(632, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Label11";
            // 
            // frm_poliza_departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADST_Colchoneria.Properties.Resources.fondo4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 551);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgpolizas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barra1);
            this.DoubleBuffered = true;
            this.Name = "frm_poliza_departamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Polizas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_poliza_departamentos_FormClosing);
            this.Load += new System.EventHandler(this.frm_poliza_departamentos_Load);
            this.panel1.ResumeLayout(false);
            this.gbdetalle.ResumeLayout(false);
            this.gbdetalle.PerformLayout();
            this.gbencabezado.ResumeLayout(false);
            this.gbencabezado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpolizas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Barra barra1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbdetalle;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbcuenta;
        private System.Windows.Forms.Label lbcuenta;
        private System.Windows.Forms.GroupBox gbencabezado;
        private System.Windows.Forms.DateTimePicker datetpfecha;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbpoliza;
        private System.Windows.Forms.Label lbpoliza;
        private System.Windows.Forms.TextBox tbconcepto;
        private System.Windows.Forms.Label lbconcepto;
        private System.Windows.Forms.RadioButton rbcargo;
        private System.Windows.Forms.RadioButton rbabono;
        private System.Windows.Forms.DataGridView dgpolizas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}