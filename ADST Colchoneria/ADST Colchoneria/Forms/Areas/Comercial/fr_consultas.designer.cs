namespace ADST_Colchoneria
{
    partial class fr_consultas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_op = new System.Windows.Forms.TabControl();
            this.tp_p1 = new System.Windows.Forms.TabPage();
            this.br_cong = new Navegador.Barra();
            this.cb_opg = new System.Windows.Forms.ComboBox();
            this.lb_pg = new System.Windows.Forms.Label();
            this.dg_cg = new System.Windows.Forms.DataGridView();
            this.tp_2 = new System.Windows.Forms.TabPage();
            this.cb_opcion = new System.Windows.Forms.ComboBox();
            this.lb_opcion = new System.Windows.Forms.Label();
            this.dg_consulta = new System.Windows.Forms.DataGridView();
            this.br_conesp = new Navegador.Barra();
            this.gb_consultas = new System.Windows.Forms.GroupBox();
            this.cb_pf = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rd_op3 = new System.Windows.Forms.RadioButton();
            this.rd_op2 = new System.Windows.Forms.RadioButton();
            this.rd_op1 = new System.Windows.Forms.RadioButton();
            this.tc_op.SuspendLayout();
            this.tp_p1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cg)).BeginInit();
            this.tp_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).BeginInit();
            this.gb_consultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_op
            // 
            this.tc_op.Controls.Add(this.tp_p1);
            this.tc_op.Controls.Add(this.tp_2);
            this.tc_op.Location = new System.Drawing.Point(16, 14);
            this.tc_op.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tc_op.Name = "tc_op";
            this.tc_op.SelectedIndex = 0;
            this.tc_op.Size = new System.Drawing.Size(860, 546);
            this.tc_op.TabIndex = 0;
            // 
            // tp_p1
            // 
            this.tp_p1.Controls.Add(this.br_cong);
            this.tp_p1.Controls.Add(this.cb_opg);
            this.tp_p1.Controls.Add(this.lb_pg);
            this.tp_p1.Controls.Add(this.dg_cg);
            this.tp_p1.Location = new System.Drawing.Point(4, 24);
            this.tp_p1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tp_p1.Name = "tp_p1";
            this.tp_p1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tp_p1.Size = new System.Drawing.Size(852, 518);
            this.tp_p1.TabIndex = 0;
            this.tp_p1.Text = "General";
            this.tp_p1.UseVisualStyleBackColor = true;
            // 
            // br_cong
            // 
            this.br_cong.BackColor = System.Drawing.Color.Transparent;
            this.br_cong.Location = new System.Drawing.Point(7, 6);
            this.br_cong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.br_cong.Name = "br_cong";
            this.br_cong.Size = new System.Drawing.Size(357, 48);
            this.br_cong.TabIndex = 8;
            this.br_cong.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra2_click_buscar_button);
            // 
            // cb_opg
            // 
            this.cb_opg.FormattingEnabled = true;
            this.cb_opg.Items.AddRange(new object[] {
            "Producto",
            "Producto Finalizado"});
            this.cb_opg.Location = new System.Drawing.Point(171, 81);
            this.cb_opg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_opg.Name = "cb_opg";
            this.cb_opg.Size = new System.Drawing.Size(187, 23);
            this.cb_opg.TabIndex = 6;
            this.cb_opg.Text = "Elija una opción";
            // 
            // lb_pg
            // 
            this.lb_pg.AutoSize = true;
            this.lb_pg.Location = new System.Drawing.Point(20, 84);
            this.lb_pg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pg.Name = "lb_pg";
            this.lb_pg.Size = new System.Drawing.Size(115, 15);
            this.lb_pg.TabIndex = 5;
            this.lb_pg.Text = "¿Qué desea ver?";
            // 
            // dg_cg
            // 
            this.dg_cg.AllowUserToAddRows = false;
            this.dg_cg.AllowUserToDeleteRows = false;
            this.dg_cg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cg.Location = new System.Drawing.Point(24, 112);
            this.dg_cg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dg_cg.Name = "dg_cg";
            this.dg_cg.ReadOnly = true;
            this.dg_cg.Size = new System.Drawing.Size(805, 310);
            this.dg_cg.TabIndex = 4;
            this.dg_cg.Visible = false;
            // 
            // tp_2
            // 
            this.tp_2.Controls.Add(this.cb_opcion);
            this.tp_2.Controls.Add(this.lb_opcion);
            this.tp_2.Controls.Add(this.dg_consulta);
            this.tp_2.Controls.Add(this.br_conesp);
            this.tp_2.Controls.Add(this.gb_consultas);
            this.tp_2.Location = new System.Drawing.Point(4, 22);
            this.tp_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tp_2.Name = "tp_2";
            this.tp_2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tp_2.Size = new System.Drawing.Size(852, 520);
            this.tp_2.TabIndex = 1;
            this.tp_2.Text = "Búsqueda Especifica";
            this.tp_2.UseVisualStyleBackColor = true;
            // 
            // cb_opcion
            // 
            this.cb_opcion.FormattingEnabled = true;
            this.cb_opcion.Items.AddRange(new object[] {
            "Producto Finalizado",
            "Productos"});
            this.cb_opcion.Location = new System.Drawing.Point(192, 68);
            this.cb_opcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_opcion.Name = "cb_opcion";
            this.cb_opcion.Size = new System.Drawing.Size(295, 23);
            this.cb_opcion.TabIndex = 7;
            this.cb_opcion.Text = "Elija una opción";
            // 
            // lb_opcion
            // 
            this.lb_opcion.AutoSize = true;
            this.lb_opcion.Location = new System.Drawing.Point(23, 68);
            this.lb_opcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_opcion.Name = "lb_opcion";
            this.lb_opcion.Size = new System.Drawing.Size(146, 15);
            this.lb_opcion.TabIndex = 6;
            this.lb_opcion.Text = "¿Qué deseas buscar?";
            // 
            // dg_consulta
            // 
            this.dg_consulta.AllowUserToAddRows = false;
            this.dg_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_consulta.Location = new System.Drawing.Point(27, 279);
            this.dg_consulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dg_consulta.Name = "dg_consulta";
            this.dg_consulta.ReadOnly = true;
            this.dg_consulta.Size = new System.Drawing.Size(804, 230);
            this.dg_consulta.TabIndex = 3;
            this.dg_consulta.Visible = false;
            // 
            // br_conesp
            // 
            this.br_conesp.BackColor = System.Drawing.Color.Transparent;
            this.br_conesp.Location = new System.Drawing.Point(7, 6);
            this.br_conesp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.br_conesp.Name = "br_conesp";
            this.br_conesp.Size = new System.Drawing.Size(357, 48);
            this.br_conesp.TabIndex = 0;
            this.br_conesp.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra1_click_buscar_button);
            this.br_conesp.click_actualizar_button += new Navegador.Barra.delegadoButton(this.barra1_click_actualizar_button);
            // 
            // gb_consultas
            // 
            this.gb_consultas.Controls.Add(this.cb_pf);
            this.gb_consultas.Controls.Add(this.label3);
            this.gb_consultas.Controls.Add(this.rd_op3);
            this.gb_consultas.Controls.Add(this.rd_op2);
            this.gb_consultas.Controls.Add(this.rd_op1);
            this.gb_consultas.Location = new System.Drawing.Point(27, 99);
            this.gb_consultas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_consultas.Name = "gb_consultas";
            this.gb_consultas.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_consultas.Size = new System.Drawing.Size(804, 173);
            this.gb_consultas.TabIndex = 5;
            this.gb_consultas.TabStop = false;
            this.gb_consultas.Text = "Consultas Disponibles";
            this.gb_consultas.Visible = false;
            // 
            // cb_pf
            // 
            this.cb_pf.FormattingEnabled = true;
            this.cb_pf.Location = new System.Drawing.Point(157, 115);
            this.cb_pf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_pf.Name = "cb_pf";
            this.cb_pf.Size = new System.Drawing.Size(160, 23);
            this.cb_pf.TabIndex = 4;
            this.cb_pf.Text = "Elija una opción";
            this.cb_pf.Visible = false;
            this.cb_pf.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elija una opción";
            this.label3.Visible = false;
            // 
            // rd_op3
            // 
            this.rd_op3.AutoSize = true;
            this.rd_op3.Location = new System.Drawing.Point(412, 58);
            this.rd_op3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rd_op3.Name = "rd_op3";
            this.rd_op3.Size = new System.Drawing.Size(152, 19);
            this.rd_op3.TabIndex = 2;
            this.rd_op3.TabStop = true;
            this.rd_op3.Text = "Producto Especifico";
            this.rd_op3.UseVisualStyleBackColor = true;
            this.rd_op3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rd_op2
            // 
            this.rd_op2.AutoSize = true;
            this.rd_op2.Location = new System.Drawing.Point(201, 58);
            this.rd_op2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rd_op2.Name = "rd_op2";
            this.rd_op2.Size = new System.Drawing.Size(82, 19);
            this.rd_op2.TabIndex = 1;
            this.rd_op2.TabStop = true;
            this.rd_op2.Text = "Producto";
            this.rd_op2.UseVisualStyleBackColor = true;
            this.rd_op2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rd_op1
            // 
            this.rd_op1.AutoSize = true;
            this.rd_op1.Location = new System.Drawing.Point(40, 58);
            this.rd_op1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rd_op1.Name = "rd_op1";
            this.rd_op1.Size = new System.Drawing.Size(74, 19);
            this.rd_op1.TabIndex = 0;
            this.rd_op1.TabStop = true;
            this.rd_op1.Text = "Bodega";
            this.rd_op1.UseVisualStyleBackColor = true;
            this.rd_op1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // fr_consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 564);
            this.ControlBox = false;
            this.Controls.Add(this.tc_op);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fr_consultas";
            this.Text = "Consultas";
            this.tc_op.ResumeLayout(false);
            this.tp_p1.ResumeLayout(false);
            this.tp_p1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cg)).EndInit();
            this.tp_2.ResumeLayout(false);
            this.tp_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).EndInit();
            this.gb_consultas.ResumeLayout(false);
            this.gb_consultas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_op;
        private System.Windows.Forms.TabPage tp_p1;
        private System.Windows.Forms.ComboBox cb_opg;
        private System.Windows.Forms.Label lb_pg;
        private System.Windows.Forms.DataGridView dg_cg;
        private System.Windows.Forms.TabPage tp_2;
        private Navegador.Barra br_conesp;
        private System.Windows.Forms.DataGridView dg_consulta;
        private Navegador.Barra br_cong;
        private System.Windows.Forms.GroupBox gb_consultas;
        private System.Windows.Forms.ComboBox cb_opcion;
        private System.Windows.Forms.Label lb_opcion;
        private System.Windows.Forms.RadioButton rd_op2;
        private System.Windows.Forms.RadioButton rd_op1;
        private System.Windows.Forms.RadioButton rd_op3;
        private System.Windows.Forms.ComboBox cb_pf;
        private System.Windows.Forms.Label label3;

    }
}