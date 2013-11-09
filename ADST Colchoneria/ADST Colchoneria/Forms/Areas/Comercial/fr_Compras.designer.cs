namespace ADST_Colchoneria
{
    partial class fr_Compras
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
            this.tbldetalle = new System.Windows.Forms.DataGridView();
            this.cmbmoneda = new System.Windows.Forms.ComboBox();
            this.cmbproveedor = new System.Windows.Forms.ComboBox();
            this.lblproveedor = new System.Windows.Forms.Label();
            this.lblmoneda = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbbodega = new System.Windows.Forms.ComboBox();
            this.lblbodega = new System.Windows.Forms.Label();
            this.cmbtipopago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltipocompra = new System.Windows.Forms.Label();
            this.cmbtipodecompra = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.panelprimero = new System.Windows.Forms.Panel();
            this.barra1 = new Navegador.Barra();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblsumatotal = new System.Windows.Forms.Label();
            this.txtsumatotal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblproducto = new System.Windows.Forms.Label();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbldetalle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelprimero.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbldetalle
            // 
            this.tbldetalle.AllowUserToAddRows = false;
            this.tbldetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbldetalle.Location = new System.Drawing.Point(8, 3);
            this.tbldetalle.Name = "tbldetalle";
            this.tbldetalle.Size = new System.Drawing.Size(641, 207);
            this.tbldetalle.TabIndex = 0;
            this.tbldetalle.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tbldetalle_CellFormatting);
            this.tbldetalle.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.tbldetalle_RowsAdded);
            this.tbldetalle.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.tbldetalle_RowsRemoved);
            // 
            // cmbmoneda
            // 
            this.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmoneda.FormattingEnabled = true;
            this.cmbmoneda.Location = new System.Drawing.Point(372, 62);
            this.cmbmoneda.Name = "cmbmoneda";
            this.cmbmoneda.Size = new System.Drawing.Size(197, 21);
            this.cmbmoneda.TabIndex = 1;
            // 
            // cmbproveedor
            // 
            this.cmbproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbproveedor.FormattingEnabled = true;
            this.cmbproveedor.Location = new System.Drawing.Point(93, 62);
            this.cmbproveedor.Name = "cmbproveedor";
            this.cmbproveedor.Size = new System.Drawing.Size(206, 21);
            this.cmbproveedor.TabIndex = 2;
            // 
            // lblproveedor
            // 
            this.lblproveedor.AutoSize = true;
            this.lblproveedor.Location = new System.Drawing.Point(5, 62);
            this.lblproveedor.Name = "lblproveedor";
            this.lblproveedor.Size = new System.Drawing.Size(56, 13);
            this.lblproveedor.TabIndex = 4;
            this.lblproveedor.Text = "Proveedor";
            // 
            // lblmoneda
            // 
            this.lblmoneda.AutoSize = true;
            this.lblmoneda.Location = new System.Drawing.Point(322, 70);
            this.lblmoneda.Name = "lblmoneda";
            this.lblmoneda.Size = new System.Drawing.Size(46, 13);
            this.lblmoneda.TabIndex = 5;
            this.lblmoneda.Text = "Moneda";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbbodega);
            this.panel1.Controls.Add(this.lblbodega);
            this.panel1.Controls.Add(this.cmbtipopago);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbltipocompra);
            this.panel1.Controls.Add(this.cmbtipodecompra);
            this.panel1.Controls.Add(this.txtfecha);
            this.panel1.Controls.Add(this.lblfecha);
            this.panel1.Controls.Add(this.lblproveedor);
            this.panel1.Controls.Add(this.lblmoneda);
            this.panel1.Controls.Add(this.cmbmoneda);
            this.panel1.Controls.Add(this.cmbproveedor);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 124);
            this.panel1.TabIndex = 6;
            // 
            // cmbbodega
            // 
            this.cmbbodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbodega.FormattingEnabled = true;
            this.cmbbodega.Location = new System.Drawing.Point(372, 35);
            this.cmbbodega.Name = "cmbbodega";
            this.cmbbodega.Size = new System.Drawing.Size(197, 21);
            this.cmbbodega.TabIndex = 13;
            // 
            // lblbodega
            // 
            this.lblbodega.AutoSize = true;
            this.lblbodega.Location = new System.Drawing.Point(322, 37);
            this.lblbodega.Name = "lblbodega";
            this.lblbodega.Size = new System.Drawing.Size(44, 13);
            this.lblbodega.TabIndex = 12;
            this.lblbodega.Text = "Bodega";
            // 
            // cmbtipopago
            // 
            this.cmbtipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipopago.FormattingEnabled = true;
            this.cmbtipopago.Location = new System.Drawing.Point(93, 92);
            this.cmbtipopago.Name = "cmbtipopago";
            this.cmbtipopago.Size = new System.Drawing.Size(206, 21);
            this.cmbtipopago.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo Pago";
            // 
            // lbltipocompra
            // 
            this.lbltipocompra.AutoSize = true;
            this.lbltipocompra.Location = new System.Drawing.Point(5, 38);
            this.lbltipocompra.Name = "lbltipocompra";
            this.lbltipocompra.Size = new System.Drawing.Size(82, 13);
            this.lbltipocompra.TabIndex = 9;
            this.lbltipocompra.Text = "Tipo de Compra";
            // 
            // cmbtipodecompra
            // 
            this.cmbtipodecompra.BackColor = System.Drawing.SystemColors.Window;
            this.cmbtipodecompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipodecompra.FormattingEnabled = true;
            this.cmbtipodecompra.Location = new System.Drawing.Point(93, 35);
            this.cmbtipodecompra.Name = "cmbtipodecompra";
            this.cmbtipodecompra.Size = new System.Drawing.Size(206, 21);
            this.cmbtipodecompra.TabIndex = 8;
            this.cmbtipodecompra.SelectedValueChanged += new System.EventHandler(this.cmbtipodecompra_SelectedValueChanged);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(48, 4);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(200, 20);
            this.txtfecha.TabIndex = 7;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(5, 10);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(37, 13);
            this.lblfecha.TabIndex = 6;
            this.lblfecha.Text = "Fecha";
            // 
            // panelprimero
            // 
            this.panelprimero.Controls.Add(this.tbldetalle);
            this.panelprimero.Location = new System.Drawing.Point(6, 209);
            this.panelprimero.Name = "panelprimero";
            this.panelprimero.Size = new System.Drawing.Size(652, 213);
            this.panelprimero.TabIndex = 7;
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(2, 1);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(268, 42);
            this.barra1.TabIndex = 8;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            this.barra1.click_actualizar_button += new Navegador.Barra.delegadoButton(this.barra1_click_actualizar_button);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 488);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblsumatotal);
            this.tabPage1.Controls.Add(this.txtsumatotal);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panelprimero);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro Compra";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblsumatotal
            // 
            this.lblsumatotal.AutoSize = true;
            this.lblsumatotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsumatotal.Location = new System.Drawing.Point(415, 436);
            this.lblsumatotal.Name = "lblsumatotal";
            this.lblsumatotal.Size = new System.Drawing.Size(65, 18);
            this.lblsumatotal.TabIndex = 16;
            this.lblsumatotal.Text = "TOTAL:";
            // 
            // txtsumatotal
            // 
            this.txtsumatotal.Location = new System.Drawing.Point(487, 436);
            this.txtsumatotal.Name = "txtsumatotal";
            this.txtsumatotal.Size = new System.Drawing.Size(100, 20);
            this.txtsumatotal.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtcantidad);
            this.panel2.Controls.Add(this.lblcantidad);
            this.panel2.Controls.Add(this.lblproducto);
            this.panel2.Controls.Add(this.cmbproducto);
            this.panel2.Controls.Add(this.btnagregar);
            this.panel2.Location = new System.Drawing.Point(9, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 70);
            this.panel2.TabIndex = 15;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(278, 29);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(143, 20);
            this.txtcantidad.TabIndex = 18;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(293, 12);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(49, 13);
            this.lblcantidad.TabIndex = 17;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(34, 12);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(50, 13);
            this.lblproducto.TabIndex = 16;
            this.lblproducto.Text = "Producto";
            // 
            // cmbproducto
            // 
            this.cmbproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Location = new System.Drawing.Point(37, 29);
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(235, 21);
            this.cmbproducto.TabIndex = 15;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(427, 12);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(70, 46);
            this.btnagregar.TabIndex = 14;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 441);
            this.dataGridView1.TabIndex = 0;
            // 
            // fr_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 548);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.barra1);
            this.Name = "fr_Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbldetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelprimero.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tbldetalle;
        private System.Windows.Forms.ComboBox cmbmoneda;
        private System.Windows.Forms.ComboBox cmbproveedor;
        private System.Windows.Forms.Label lblproveedor;
        private System.Windows.Forms.Label lblmoneda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.ComboBox cmbtipodecompra;
        private System.Windows.Forms.Label lbltipocompra;
        private System.Windows.Forms.Panel panelprimero;
        private Navegador.Barra barra1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbtipopago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbodega;
        private System.Windows.Forms.Label lblbodega;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.ComboBox cmbproducto;
        private System.Windows.Forms.Label lblsumatotal;
        private System.Windows.Forms.TextBox txtsumatotal;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

