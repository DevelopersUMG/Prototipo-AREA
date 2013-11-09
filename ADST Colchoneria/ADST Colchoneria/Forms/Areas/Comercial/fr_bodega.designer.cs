namespace ADST_Colchoneria
{
    partial class fr_bodega
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
            this.dg_ver = new System.Windows.Forms.DataGridView();
            this.br_bodega = new Navegador.Barra();
            this.pn_in = new System.Windows.Forms.Panel();
            this.tb_serie = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.lb_serie = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ver)).BeginInit();
            this.pn_in.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_ver
            // 
            this.dg_ver.AllowUserToAddRows = false;
            this.dg_ver.AllowUserToDeleteRows = false;
            this.dg_ver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ver.Location = new System.Drawing.Point(16, 219);
            this.dg_ver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dg_ver.Name = "dg_ver";
            this.dg_ver.ReadOnly = true;
            this.dg_ver.Size = new System.Drawing.Size(768, 340);
            this.dg_ver.TabIndex = 0;
            // 
            // br_bodega
            // 
            this.br_bodega.BackColor = System.Drawing.Color.Transparent;
            this.br_bodega.Location = new System.Drawing.Point(15, 13);
            this.br_bodega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.br_bodega.Name = "br_bodega";
            this.br_bodega.Size = new System.Drawing.Size(357, 48);
            this.br_bodega.TabIndex = 1;
            this.br_bodega.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.br_bodega.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            this.br_bodega.click_editar_button += new Navegador.Barra.delegadoButton(this.barra1_click_editar_button);
            this.br_bodega.click_eliminar_button += new Navegador.Barra.delegadoButton(this.barra1_click_eliminar_button);
            this.br_bodega.click_actualizar_button += new Navegador.Barra.delegadoButton(this.barra1_click_actualizar_button);
            // 
            // pn_in
            // 
            this.pn_in.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pn_in.Controls.Add(this.tb_serie);
            this.pn_in.Controls.Add(this.tb_nombre);
            this.pn_in.Controls.Add(this.lb_serie);
            this.pn_in.Controls.Add(this.lb_nombre);
            this.pn_in.Location = new System.Drawing.Point(16, 95);
            this.pn_in.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pn_in.Name = "pn_in";
            this.pn_in.Size = new System.Drawing.Size(768, 118);
            this.pn_in.TabIndex = 2;
            this.pn_in.Visible = false;
            // 
            // tb_serie
            // 
            this.tb_serie.Location = new System.Drawing.Point(121, 60);
            this.tb_serie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_serie.Name = "tb_serie";
            this.tb_serie.Size = new System.Drawing.Size(237, 21);
            this.tb_serie.TabIndex = 6;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(121, 30);
            this.tb_nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(237, 21);
            this.tb_nombre.TabIndex = 4;
            // 
            // lb_serie
            // 
            this.lb_serie.AutoSize = true;
            this.lb_serie.Location = new System.Drawing.Point(32, 63);
            this.lb_serie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_serie.Name = "lb_serie";
            this.lb_serie.Size = new System.Drawing.Size(41, 15);
            this.lb_serie.TabIndex = 5;
            this.lb_serie.Text = "Serie";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(32, 33);
            this.lb_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(58, 15);
            this.lb_nombre.TabIndex = 3;
            this.lb_nombre.Text = "Nombre";
            // 
            // fr_bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 591);
            this.ControlBox = false;
            this.Controls.Add(this.pn_in);
            this.Controls.Add(this.br_bodega);
            this.Controls.Add(this.dg_ver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fr_bodega";
            this.Text = "Bodega";
            this.Load += new System.EventHandler(this.bodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ver)).EndInit();
            this.pn_in.ResumeLayout(false);
            this.pn_in.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_ver;
        private Navegador.Barra br_bodega;
        private System.Windows.Forms.Panel pn_in;
        private System.Windows.Forms.TextBox tb_serie;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label lb_serie;
        private System.Windows.Forms.Label lb_nombre;
    }
}