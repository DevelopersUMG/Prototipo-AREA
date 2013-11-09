namespace WindowsFormsApplication1
{
    partial class form_vendedores
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
            this.label2 = new System.Windows.Forms.Label();
            this.box_tipo_comision = new System.Windows.Forms.ComboBox();
            this.lbl_procentaje = new System.Windows.Forms.Label();
            this.text_nombre_vend = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo de Comision :";
            // 
            // box_tipo_comision
            // 
            this.box_tipo_comision.FormattingEnabled = true;
            this.box_tipo_comision.Location = new System.Drawing.Point(218, 48);
            this.box_tipo_comision.Name = "box_tipo_comision";
            this.box_tipo_comision.Size = new System.Drawing.Size(121, 21);
            this.box_tipo_comision.TabIndex = 17;
            // 
            // lbl_procentaje
            // 
            this.lbl_procentaje.AutoSize = true;
            this.lbl_procentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_procentaje.Location = new System.Drawing.Point(55, 83);
            this.lbl_procentaje.Name = "lbl_procentaje";
            this.lbl_procentaje.Size = new System.Drawing.Size(144, 24);
            this.lbl_procentaje.TabIndex = 15;
            this.lbl_procentaje.Text = "Porcentaje % :";
            // 
            // text_nombre_vend
            // 
            this.text_nombre_vend.Location = new System.Drawing.Point(218, 87);
            this.text_nombre_vend.Name = "text_nombre_vend";
            this.text_nombre_vend.Size = new System.Drawing.Size(121, 20);
            this.text_nombre_vend.TabIndex = 13;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(218, 141);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 20;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // Vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 228);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_tipo_comision);
            this.Controls.Add(this.lbl_procentaje);
            this.Controls.Add(this.text_nombre_vend);
            this.Name = "Vendedores";
            this.Text = "Vendedores";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox box_tipo_comision;
        private System.Windows.Forms.Label lbl_procentaje;
        private System.Windows.Forms.TextBox text_nombre_vend;
        private System.Windows.Forms.Button btn_aceptar;
    }
}