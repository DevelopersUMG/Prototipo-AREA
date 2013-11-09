namespace ADST_Colchoneria.Forms.Areas.Finanzas
{
    partial class frm_manejo_bancos
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
            this.tb_bancos = new System.Windows.Forms.TabControl();
            this.bp_inset_bancos = new System.Windows.Forms.TabPage();
            this.dg_bancos = new System.Windows.Forms.DataGridView();
            this.gp_datos_banco = new System.Windows.Forms.GroupBox();
            this.tb_nombanc = new System.Windows.Forms.TextBox();
            this.lb_nomban = new System.Windows.Forms.Label();
            this.tb_manejo_cuenta = new System.Windows.Forms.TabPage();
            this.dg_cuentas = new System.Windows.Forms.DataGridView();
            this.gb_datos_cuentas = new System.Windows.Forms.GroupBox();
            this.tb_no_cuenta = new System.Windows.Forms.TextBox();
            this.lb_bancos = new System.Windows.Forms.Label();
            this.cb_banc = new System.Windows.Forms.ComboBox();
            this.tb_saldant = new System.Windows.Forms.TextBox();
            this.tb_saldoact = new System.Windows.Forms.TextBox();
            this.lb_salant = new System.Windows.Forms.Label();
            this.lb_salact = new System.Windows.Forms.Label();
            this.lb_nocuenta = new System.Windows.Forms.Label();
            this.barra1 = new Navegador.Barra();
            this.tb_bancos.SuspendLayout();
            this.bp_inset_bancos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bancos)).BeginInit();
            this.gp_datos_banco.SuspendLayout();
            this.tb_manejo_cuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cuentas)).BeginInit();
            this.gb_datos_cuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_bancos
            // 
            this.tb_bancos.Controls.Add(this.bp_inset_bancos);
            this.tb_bancos.Controls.Add(this.tb_manejo_cuenta);
            this.tb_bancos.Location = new System.Drawing.Point(34, 95);
            this.tb_bancos.Name = "tb_bancos";
            this.tb_bancos.SelectedIndex = 0;
            this.tb_bancos.Size = new System.Drawing.Size(698, 385);
            this.tb_bancos.TabIndex = 0;
            // 
            // bp_inset_bancos
            // 
            this.bp_inset_bancos.Controls.Add(this.dg_bancos);
            this.bp_inset_bancos.Controls.Add(this.gp_datos_banco);
            this.bp_inset_bancos.Location = new System.Drawing.Point(4, 22);
            this.bp_inset_bancos.Name = "bp_inset_bancos";
            this.bp_inset_bancos.Padding = new System.Windows.Forms.Padding(3);
            this.bp_inset_bancos.Size = new System.Drawing.Size(690, 359);
            this.bp_inset_bancos.TabIndex = 0;
            this.bp_inset_bancos.Text = "Manejo de Bancos";
            this.bp_inset_bancos.UseVisualStyleBackColor = true;
            this.bp_inset_bancos.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dg_bancos
            // 
            this.dg_bancos.AllowUserToAddRows = false;
            this.dg_bancos.AllowUserToDeleteRows = false;
            this.dg_bancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_bancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bancos.Location = new System.Drawing.Point(18, 150);
            this.dg_bancos.Name = "dg_bancos";
            this.dg_bancos.ReadOnly = true;
            this.dg_bancos.Size = new System.Drawing.Size(638, 187);
            this.dg_bancos.TabIndex = 1;
            // 
            // gp_datos_banco
            // 
            this.gp_datos_banco.Controls.Add(this.tb_nombanc);
            this.gp_datos_banco.Controls.Add(this.lb_nomban);
            this.gp_datos_banco.Location = new System.Drawing.Point(19, 22);
            this.gp_datos_banco.Name = "gp_datos_banco";
            this.gp_datos_banco.Size = new System.Drawing.Size(637, 91);
            this.gp_datos_banco.TabIndex = 0;
            this.gp_datos_banco.TabStop = false;
            this.gp_datos_banco.Text = "Datos de Banco";
            // 
            // tb_nombanc
            // 
            this.tb_nombanc.Location = new System.Drawing.Point(279, 40);
            this.tb_nombanc.Name = "tb_nombanc";
            this.tb_nombanc.ReadOnly = true;
            this.tb_nombanc.Size = new System.Drawing.Size(210, 20);
            this.tb_nombanc.TabIndex = 2;
            // 
            // lb_nomban
            // 
            this.lb_nomban.AutoSize = true;
            this.lb_nomban.Location = new System.Drawing.Point(147, 43);
            this.lb_nomban.Name = "lb_nomban";
            this.lb_nomban.Size = new System.Drawing.Size(95, 13);
            this.lb_nomban.TabIndex = 0;
            this.lb_nomban.Text = "Nombre del Banco";
            // 
            // tb_manejo_cuenta
            // 
            this.tb_manejo_cuenta.Controls.Add(this.dg_cuentas);
            this.tb_manejo_cuenta.Controls.Add(this.gb_datos_cuentas);
            this.tb_manejo_cuenta.Location = new System.Drawing.Point(4, 22);
            this.tb_manejo_cuenta.Name = "tb_manejo_cuenta";
            this.tb_manejo_cuenta.Padding = new System.Windows.Forms.Padding(3);
            this.tb_manejo_cuenta.Size = new System.Drawing.Size(690, 359);
            this.tb_manejo_cuenta.TabIndex = 1;
            this.tb_manejo_cuenta.Text = "Manejo de Cuentas";
            this.tb_manejo_cuenta.UseVisualStyleBackColor = true;
            // 
            // dg_cuentas
            // 
            this.dg_cuentas.AllowUserToAddRows = false;
            this.dg_cuentas.AllowUserToDeleteRows = false;
            this.dg_cuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cuentas.Location = new System.Drawing.Point(18, 189);
            this.dg_cuentas.Name = "dg_cuentas";
            this.dg_cuentas.ReadOnly = true;
            this.dg_cuentas.Size = new System.Drawing.Size(647, 154);
            this.dg_cuentas.TabIndex = 1;
            // 
            // gb_datos_cuentas
            // 
            this.gb_datos_cuentas.Controls.Add(this.tb_no_cuenta);
            this.gb_datos_cuentas.Controls.Add(this.lb_bancos);
            this.gb_datos_cuentas.Controls.Add(this.cb_banc);
            this.gb_datos_cuentas.Controls.Add(this.tb_saldant);
            this.gb_datos_cuentas.Controls.Add(this.tb_saldoact);
            this.gb_datos_cuentas.Controls.Add(this.lb_salant);
            this.gb_datos_cuentas.Controls.Add(this.lb_salact);
            this.gb_datos_cuentas.Controls.Add(this.lb_nocuenta);
            this.gb_datos_cuentas.Location = new System.Drawing.Point(18, 26);
            this.gb_datos_cuentas.Name = "gb_datos_cuentas";
            this.gb_datos_cuentas.Size = new System.Drawing.Size(647, 144);
            this.gb_datos_cuentas.TabIndex = 0;
            this.gb_datos_cuentas.TabStop = false;
            this.gb_datos_cuentas.Text = "Cuentas bancarias";
            // 
            // tb_no_cuenta
            // 
            this.tb_no_cuenta.Location = new System.Drawing.Point(173, 29);
            this.tb_no_cuenta.Name = "tb_no_cuenta";
            this.tb_no_cuenta.ReadOnly = true;
            this.tb_no_cuenta.Size = new System.Drawing.Size(121, 20);
            this.tb_no_cuenta.TabIndex = 8;
            // 
            // lb_bancos
            // 
            this.lb_bancos.AutoSize = true;
            this.lb_bancos.Location = new System.Drawing.Point(369, 37);
            this.lb_bancos.Name = "lb_bancos";
            this.lb_bancos.Size = new System.Drawing.Size(46, 13);
            this.lb_bancos.TabIndex = 7;
            this.lb_bancos.Text = "Bancos:";
            // 
            // cb_banc
            // 
            this.cb_banc.FormattingEnabled = true;
            this.cb_banc.Location = new System.Drawing.Point(438, 29);
            this.cb_banc.Name = "cb_banc";
            this.cb_banc.Size = new System.Drawing.Size(121, 21);
            this.cb_banc.TabIndex = 6;
            // 
            // tb_saldant
            // 
            this.tb_saldant.Location = new System.Drawing.Point(173, 107);
            this.tb_saldant.Name = "tb_saldant";
            this.tb_saldant.ReadOnly = true;
            this.tb_saldant.Size = new System.Drawing.Size(121, 20);
            this.tb_saldant.TabIndex = 5;
            // 
            // tb_saldoact
            // 
            this.tb_saldoact.Location = new System.Drawing.Point(173, 66);
            this.tb_saldoact.Name = "tb_saldoact";
            this.tb_saldoact.ReadOnly = true;
            this.tb_saldoact.Size = new System.Drawing.Size(121, 20);
            this.tb_saldoact.TabIndex = 4;
            // 
            // lb_salant
            // 
            this.lb_salant.AutoSize = true;
            this.lb_salant.Location = new System.Drawing.Point(90, 110);
            this.lb_salant.Name = "lb_salant";
            this.lb_salant.Size = new System.Drawing.Size(75, 13);
            this.lb_salant.TabIndex = 2;
            this.lb_salant.Text = "Saldo anterior:";
            // 
            // lb_salact
            // 
            this.lb_salact.AutoSize = true;
            this.lb_salact.Location = new System.Drawing.Point(90, 73);
            this.lb_salact.Name = "lb_salact";
            this.lb_salact.Size = new System.Drawing.Size(69, 13);
            this.lb_salact.TabIndex = 1;
            this.lb_salact.Text = "Saldo actual:";
            // 
            // lb_nocuenta
            // 
            this.lb_nocuenta.AutoSize = true;
            this.lb_nocuenta.Location = new System.Drawing.Point(90, 33);
            this.lb_nocuenta.Name = "lb_nocuenta";
            this.lb_nocuenta.Size = new System.Drawing.Size(63, 13);
            this.lb_nocuenta.TabIndex = 0;
            this.lb_nocuenta.Text = "No_cuenta:";
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(34, 21);
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
            this.barra1.click_imprimir_button += new Navegador.Barra.delegadoButton(this.barra1_click_imprimir_button);
            this.barra1.Load += new System.EventHandler(this.barra1_Load);
            // 
            // frm_manejo_bancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 492);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.tb_bancos);
            this.Name = "frm_manejo_bancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Majejo de Bancos";
            this.Load += new System.EventHandler(this.frm_manejo_bancos_Load);
            this.tb_bancos.ResumeLayout(false);
            this.bp_inset_bancos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_bancos)).EndInit();
            this.gp_datos_banco.ResumeLayout(false);
            this.gp_datos_banco.PerformLayout();
            this.tb_manejo_cuenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cuentas)).EndInit();
            this.gb_datos_cuentas.ResumeLayout(false);
            this.gb_datos_cuentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_bancos;
        private System.Windows.Forms.TabPage bp_inset_bancos;
        private System.Windows.Forms.DataGridView dg_bancos;
        private System.Windows.Forms.GroupBox gp_datos_banco;
        private System.Windows.Forms.TabPage tb_manejo_cuenta;
        private Navegador.Barra barra1;
        private System.Windows.Forms.Label lb_nomban;
        private System.Windows.Forms.GroupBox gb_datos_cuentas;
        private System.Windows.Forms.DataGridView dg_cuentas;
        private System.Windows.Forms.Label lb_bancos;
        private System.Windows.Forms.ComboBox cb_banc;
        private System.Windows.Forms.TextBox tb_saldant;
        private System.Windows.Forms.TextBox tb_saldoact;
        private System.Windows.Forms.Label lb_salant;
        private System.Windows.Forms.Label lb_salact;
        private System.Windows.Forms.Label lb_nocuenta;
        private System.Windows.Forms.TextBox tb_nombanc;
        private System.Windows.Forms.TextBox tb_no_cuenta;
    }
}