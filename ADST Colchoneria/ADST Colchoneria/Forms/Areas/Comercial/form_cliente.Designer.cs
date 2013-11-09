namespace WindowsFormsApplication1
{
    partial class form_clientes
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
            this.text_nombre_cliente = new System.Windows.Forms.TextBox();
            this.text_nit = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_nit = new System.Windows.Forms.Label();
            this.box_departamento = new System.Windows.Forms.ComboBox();
            this.box_municipio = new System.Windows.Forms.ComboBox();
            this.label_departamento = new System.Windows.Forms.Label();
            this.label_municipio = new System.Windows.Forms.Label();
            this.grid_clientes = new System.Windows.Forms.DataGridView();
            this.label_direccion = new System.Windows.Forms.Label();
            this.text_direccion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(11, 11);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(269, 42);
            this.barra1.TabIndex = 0;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            this.barra1.click_editar_button += new Navegador.Barra.delegadoButton(this.barra1_click_editar_button);
            this.barra1.click_eliminar_button += new Navegador.Barra.delegadoButton(this.barra1_click_eliminar_button);
            this.barra1.click_actualizar_button += new Navegador.Barra.delegadoButton(this.barra1_click_actualizar_button);
            this.barra1.click_imprimir_button += new Navegador.Barra.delegadoButton(this.barra1_click_imprimir_button);
            // 
            // text_nombre_cliente
            // 
            this.text_nombre_cliente.Location = new System.Drawing.Point(127, 68);
            this.text_nombre_cliente.Name = "text_nombre_cliente";
            this.text_nombre_cliente.Size = new System.Drawing.Size(253, 20);
            this.text_nombre_cliente.TabIndex = 1;
            // 
            // text_nit
            // 
            this.text_nit.Location = new System.Drawing.Point(513, 68);
            this.text_nit.Name = "text_nit";
            this.text_nit.Size = new System.Drawing.Size(100, 20);
            this.text_nit.TabIndex = 2;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(12, 64);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(81, 20);
            this.label_nombre.TabIndex = 3;
            this.label_nombre.Text = "Nombre :";
            // 
            // label_nit
            // 
            this.label_nit.AutoSize = true;
            this.label_nit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nit.Location = new System.Drawing.Point(447, 64);
            this.label_nit.Name = "label_nit";
            this.label_nit.Size = new System.Drawing.Size(47, 20);
            this.label_nit.TabIndex = 4;
            this.label_nit.Text = "NIT :";
            // 
            // box_departamento
            // 
            this.box_departamento.FormattingEnabled = true;
            this.box_departamento.Location = new System.Drawing.Point(159, 112);
            this.box_departamento.Name = "box_departamento";
            this.box_departamento.Size = new System.Drawing.Size(121, 21);
            this.box_departamento.TabIndex = 5;
            this.box_departamento.SelectedIndexChanged += new System.EventHandler(this.box_departamento_SelectedIndexChanged);
            // 
            // box_municipio
            // 
            this.box_municipio.FormattingEnabled = true;
            this.box_municipio.Location = new System.Drawing.Point(431, 112);
            this.box_municipio.Name = "box_municipio";
            this.box_municipio.Size = new System.Drawing.Size(121, 21);
            this.box_municipio.TabIndex = 6;
            // 
            // label_departamento
            // 
            this.label_departamento.AutoSize = true;
            this.label_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_departamento.Location = new System.Drawing.Point(12, 112);
            this.label_departamento.Name = "label_departamento";
            this.label_departamento.Size = new System.Drawing.Size(129, 20);
            this.label_departamento.TabIndex = 7;
            this.label_departamento.Text = "Departamento:";
            this.label_departamento.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_municipio
            // 
            this.label_municipio.AutoSize = true;
            this.label_municipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_municipio.Location = new System.Drawing.Point(294, 112);
            this.label_municipio.Name = "label_municipio";
            this.label_municipio.Size = new System.Drawing.Size(94, 20);
            this.label_municipio.TabIndex = 8;
            this.label_municipio.Text = "Municipio :";
            // 
            // grid_clientes
            // 
            this.grid_clientes.AllowUserToAddRows = false;
            this.grid_clientes.AllowUserToDeleteRows = false;
            this.grid_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_clientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_clientes.Location = new System.Drawing.Point(11, 227);
            this.grid_clientes.Name = "grid_clientes";
            this.grid_clientes.ReadOnly = true;
            this.grid_clientes.Size = new System.Drawing.Size(648, 347);
            this.grid_clientes.TabIndex = 9;
            this.grid_clientes.SelectionChanged += new System.EventHandler(this.grid_clientes_SelectionChanged);
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion.Location = new System.Drawing.Point(12, 161);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(99, 20);
            this.label_direccion.TabIndex = 11;
            this.label_direccion.Text = "Direccion : ";
            // 
            // text_direccion
            // 
            this.text_direccion.Location = new System.Drawing.Point(127, 161);
            this.text_direccion.Name = "text_direccion";
            this.text_direccion.Size = new System.Drawing.Size(486, 20);
            this.text_direccion.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(11, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 146);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // form_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 586);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.text_direccion);
            this.Controls.Add(this.grid_clientes);
            this.Controls.Add(this.label_municipio);
            this.Controls.Add(this.label_departamento);
            this.Controls.Add(this.box_municipio);
            this.Controls.Add(this.box_departamento);
            this.Controls.Add(this.label_nit);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.text_nit);
            this.Controls.Add(this.text_nombre_cliente);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.panel1);
            this.Name = "form_clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.CLientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Barra barra1;
        private System.Windows.Forms.TextBox text_nombre_cliente;
        private System.Windows.Forms.TextBox text_nit;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_nit;
        private System.Windows.Forms.ComboBox box_departamento;
        private System.Windows.Forms.ComboBox box_municipio;
        private System.Windows.Forms.Label label_departamento;
        private System.Windows.Forms.Label label_municipio;
        private System.Windows.Forms.DataGridView grid_clientes;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.TextBox text_direccion;
        private System.Windows.Forms.Panel panel1;
    }
}

