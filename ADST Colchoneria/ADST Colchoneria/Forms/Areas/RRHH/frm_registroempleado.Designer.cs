namespace WindowsFormsApplication1
{
    partial class frm_registroempleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barra1 = new Navegador.Barra();
            this.dg_registrodeempleado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sueldo_text = new System.Windows.Forms.TextBox();
            this.lbl_sueldo = new System.Windows.Forms.Label();
            this.idcapacitacion_cmb = new System.Windows.Forms.ComboBox();
            this.idtipoausencia_cmb = new System.Windows.Forms.ComboBox();
            this.idcomisiones_cmb = new System.Windows.Forms.ComboBox();
            this.lbl_idcapacitacion = new System.Windows.Forms.Label();
            this.lbl_idtipoausencia = new System.Windows.Forms.Label();
            this.lbl_idcomisiones = new System.Windows.Forms.Label();
            this.lbl_idpuesto = new System.Windows.Forms.Label();
            this.idpuesto_cmb = new System.Windows.Forms.ComboBox();
            this.licencia_text = new System.Windows.Forms.TextBox();
            this.lbl_licencia = new System.Windows.Forms.Label();
            this.segurosocial_text = new System.Windows.Forms.TextBox();
            this.lbl_segurosocial = new System.Windows.Forms.Label();
            this.direccion_text = new System.Windows.Forms.TextBox();
            this.estadocivil_text = new System.Windows.Forms.TextBox();
            this.dpi_text = new System.Windows.Forms.TextBox();
            this.telefono_text = new System.Windows.Forms.TextBox();
            this.nacionalidad_text = new System.Windows.Forms.TextBox();
            this.lbl_dpi = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_estadocivil = new System.Windows.Forms.Label();
            this.lbl_nacionalidad = new System.Windows.Forms.Label();
            this.genero_text = new System.Windows.Forms.TextBox();
            this.edad_text = new System.Windows.Forms.TextBox();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.nombre_text = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.apellido_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_registrodeempleado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(28, 11);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(292, 43);
            this.barra1.TabIndex = 9;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            this.barra1.click_editar_button += new Navegador.Barra.delegadoButton(this.barra1_click_editar_button);
            this.barra1.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra1_click_buscar_button);
            this.barra1.click_eliminar_button += new Navegador.Barra.delegadoButton(this.barra1_click_eliminar_button);
            this.barra1.click_actualizar_button += new Navegador.Barra.delegadoButton(this.barra1_click_actualizar_button);
            // 
            // dg_registrodeempleado
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_registrodeempleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dg_registrodeempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_registrodeempleado.DefaultCellStyle = dataGridViewCellStyle8;
            this.dg_registrodeempleado.Location = new System.Drawing.Point(28, 356);
            this.dg_registrodeempleado.Name = "dg_registrodeempleado";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_registrodeempleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dg_registrodeempleado.Size = new System.Drawing.Size(836, 150);
            this.dg_registrodeempleado.TabIndex = 10;
            this.dg_registrodeempleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_registrodeempleado_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.sueldo_text);
            this.panel1.Controls.Add(this.lbl_sueldo);
            this.panel1.Controls.Add(this.idcapacitacion_cmb);
            this.panel1.Controls.Add(this.idtipoausencia_cmb);
            this.panel1.Controls.Add(this.idcomisiones_cmb);
            this.panel1.Controls.Add(this.lbl_idcapacitacion);
            this.panel1.Controls.Add(this.lbl_idtipoausencia);
            this.panel1.Controls.Add(this.lbl_idcomisiones);
            this.panel1.Controls.Add(this.lbl_idpuesto);
            this.panel1.Controls.Add(this.idpuesto_cmb);
            this.panel1.Controls.Add(this.licencia_text);
            this.panel1.Controls.Add(this.lbl_licencia);
            this.panel1.Controls.Add(this.segurosocial_text);
            this.panel1.Controls.Add(this.lbl_segurosocial);
            this.panel1.Controls.Add(this.direccion_text);
            this.panel1.Controls.Add(this.estadocivil_text);
            this.panel1.Controls.Add(this.dpi_text);
            this.panel1.Controls.Add(this.telefono_text);
            this.panel1.Controls.Add(this.nacionalidad_text);
            this.panel1.Controls.Add(this.lbl_dpi);
            this.panel1.Controls.Add(this.lbl_direccion);
            this.panel1.Controls.Add(this.lbl_telefono);
            this.panel1.Controls.Add(this.lbl_estadocivil);
            this.panel1.Controls.Add(this.lbl_nacionalidad);
            this.panel1.Controls.Add(this.genero_text);
            this.panel1.Controls.Add(this.edad_text);
            this.panel1.Controls.Add(this.lbl_edad);
            this.panel1.Controls.Add(this.lbl_genero);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.nombre_text);
            this.panel1.Controls.Add(this.lbl_apellido);
            this.panel1.Controls.Add(this.apellido_text);
            this.panel1.Location = new System.Drawing.Point(28, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 259);
            this.panel1.TabIndex = 11;
            // 
            // sueldo_text
            // 
            this.sueldo_text.Location = new System.Drawing.Point(149, 171);
            this.sueldo_text.Name = "sueldo_text";
            this.sueldo_text.ReadOnly = true;
            this.sueldo_text.Size = new System.Drawing.Size(238, 20);
            this.sueldo_text.TabIndex = 67;
            // 
            // lbl_sueldo
            // 
            this.lbl_sueldo.AutoSize = true;
            this.lbl_sueldo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sueldo.Location = new System.Drawing.Point(27, 165);
            this.lbl_sueldo.Name = "lbl_sueldo";
            this.lbl_sueldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_sueldo.Size = new System.Drawing.Size(56, 22);
            this.lbl_sueldo.TabIndex = 66;
            this.lbl_sueldo.Text = "Sueldo";
            // 
            // idcapacitacion_cmb
            // 
            this.idcapacitacion_cmb.FormattingEnabled = true;
            this.idcapacitacion_cmb.Location = new System.Drawing.Point(542, 226);
            this.idcapacitacion_cmb.Name = "idcapacitacion_cmb";
            this.idcapacitacion_cmb.Size = new System.Drawing.Size(238, 21);
            this.idcapacitacion_cmb.TabIndex = 65;
            // 
            // idtipoausencia_cmb
            // 
            this.idtipoausencia_cmb.FormattingEnabled = true;
            this.idtipoausencia_cmb.Location = new System.Drawing.Point(542, 199);
            this.idtipoausencia_cmb.Name = "idtipoausencia_cmb";
            this.idtipoausencia_cmb.Size = new System.Drawing.Size(238, 21);
            this.idtipoausencia_cmb.TabIndex = 64;
            // 
            // idcomisiones_cmb
            // 
            this.idcomisiones_cmb.FormattingEnabled = true;
            this.idcomisiones_cmb.Location = new System.Drawing.Point(542, 172);
            this.idcomisiones_cmb.Name = "idcomisiones_cmb";
            this.idcomisiones_cmb.Size = new System.Drawing.Size(238, 21);
            this.idcomisiones_cmb.TabIndex = 63;
            // 
            // lbl_idcapacitacion
            // 
            this.lbl_idcapacitacion.AutoSize = true;
            this.lbl_idcapacitacion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idcapacitacion.Location = new System.Drawing.Point(407, 225);
            this.lbl_idcapacitacion.Name = "lbl_idcapacitacion";
            this.lbl_idcapacitacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_idcapacitacion.Size = new System.Drawing.Size(119, 22);
            this.lbl_idcapacitacion.TabIndex = 62;
            this.lbl_idcapacitacion.Text = "ID Capacitación";
            // 
            // lbl_idtipoausencia
            // 
            this.lbl_idtipoausencia.AutoSize = true;
            this.lbl_idtipoausencia.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idtipoausencia.Location = new System.Drawing.Point(407, 199);
            this.lbl_idtipoausencia.Name = "lbl_idtipoausencia";
            this.lbl_idtipoausencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_idtipoausencia.Size = new System.Drawing.Size(124, 22);
            this.lbl_idtipoausencia.TabIndex = 61;
            this.lbl_idtipoausencia.Text = "ID Tipo Ausencia";
            // 
            // lbl_idcomisiones
            // 
            this.lbl_idcomisiones.AutoSize = true;
            this.lbl_idcomisiones.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idcomisiones.Location = new System.Drawing.Point(407, 172);
            this.lbl_idcomisiones.Name = "lbl_idcomisiones";
            this.lbl_idcomisiones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_idcomisiones.Size = new System.Drawing.Size(108, 22);
            this.lbl_idcomisiones.TabIndex = 60;
            this.lbl_idcomisiones.Text = "ID Comisiones";
            // 
            // lbl_idpuesto
            // 
            this.lbl_idpuesto.AutoSize = true;
            this.lbl_idpuesto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idpuesto.Location = new System.Drawing.Point(407, 147);
            this.lbl_idpuesto.Name = "lbl_idpuesto";
            this.lbl_idpuesto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_idpuesto.Size = new System.Drawing.Size(76, 22);
            this.lbl_idpuesto.TabIndex = 59;
            this.lbl_idpuesto.Text = "ID Puesto";
            // 
            // idpuesto_cmb
            // 
            this.idpuesto_cmb.FormattingEnabled = true;
            this.idpuesto_cmb.Location = new System.Drawing.Point(542, 145);
            this.idpuesto_cmb.Name = "idpuesto_cmb";
            this.idpuesto_cmb.Size = new System.Drawing.Size(238, 21);
            this.idpuesto_cmb.TabIndex = 58;
            // 
            // licencia_text
            // 
            this.licencia_text.Location = new System.Drawing.Point(542, 119);
            this.licencia_text.Name = "licencia_text";
            this.licencia_text.ReadOnly = true;
            this.licencia_text.Size = new System.Drawing.Size(238, 20);
            this.licencia_text.TabIndex = 57;
            // 
            // lbl_licencia
            // 
            this.lbl_licencia.AutoSize = true;
            this.lbl_licencia.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_licencia.Location = new System.Drawing.Point(407, 117);
            this.lbl_licencia.Name = "lbl_licencia";
            this.lbl_licencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_licencia.Size = new System.Drawing.Size(66, 22);
            this.lbl_licencia.TabIndex = 56;
            this.lbl_licencia.Text = "Licencia";
            // 
            // segurosocial_text
            // 
            this.segurosocial_text.Location = new System.Drawing.Point(542, 93);
            this.segurosocial_text.Name = "segurosocial_text";
            this.segurosocial_text.ReadOnly = true;
            this.segurosocial_text.Size = new System.Drawing.Size(238, 20);
            this.segurosocial_text.TabIndex = 55;
            // 
            // lbl_segurosocial
            // 
            this.lbl_segurosocial.AutoSize = true;
            this.lbl_segurosocial.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segurosocial.Location = new System.Drawing.Point(407, 91);
            this.lbl_segurosocial.Name = "lbl_segurosocial";
            this.lbl_segurosocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_segurosocial.Size = new System.Drawing.Size(102, 22);
            this.lbl_segurosocial.TabIndex = 54;
            this.lbl_segurosocial.Text = "Seguro Social";
            // 
            // direccion_text
            // 
            this.direccion_text.Location = new System.Drawing.Point(542, 67);
            this.direccion_text.Name = "direccion_text";
            this.direccion_text.ReadOnly = true;
            this.direccion_text.Size = new System.Drawing.Size(238, 20);
            this.direccion_text.TabIndex = 53;
            // 
            // estadocivil_text
            // 
            this.estadocivil_text.Location = new System.Drawing.Point(542, 41);
            this.estadocivil_text.Name = "estadocivil_text";
            this.estadocivil_text.ReadOnly = true;
            this.estadocivil_text.Size = new System.Drawing.Size(238, 20);
            this.estadocivil_text.TabIndex = 52;
            // 
            // dpi_text
            // 
            this.dpi_text.Location = new System.Drawing.Point(149, 145);
            this.dpi_text.Name = "dpi_text";
            this.dpi_text.ReadOnly = true;
            this.dpi_text.Size = new System.Drawing.Size(238, 20);
            this.dpi_text.TabIndex = 51;
            // 
            // telefono_text
            // 
            this.telefono_text.Location = new System.Drawing.Point(149, 119);
            this.telefono_text.Name = "telefono_text";
            this.telefono_text.ReadOnly = true;
            this.telefono_text.Size = new System.Drawing.Size(238, 20);
            this.telefono_text.TabIndex = 50;
            // 
            // nacionalidad_text
            // 
            this.nacionalidad_text.Location = new System.Drawing.Point(149, 93);
            this.nacionalidad_text.Name = "nacionalidad_text";
            this.nacionalidad_text.ReadOnly = true;
            this.nacionalidad_text.Size = new System.Drawing.Size(238, 20);
            this.nacionalidad_text.TabIndex = 49;
            // 
            // lbl_dpi
            // 
            this.lbl_dpi.AutoSize = true;
            this.lbl_dpi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dpi.Location = new System.Drawing.Point(25, 138);
            this.lbl_dpi.Name = "lbl_dpi";
            this.lbl_dpi.Size = new System.Drawing.Size(37, 22);
            this.lbl_dpi.TabIndex = 48;
            this.lbl_dpi.Text = "DPI";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(407, 64);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_direccion.Size = new System.Drawing.Size(74, 22);
            this.lbl_direccion.TabIndex = 47;
            this.lbl_direccion.Text = "Dirección";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(25, 116);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(66, 22);
            this.lbl_telefono.TabIndex = 46;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_estadocivil
            // 
            this.lbl_estadocivil.AutoSize = true;
            this.lbl_estadocivil.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadocivil.Location = new System.Drawing.Point(407, 39);
            this.lbl_estadocivil.Name = "lbl_estadocivil";
            this.lbl_estadocivil.Size = new System.Drawing.Size(91, 22);
            this.lbl_estadocivil.TabIndex = 45;
            this.lbl_estadocivil.Text = "Estado Civil";
            // 
            // lbl_nacionalidad
            // 
            this.lbl_nacionalidad.AutoSize = true;
            this.lbl_nacionalidad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nacionalidad.Location = new System.Drawing.Point(25, 91);
            this.lbl_nacionalidad.Name = "lbl_nacionalidad";
            this.lbl_nacionalidad.Size = new System.Drawing.Size(101, 22);
            this.lbl_nacionalidad.TabIndex = 44;
            this.lbl_nacionalidad.Text = "Nacionalidad";
            // 
            // genero_text
            // 
            this.genero_text.Location = new System.Drawing.Point(542, 15);
            this.genero_text.Name = "genero_text";
            this.genero_text.ReadOnly = true;
            this.genero_text.Size = new System.Drawing.Size(238, 20);
            this.genero_text.TabIndex = 43;
            // 
            // edad_text
            // 
            this.edad_text.Location = new System.Drawing.Point(149, 67);
            this.edad_text.Name = "edad_text";
            this.edad_text.ReadOnly = true;
            this.edad_text.Size = new System.Drawing.Size(238, 20);
            this.edad_text.TabIndex = 42;
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad.Location = new System.Drawing.Point(27, 61);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(46, 22);
            this.lbl_edad.TabIndex = 41;
            this.lbl_edad.Text = "Edad";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.Location = new System.Drawing.Point(407, 12);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(59, 22);
            this.lbl_genero.TabIndex = 40;
            this.lbl_genero.Text = "Gènero";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(27, 15);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(67, 22);
            this.lbl_nombre.TabIndex = 38;
            this.lbl_nombre.Text = "Nombre";
            // 
            // nombre_text
            // 
            this.nombre_text.Location = new System.Drawing.Point(149, 15);
            this.nombre_text.Name = "nombre_text";
            this.nombre_text.ReadOnly = true;
            this.nombre_text.Size = new System.Drawing.Size(238, 20);
            this.nombre_text.TabIndex = 36;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(27, 37);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(66, 22);
            this.lbl_apellido.TabIndex = 39;
            this.lbl_apellido.Text = "Apellido";
            // 
            // apellido_text
            // 
            this.apellido_text.Location = new System.Drawing.Point(149, 41);
            this.apellido_text.Name = "apellido_text";
            this.apellido_text.ReadOnly = true;
            this.apellido_text.Size = new System.Drawing.Size(238, 20);
            this.apellido_text.TabIndex = 37;
            this.apellido_text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // frm_registroempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondo4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg_registrodeempleado);
            this.Controls.Add(this.barra1);
            this.DoubleBuffered = true;
            this.Name = "frm_registroempleado";
            this.Text = "Registro De Empleado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_registrodeempleado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Navegador.Barra barra1;
        private System.Windows.Forms.DataGridView dg_registrodeempleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sueldo_text;
        private System.Windows.Forms.Label lbl_sueldo;
        private System.Windows.Forms.ComboBox idcapacitacion_cmb;
        private System.Windows.Forms.ComboBox idtipoausencia_cmb;
        private System.Windows.Forms.ComboBox idcomisiones_cmb;
        private System.Windows.Forms.Label lbl_idcapacitacion;
        private System.Windows.Forms.Label lbl_idtipoausencia;
        private System.Windows.Forms.Label lbl_idcomisiones;
        private System.Windows.Forms.Label lbl_idpuesto;
        private System.Windows.Forms.ComboBox idpuesto_cmb;
        private System.Windows.Forms.TextBox licencia_text;
        private System.Windows.Forms.Label lbl_licencia;
        private System.Windows.Forms.TextBox segurosocial_text;
        private System.Windows.Forms.Label lbl_segurosocial;
        private System.Windows.Forms.TextBox direccion_text;
        private System.Windows.Forms.TextBox estadocivil_text;
        private System.Windows.Forms.TextBox dpi_text;
        private System.Windows.Forms.TextBox telefono_text;
        private System.Windows.Forms.TextBox nacionalidad_text;
        private System.Windows.Forms.Label lbl_dpi;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_estadocivil;
        private System.Windows.Forms.Label lbl_nacionalidad;
        private System.Windows.Forms.TextBox genero_text;
        private System.Windows.Forms.TextBox edad_text;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox nombre_text;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox apellido_text;
    }
}

