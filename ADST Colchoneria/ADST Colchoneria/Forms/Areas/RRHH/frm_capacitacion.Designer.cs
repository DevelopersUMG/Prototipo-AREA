namespace WindowsFormsApplication1
{
    partial class frm_capacitacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barra1 = new Navegador.Barra();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.hora_text = new System.Windows.Forms.TextBox();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.fecha_text = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.area_text = new System.Windows.Forms.TextBox();
            this.lbl_area = new System.Windows.Forms.Label();
            this.ponente_text = new System.Windows.Forms.TextBox();
            this.lbl_ponente = new System.Windows.Forms.Label();
            this.descripcion_text = new System.Windows.Forms.TextBox();
            this.lbl_nombredecapacitacion = new System.Windows.Forms.Label();
            this.nombredecapacitacion_text = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(25, 11);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(268, 42);
            this.barra1.TabIndex = 1;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            this.barra1.click_editar_button += new Navegador.Barra.delegadoButton(this.barra1_click_editar_button);
            this.barra1.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra1_click_buscar_button);
            this.barra1.click_eliminar_button += new Navegador.Barra.delegadoButton(this.barra1_click_eliminar_button);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_descripcion);
            this.panel1.Controls.Add(this.hora_text);
            this.panel1.Controls.Add(this.lbl_hora);
            this.panel1.Controls.Add(this.fecha_text);
            this.panel1.Controls.Add(this.lbl_fecha);
            this.panel1.Controls.Add(this.area_text);
            this.panel1.Controls.Add(this.lbl_area);
            this.panel1.Controls.Add(this.ponente_text);
            this.panel1.Controls.Add(this.lbl_ponente);
            this.panel1.Controls.Add(this.descripcion_text);
            this.panel1.Controls.Add(this.lbl_nombredecapacitacion);
            this.panel1.Controls.Add(this.nombredecapacitacion_text);
            this.panel1.Location = new System.Drawing.Point(25, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 286);
            this.panel1.TabIndex = 2;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(12, 47);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(89, 22);
            this.lbl_descripcion.TabIndex = 27;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // hora_text
            // 
            this.hora_text.Location = new System.Drawing.Point(196, 243);
            this.hora_text.Multiline = true;
            this.hora_text.Name = "hora_text";
            this.hora_text.ReadOnly = true;
            this.hora_text.Size = new System.Drawing.Size(585, 19);
            this.hora_text.TabIndex = 26;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(12, 240);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(45, 22);
            this.lbl_hora.TabIndex = 25;
            this.lbl_hora.Text = "Hora";
            // 
            // fecha_text
            // 
            this.fecha_text.Location = new System.Drawing.Point(196, 212);
            this.fecha_text.Name = "fecha_text";
            this.fecha_text.ReadOnly = true;
            this.fecha_text.Size = new System.Drawing.Size(585, 20);
            this.fecha_text.TabIndex = 24;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(12, 209);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(50, 22);
            this.lbl_fecha.TabIndex = 23;
            this.lbl_fecha.Text = "Fecha";
            // 
            // area_text
            // 
            this.area_text.Location = new System.Drawing.Point(196, 181);
            this.area_text.Name = "area_text";
            this.area_text.ReadOnly = true;
            this.area_text.Size = new System.Drawing.Size(585, 20);
            this.area_text.TabIndex = 22;
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area.Location = new System.Drawing.Point(12, 178);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(42, 22);
            this.lbl_area.TabIndex = 21;
            this.lbl_area.Text = "Area";
            // 
            // ponente_text
            // 
            this.ponente_text.Location = new System.Drawing.Point(196, 150);
            this.ponente_text.Name = "ponente_text";
            this.ponente_text.ReadOnly = true;
            this.ponente_text.Size = new System.Drawing.Size(585, 20);
            this.ponente_text.TabIndex = 20;
            // 
            // lbl_ponente
            // 
            this.lbl_ponente.AutoSize = true;
            this.lbl_ponente.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ponente.Location = new System.Drawing.Point(12, 147);
            this.lbl_ponente.Name = "lbl_ponente";
            this.lbl_ponente.Size = new System.Drawing.Size(65, 22);
            this.lbl_ponente.TabIndex = 19;
            this.lbl_ponente.Text = "Ponente";
            // 
            // descripcion_text
            // 
            this.descripcion_text.Location = new System.Drawing.Point(196, 47);
            this.descripcion_text.Multiline = true;
            this.descripcion_text.Name = "descripcion_text";
            this.descripcion_text.ReadOnly = true;
            this.descripcion_text.Size = new System.Drawing.Size(585, 92);
            this.descripcion_text.TabIndex = 18;
            // 
            // lbl_nombredecapacitacion
            // 
            this.lbl_nombredecapacitacion.AutoSize = true;
            this.lbl_nombredecapacitacion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombredecapacitacion.Location = new System.Drawing.Point(12, 15);
            this.lbl_nombredecapacitacion.Name = "lbl_nombredecapacitacion";
            this.lbl_nombredecapacitacion.Size = new System.Drawing.Size(182, 22);
            this.lbl_nombredecapacitacion.TabIndex = 17;
            this.lbl_nombredecapacitacion.Text = "Nombre De Capacitaciòn";
            // 
            // nombredecapacitacion_text
            // 
            this.nombredecapacitacion_text.Location = new System.Drawing.Point(196, 15);
            this.nombredecapacitacion_text.Name = "nombredecapacitacion_text";
            this.nombredecapacitacion_text.ReadOnly = true;
            this.nombredecapacitacion_text.Size = new System.Drawing.Size(585, 20);
            this.nombredecapacitacion_text.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(791, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 335);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 190);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 164);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalle Capacitación";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 164);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta Empleado Capacitacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(797, 162);
            this.dataGridView2.TabIndex = 0;
            // 
            // frm_capacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barra1);
            this.Name = "frm_capacitacion";
            this.Text = "Capacitaciones";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Navegador.Barra barra1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox hora_text;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.TextBox fecha_text;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox area_text;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.TextBox ponente_text;
        private System.Windows.Forms.Label lbl_ponente;
        private System.Windows.Forms.TextBox descripcion_text;
        private System.Windows.Forms.Label lbl_nombredecapacitacion;
        private System.Windows.Forms.TextBox nombredecapacitacion_text;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}