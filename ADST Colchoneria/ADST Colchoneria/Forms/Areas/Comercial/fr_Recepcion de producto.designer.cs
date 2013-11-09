namespace ADST_Colchoneria
{
    partial class Recepcion_de_producto
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
            this.cb_Noorden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_Descripcion = new System.Windows.Forms.DataGridView();
            this.barra1 = new Navegador.Barra();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Producto = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Descripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Noorden
            // 
            this.cb_Noorden.FormattingEnabled = true;
            this.cb_Noorden.Location = new System.Drawing.Point(122, 105);
            this.cb_Noorden.Name = "cb_Noorden";
            this.cb_Noorden.Size = new System.Drawing.Size(172, 21);
            this.cb_Noorden.TabIndex = 0;
            this.cb_Noorden.SelectionChangeCommitted += new System.EventHandler(this.cb_Noorden_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orden de compra";
            // 
            // dg_Descripcion
            // 
            this.dg_Descripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Descripcion.Location = new System.Drawing.Point(21, 143);
            this.dg_Descripcion.Name = "dg_Descripcion";
            this.dg_Descripcion.Size = new System.Drawing.Size(557, 280);
            this.dg_Descripcion.TabIndex = 2;
            this.dg_Descripcion.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dg_Descripcion_RowsAdded);
            this.dg_Descripcion.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dg_Descripcion_RowsRemoved);
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(26, 11);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(268, 42);
            this.barra1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto";
            // 
            // cb_Producto
            // 
            this.cb_Producto.FormattingEnabled = true;
            this.cb_Producto.Location = new System.Drawing.Point(122, 74);
            this.cb_Producto.Name = "cb_Producto";
            this.cb_Producto.Size = new System.Drawing.Size(172, 21);
            this.cb_Producto.TabIndex = 5;
            this.cb_Producto.SelectedValueChanged += new System.EventHandler(this.cb_Producto_SelectedValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 430);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "TOTAL";
            // 
            // Recepcion_de_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_Producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.dg_Descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Noorden);
            this.Name = "Recepcion_de_producto";
            this.Text = "Recepcion_de_producto";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Descripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Noorden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_Descripcion;
        private Navegador.Barra barra1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Producto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}