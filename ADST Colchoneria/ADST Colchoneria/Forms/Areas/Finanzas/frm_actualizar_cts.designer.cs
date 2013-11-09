namespace ADST_Colchoneria.Forms.Areas.Finanzas
{
    partial class frm_actualizar_cts
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
            this.tb_cta = new System.Windows.Forms.TabControl();
            this.bp_inset_bancos = new System.Windows.Forms.TabPage();
            this.dg_cuenta = new System.Windows.Forms.DataGridView();
            this.gp_datos_banco = new System.Windows.Forms.GroupBox();
            this.tb_sactual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomcta = new System.Windows.Forms.TextBox();
            this.lb_nomban = new System.Windows.Forms.Label();
            this.tb_manejo_cuenta = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tb_cta.SuspendLayout();
            this.bp_inset_bancos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cuenta)).BeginInit();
            this.gp_datos_banco.SuspendLayout();
            this.tb_manejo_cuenta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(11, 11);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(268, 42);
            this.barra1.TabIndex = 2;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            this.barra1.click_editar_button += new Navegador.Barra.delegadoButton(this.barra1_click_editar_button);
            this.barra1.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra1_click_buscar_button);
            this.barra1.click_eliminar_button += new Navegador.Barra.delegadoButton(this.barra1_click_eliminar_button);
            this.barra1.click_actualizar_button += new Navegador.Barra.delegadoButton(this.barra1_click_actualizar_button);
            this.barra1.Load += new System.EventHandler(this.barra1_Load);
            // 
            // tb_cta
            // 
            this.tb_cta.Controls.Add(this.bp_inset_bancos);
            this.tb_cta.Controls.Add(this.tb_manejo_cuenta);
            this.tb_cta.Location = new System.Drawing.Point(11, 67);
            this.tb_cta.Name = "tb_cta";
            this.tb_cta.SelectedIndex = 0;
            this.tb_cta.Size = new System.Drawing.Size(787, 387);
            this.tb_cta.TabIndex = 3;
            // 
            // bp_inset_bancos
            // 
            this.bp_inset_bancos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bp_inset_bancos.Controls.Add(this.dg_cuenta);
            this.bp_inset_bancos.Controls.Add(this.gp_datos_banco);
            this.bp_inset_bancos.Location = new System.Drawing.Point(4, 22);
            this.bp_inset_bancos.Name = "bp_inset_bancos";
            this.bp_inset_bancos.Padding = new System.Windows.Forms.Padding(3);
            this.bp_inset_bancos.Size = new System.Drawing.Size(779, 361);
            this.bp_inset_bancos.TabIndex = 0;
            this.bp_inset_bancos.Text = "Actualizar Saldos";
            this.bp_inset_bancos.UseVisualStyleBackColor = true;
            // 
            // dg_cuenta
            // 
            this.dg_cuenta.AllowUserToAddRows = false;
            this.dg_cuenta.AllowUserToDeleteRows = false;
            this.dg_cuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_cuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cuenta.Location = new System.Drawing.Point(18, 150);
            this.dg_cuenta.Name = "dg_cuenta";
            this.dg_cuenta.ReadOnly = true;
            this.dg_cuenta.Size = new System.Drawing.Size(721, 193);
            this.dg_cuenta.TabIndex = 1;
            // 
            // gp_datos_banco
            // 
            this.gp_datos_banco.Controls.Add(this.tb_sactual);
            this.gp_datos_banco.Controls.Add(this.label1);
            this.gp_datos_banco.Controls.Add(this.tb_nomcta);
            this.gp_datos_banco.Controls.Add(this.lb_nomban);
            this.gp_datos_banco.Location = new System.Drawing.Point(19, 22);
            this.gp_datos_banco.Name = "gp_datos_banco";
            this.gp_datos_banco.Size = new System.Drawing.Size(637, 91);
            this.gp_datos_banco.TabIndex = 0;
            this.gp_datos_banco.TabStop = false;
            this.gp_datos_banco.Text = "Datos de la cuenta";
            // 
            // tb_sactual
            // 
            this.tb_sactual.Location = new System.Drawing.Point(118, 55);
            this.tb_sactual.Name = "tb_sactual";
            this.tb_sactual.Size = new System.Drawing.Size(210, 20);
            this.tb_sactual.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cargo";
            // 
            // tb_nomcta
            // 
            this.tb_nomcta.Location = new System.Drawing.Point(118, 23);
            this.tb_nomcta.Name = "tb_nomcta";
            this.tb_nomcta.ReadOnly = true;
            this.tb_nomcta.Size = new System.Drawing.Size(210, 20);
            this.tb_nomcta.TabIndex = 2;
            // 
            // lb_nomban
            // 
            this.lb_nomban.AutoSize = true;
            this.lb_nomban.Location = new System.Drawing.Point(6, 23);
            this.lb_nomban.Name = "lb_nomban";
            this.lb_nomban.Size = new System.Drawing.Size(106, 13);
            this.lb_nomban.TabIndex = 0;
            this.lb_nomban.Text = "Nombre de la cuenta";
            this.lb_nomban.Click += new System.EventHandler(this.lb_nomban_Click);
            // 
            // tb_manejo_cuenta
            // 
            this.tb_manejo_cuenta.Controls.Add(this.panel1);
            this.tb_manejo_cuenta.Location = new System.Drawing.Point(4, 22);
            this.tb_manejo_cuenta.Name = "tb_manejo_cuenta";
            this.tb_manejo_cuenta.Padding = new System.Windows.Forms.Padding(3);
            this.tb_manejo_cuenta.Size = new System.Drawing.Size(779, 361);
            this.tb_manejo_cuenta.TabIndex = 1;
            this.tb_manejo_cuenta.Text = "Verificar polizas";
            this.tb_manejo_cuenta.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Location = new System.Drawing.Point(0, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 341);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 338);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(400, 357);
            this.dataGridView3.TabIndex = 1;
            // 
            // frm_actualizar_cts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADST_Colchoneria.Properties.Resources.fondo4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 491);
            this.Controls.Add(this.tb_cta);
            this.Controls.Add(this.barra1);
            this.DoubleBuffered = true;
            this.Name = "frm_actualizar_cts";
            this.Text = "Actualizar Cuentas";
            this.Load += new System.EventHandler(this.actualizar_cts_Load);
            this.tb_cta.ResumeLayout(false);
            this.bp_inset_bancos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cuenta)).EndInit();
            this.gp_datos_banco.ResumeLayout(false);
            this.gp_datos_banco.PerformLayout();
            this.tb_manejo_cuenta.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Navegador.Barra barra1;
        private System.Windows.Forms.TabControl tb_cta;
        private System.Windows.Forms.TabPage bp_inset_bancos;
        private System.Windows.Forms.DataGridView dg_cuenta;
        private System.Windows.Forms.GroupBox gp_datos_banco;
        private System.Windows.Forms.TextBox tb_nomcta;
        private System.Windows.Forms.Label lb_nomban;
        private System.Windows.Forms.TabPage tb_manejo_cuenta;
        private System.Windows.Forms.TextBox tb_sactual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}