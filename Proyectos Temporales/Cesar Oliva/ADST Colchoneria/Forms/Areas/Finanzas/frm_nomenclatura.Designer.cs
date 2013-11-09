namespace ADST_Colchoneria.Forms.Areas.Finanzas
{
    partial class frm_nomenclatura
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
            this.dg_nome = new System.Windows.Forms.DataGridView();
            this.barra1 = new Navegador.Barra();
            this.tc_nomenclatura = new System.Windows.Forms.TabControl();
            this.tp_nomencl = new System.Windows.Forms.TabPage();
            this.tp_histcuen = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cb_catal = new System.Windows.Forms.ComboBox();
            this.dtp_ffin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fini = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_ffin = new System.Windows.Forms.Label();
            this.lb_fini = new System.Windows.Forms.Label();
            this.gb_datos_nom = new System.Windows.Forms.GroupBox();
            this.lb_cuent = new System.Windows.Forms.Label();
            this.cb_cuet = new System.Windows.Forms.ComboBox();
            this.tb_tiposal = new System.Windows.Forms.TextBox();
            this.tb_tiporep = new System.Windows.Forms.TextBox();
            this.tb_tipcue = new System.Windows.Forms.TextBox();
            this.tb_cargo = new System.Windows.Forms.TextBox();
            this.lb_tipsal = new System.Windows.Forms.Label();
            this.lb_tiprep = new System.Windows.Forms.Label();
            this.tb_totalc = new System.Windows.Forms.TextBox();
            this.tb_nomcue = new System.Windows.Forms.TextBox();
            this.lb_tipcue = new System.Windows.Forms.Label();
            this.lb_carg = new System.Windows.Forms.Label();
            this.lb_totcue = new System.Windows.Forms.Label();
            this.lb_nomcue = new System.Windows.Forms.Label();
            this.gb_datos_cue = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_nome)).BeginInit();
            this.tc_nomenclatura.SuspendLayout();
            this.tp_nomencl.SuspendLayout();
            this.tp_histcuen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gb_datos_nom.SuspendLayout();
            this.gb_datos_cue.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_nome
            // 
            this.dg_nome.AllowUserToAddRows = false;
            this.dg_nome.AllowUserToDeleteRows = false;
            this.dg_nome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_nome.Location = new System.Drawing.Point(12, 194);
            this.dg_nome.Name = "dg_nome";
            this.dg_nome.ReadOnly = true;
            this.dg_nome.Size = new System.Drawing.Size(570, 142);
            this.dg_nome.TabIndex = 1;
            this.dg_nome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(28, 11);
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
            // 
            // tc_nomenclatura
            // 
            this.tc_nomenclatura.Controls.Add(this.tp_nomencl);
            this.tc_nomenclatura.Controls.Add(this.tp_histcuen);
            this.tc_nomenclatura.Location = new System.Drawing.Point(28, 58);
            this.tc_nomenclatura.Name = "tc_nomenclatura";
            this.tc_nomenclatura.SelectedIndex = 0;
            this.tc_nomenclatura.Size = new System.Drawing.Size(621, 377);
            this.tc_nomenclatura.TabIndex = 3;
            // 
            // tp_nomencl
            // 
            this.tp_nomencl.Controls.Add(this.gb_datos_nom);
            this.tp_nomencl.Controls.Add(this.dg_nome);
            this.tp_nomencl.Location = new System.Drawing.Point(4, 22);
            this.tp_nomencl.Name = "tp_nomencl";
            this.tp_nomencl.Padding = new System.Windows.Forms.Padding(3);
            this.tp_nomencl.Size = new System.Drawing.Size(613, 351);
            this.tp_nomencl.TabIndex = 0;
            this.tp_nomencl.Text = "Nomenclatura";
            this.tp_nomencl.UseVisualStyleBackColor = true;
            // 
            // tp_histcuen
            // 
            this.tp_histcuen.Controls.Add(this.gb_datos_cue);
            this.tp_histcuen.Controls.Add(this.dataGridView2);
            this.tp_histcuen.Location = new System.Drawing.Point(4, 22);
            this.tp_histcuen.Name = "tp_histcuen";
            this.tp_histcuen.Padding = new System.Windows.Forms.Padding(3);
            this.tp_histcuen.Size = new System.Drawing.Size(613, 351);
            this.tp_histcuen.TabIndex = 1;
            this.tp_histcuen.Text = "Historial cuentas";
            this.tp_histcuen.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 178);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(564, 151);
            this.dataGridView2.TabIndex = 1;
            // 
            // cb_catal
            // 
            this.cb_catal.FormattingEnabled = true;
            this.cb_catal.Location = new System.Drawing.Point(419, 42);
            this.cb_catal.Name = "cb_catal";
            this.cb_catal.Size = new System.Drawing.Size(121, 21);
            this.cb_catal.TabIndex = 7;
            // 
            // dtp_ffin
            // 
            this.dtp_ffin.Enabled = false;
            this.dtp_ffin.Location = new System.Drawing.Point(118, 85);
            this.dtp_ffin.Name = "dtp_ffin";
            this.dtp_ffin.Size = new System.Drawing.Size(200, 20);
            this.dtp_ffin.TabIndex = 6;
            // 
            // dtp_fini
            // 
            this.dtp_fini.Enabled = false;
            this.dtp_fini.Location = new System.Drawing.Point(118, 38);
            this.dtp_fini.Name = "dtp_fini";
            this.dtp_fini.Size = new System.Drawing.Size(200, 20);
            this.dtp_fini.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Catalogo:";
            // 
            // lb_ffin
            // 
            this.lb_ffin.AutoSize = true;
            this.lb_ffin.Location = new System.Drawing.Point(45, 85);
            this.lb_ffin.Name = "lb_ffin";
            this.lb_ffin.Size = new System.Drawing.Size(62, 13);
            this.lb_ffin.TabIndex = 3;
            this.lb_ffin.Text = "Fecha final:";
            // 
            // lb_fini
            // 
            this.lb_fini.AutoSize = true;
            this.lb_fini.Location = new System.Drawing.Point(45, 38);
            this.lb_fini.Name = "lb_fini";
            this.lb_fini.Size = new System.Drawing.Size(67, 13);
            this.lb_fini.TabIndex = 2;
            this.lb_fini.Text = "Fecha inicio:";
            // 
            // gb_datos_nom
            // 
            this.gb_datos_nom.Controls.Add(this.lb_cuent);
            this.gb_datos_nom.Controls.Add(this.cb_cuet);
            this.gb_datos_nom.Controls.Add(this.tb_tiposal);
            this.gb_datos_nom.Controls.Add(this.tb_tiporep);
            this.gb_datos_nom.Controls.Add(this.tb_tipcue);
            this.gb_datos_nom.Controls.Add(this.tb_cargo);
            this.gb_datos_nom.Controls.Add(this.lb_tipsal);
            this.gb_datos_nom.Controls.Add(this.lb_tiprep);
            this.gb_datos_nom.Controls.Add(this.tb_totalc);
            this.gb_datos_nom.Controls.Add(this.tb_nomcue);
            this.gb_datos_nom.Controls.Add(this.lb_tipcue);
            this.gb_datos_nom.Controls.Add(this.lb_carg);
            this.gb_datos_nom.Controls.Add(this.lb_totcue);
            this.gb_datos_nom.Controls.Add(this.lb_nomcue);
            this.gb_datos_nom.Location = new System.Drawing.Point(22, 19);
            this.gb_datos_nom.Name = "gb_datos_nom";
            this.gb_datos_nom.Size = new System.Drawing.Size(560, 159);
            this.gb_datos_nom.TabIndex = 2;
            this.gb_datos_nom.TabStop = false;
            this.gb_datos_nom.Text = "Ingreso de Datos";
            // 
            // lb_cuent
            // 
            this.lb_cuent.AutoSize = true;
            this.lb_cuent.Location = new System.Drawing.Point(301, 81);
            this.lb_cuent.Name = "lb_cuent";
            this.lb_cuent.Size = new System.Drawing.Size(52, 13);
            this.lb_cuent.TabIndex = 27;
            this.lb_cuent.Text = "Cuentas: ";
            // 
            // cb_cuet
            // 
            this.cb_cuet.FormattingEnabled = true;
            this.cb_cuet.Location = new System.Drawing.Point(378, 78);
            this.cb_cuet.Name = "cb_cuet";
            this.cb_cuet.Size = new System.Drawing.Size(121, 21);
            this.cb_cuet.TabIndex = 26;
            // 
            // tb_tiposal
            // 
            this.tb_tiposal.Location = new System.Drawing.Point(378, 47);
            this.tb_tiposal.Name = "tb_tiposal";
            this.tb_tiposal.ReadOnly = true;
            this.tb_tiposal.Size = new System.Drawing.Size(121, 20);
            this.tb_tiposal.TabIndex = 25;
            // 
            // tb_tiporep
            // 
            this.tb_tiporep.Location = new System.Drawing.Point(378, 16);
            this.tb_tiporep.Name = "tb_tiporep";
            this.tb_tiporep.ReadOnly = true;
            this.tb_tiporep.Size = new System.Drawing.Size(121, 20);
            this.tb_tiporep.TabIndex = 24;
            // 
            // tb_tipcue
            // 
            this.tb_tipcue.Location = new System.Drawing.Point(123, 120);
            this.tb_tipcue.Name = "tb_tipcue";
            this.tb_tipcue.ReadOnly = true;
            this.tb_tipcue.Size = new System.Drawing.Size(127, 20);
            this.tb_tipcue.TabIndex = 23;
            // 
            // tb_cargo
            // 
            this.tb_cargo.Location = new System.Drawing.Point(123, 86);
            this.tb_cargo.Name = "tb_cargo";
            this.tb_cargo.ReadOnly = true;
            this.tb_cargo.Size = new System.Drawing.Size(127, 20);
            this.tb_cargo.TabIndex = 22;
            // 
            // lb_tipsal
            // 
            this.lb_tipsal.AutoSize = true;
            this.lb_tipsal.Location = new System.Drawing.Point(294, 50);
            this.lb_tipsal.Name = "lb_tipsal";
            this.lb_tipsal.Size = new System.Drawing.Size(59, 13);
            this.lb_tipsal.TabIndex = 21;
            this.lb_tipsal.Text = "Tipo saldo:";
            // 
            // lb_tiprep
            // 
            this.lb_tiprep.AutoSize = true;
            this.lb_tiprep.Location = new System.Drawing.Point(294, 19);
            this.lb_tiprep.Name = "lb_tiprep";
            this.lb_tiprep.Size = new System.Drawing.Size(67, 13);
            this.lb_tiprep.TabIndex = 20;
            this.lb_tiprep.Text = "Tipo reporte:";
            // 
            // tb_totalc
            // 
            this.tb_totalc.Location = new System.Drawing.Point(123, 50);
            this.tb_totalc.Name = "tb_totalc";
            this.tb_totalc.ReadOnly = true;
            this.tb_totalc.Size = new System.Drawing.Size(127, 20);
            this.tb_totalc.TabIndex = 19;
            // 
            // tb_nomcue
            // 
            this.tb_nomcue.Location = new System.Drawing.Point(123, 19);
            this.tb_nomcue.Name = "tb_nomcue";
            this.tb_nomcue.ReadOnly = true;
            this.tb_nomcue.Size = new System.Drawing.Size(127, 20);
            this.tb_nomcue.TabIndex = 18;
            // 
            // lb_tipcue
            // 
            this.lb_tipcue.AutoSize = true;
            this.lb_tipcue.Location = new System.Drawing.Point(34, 120);
            this.lb_tipcue.Name = "lb_tipcue";
            this.lb_tipcue.Size = new System.Drawing.Size(67, 13);
            this.lb_tipcue.TabIndex = 17;
            this.lb_tipcue.Text = "Tipo cuenta:";
            // 
            // lb_carg
            // 
            this.lb_carg.AutoSize = true;
            this.lb_carg.Location = new System.Drawing.Point(34, 86);
            this.lb_carg.Name = "lb_carg";
            this.lb_carg.Size = new System.Drawing.Size(38, 13);
            this.lb_carg.TabIndex = 16;
            this.lb_carg.Text = "Cargo:";
            // 
            // lb_totcue
            // 
            this.lb_totcue.AutoSize = true;
            this.lb_totcue.Location = new System.Drawing.Point(34, 56);
            this.lb_totcue.Name = "lb_totcue";
            this.lb_totcue.Size = new System.Drawing.Size(70, 13);
            this.lb_totcue.TabIndex = 15;
            this.lb_totcue.Text = "Total cuenta:";
            // 
            // lb_nomcue
            // 
            this.lb_nomcue.AutoSize = true;
            this.lb_nomcue.Location = new System.Drawing.Point(34, 22);
            this.lb_nomcue.Name = "lb_nomcue";
            this.lb_nomcue.Size = new System.Drawing.Size(83, 13);
            this.lb_nomcue.TabIndex = 14;
            this.lb_nomcue.Text = "Nombre cuenta:";
            // 
            // gb_datos_cue
            // 
            this.gb_datos_cue.Controls.Add(this.cb_catal);
            this.gb_datos_cue.Controls.Add(this.lb_fini);
            this.gb_datos_cue.Controls.Add(this.dtp_ffin);
            this.gb_datos_cue.Controls.Add(this.lb_ffin);
            this.gb_datos_cue.Controls.Add(this.dtp_fini);
            this.gb_datos_cue.Controls.Add(this.label10);
            this.gb_datos_cue.Location = new System.Drawing.Point(21, 29);
            this.gb_datos_cue.Name = "gb_datos_cue";
            this.gb_datos_cue.Size = new System.Drawing.Size(564, 126);
            this.gb_datos_cue.TabIndex = 2;
            this.gb_datos_cue.TabStop = false;
            this.gb_datos_cue.Text = "Ingreso de datos";
            // 
            // frm_nomenclatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 460);
            this.Controls.Add(this.tc_nomenclatura);
            this.Controls.Add(this.barra1);
            this.Name = "frm_nomenclatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomenclatura";
            this.Load += new System.EventHandler(this.frm_nomenclatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_nome)).EndInit();
            this.tc_nomenclatura.ResumeLayout(false);
            this.tp_nomencl.ResumeLayout(false);
            this.tp_histcuen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gb_datos_nom.ResumeLayout(false);
            this.gb_datos_nom.PerformLayout();
            this.gb_datos_cue.ResumeLayout(false);
            this.gb_datos_cue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_nome;
        private Navegador.Barra barra1;
        private System.Windows.Forms.TabControl tc_nomenclatura;
        private System.Windows.Forms.TabPage tp_nomencl;
        private System.Windows.Forms.TabPage tp_histcuen;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cb_catal;
        private System.Windows.Forms.DateTimePicker dtp_ffin;
        private System.Windows.Forms.DateTimePicker dtp_fini;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_ffin;
        private System.Windows.Forms.Label lb_fini;
        private System.Windows.Forms.GroupBox gb_datos_nom;
        private System.Windows.Forms.Label lb_cuent;
        private System.Windows.Forms.ComboBox cb_cuet;
        private System.Windows.Forms.TextBox tb_tiposal;
        private System.Windows.Forms.TextBox tb_tiporep;
        private System.Windows.Forms.TextBox tb_tipcue;
        private System.Windows.Forms.TextBox tb_cargo;
        private System.Windows.Forms.Label lb_tipsal;
        private System.Windows.Forms.Label lb_tiprep;
        private System.Windows.Forms.TextBox tb_totalc;
        private System.Windows.Forms.TextBox tb_nomcue;
        private System.Windows.Forms.Label lb_tipcue;
        private System.Windows.Forms.Label lb_carg;
        private System.Windows.Forms.Label lb_totcue;
        private System.Windows.Forms.Label lb_nomcue;
        private System.Windows.Forms.GroupBox gb_datos_cue;
    }
}