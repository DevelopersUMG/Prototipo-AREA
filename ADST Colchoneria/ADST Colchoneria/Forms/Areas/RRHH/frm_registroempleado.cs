using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;

namespace WindowsFormsApplication1
{
    public partial class frm_registroempleado : Form
    {
        public frm_registroempleado()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("ADSTConnector");
 
        bool editar = false;
        string id;

        private void barra1_click_actualizar_button()
        {
            string tabla = "tbEmpleado";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("tbEmpleado_nomEmple", nombre_text.Text);
            dict.Add("tbEmpleado_apellEmple", apellido_text.Text);
            dict.Add("tbEmpleado_dpi", dpi_text.Text);
            dict.Add("tbEmpleado_edad", edad_text.Text);
            dict.Add("tbEmpleado_genero", genero_text.Text);
            dict.Add("tbEmpleado_nacionalidad", nacionalidad_text.Text);
            dict.Add("tbEmpleado_estadocivil", estadocivil_text.Text);
            dict.Add("tbEmpleado_tel", telefono_text.Text);
            dict.Add("tbEmpleado_direc", direccion_text.Text);
            dict.Add("tbEmpleado_noSegSocial", segurosocial_text.Text);
            dict.Add("tbEmpleado_licencia", licencia_text.Text);
            dict.Add("tbEmpleado_sueldo", sueldo_text.Text);


            string condicion = "tbEmpleado_idEmple=2";
            

            db.actualizar(tabla, dict, condicion);
          

        }

        private void barra1_click_guardar_button()
        {
             
                if (nombre_text.ReadOnly == false)
                {
           // string tabla = "tbEmpleado";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("tbEmpleado_nomEmple", nombre_text.Text);
            dict.Add("tbEmpleado_apellEmple", apellido_text.Text);
            dict.Add("tbEmpleado_dpi", dpi_text.Text);
            dict.Add("tbEmpleado_edad", edad_text.Text);
            dict.Add("tbEmpleado_genero", genero_text.Text);
            dict.Add("tbEmpleado_nacionalidad", nacionalidad_text.Text);
            dict.Add("tbEmpleado_estadocivil", estadocivil_text.Text);
            dict.Add("tbEmpleado_tel", telefono_text.Text);
            dict.Add("tbEmpleado_direc", direccion_text.Text);
            dict.Add("tbEmpleado_noSegSocial", segurosocial_text.Text);
            dict.Add("tbEmpleado_licencia", licencia_text.Text);
            dict.Add("tbEmpleado_sueldo", sueldo_text.Text);
            dict.Add("tbPuesto_tbPuesto_id", idpuesto_cmb.SelectedValue.ToString());
            dict.Add("tbComisiones_tbComisiones_id", idcomisiones_cmb.SelectedValue.ToString());
            dict.Add("tbTipoAusencia_tbTipoAusencia_id", idtipoausencia_cmb.SelectedValue.ToString());
            dict.Add("tbCapacitacion_tbCapacitacion_id", idcapacitacion_cmb.SelectedValue.ToString());
           // db.insertar(tabla, dict);
            //dict.Add("id_cuentas_banc", comboBox1.SelectedValue.ToString());
           
                    if (editar)
            {
                db.actualizar("tbEmpleado", dict, "tbEmpleado_idEmple=" + id);
                editar = false;
            }
            else
            {
                db.insertar("tbEmpleado", dict);
            }

            dg_registrodeempleado.DataSource = db.consulta_DataGridView("select *from tbEmpleado");
                }
                else
                {
                    MessageBox.Show("Debe precionar la opcion nuevo");
                }
                nombre_text.Text = "";
                nombre_text.ReadOnly = true;
                apellido_text.Text = "";
                apellido_text.ReadOnly = true;
                segurosocial_text.Text = "";
                segurosocial_text.ReadOnly = true;
                licencia_text.Text = "";
                licencia_text.ReadOnly = true;
                edad_text.Text = "";
                edad_text.ReadOnly = true;
                genero_text.Text = "";
                genero_text.ReadOnly = true;
                nacionalidad_text.Text = "";
                nacionalidad_text.ReadOnly = true;
                telefono_text.Text = "";
                telefono_text.ReadOnly = true;
                dpi_text.Text = "";
                dpi_text.ReadOnly = true;
                estadocivil_text.Text = "";
                estadocivil_text.ReadOnly = true;
                direccion_text.Text = "";
                direccion_text.ReadOnly = true;
                
                //manejo de cuentas

            
     
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void barra1_click_nuevo_button()
        {
            nombre_text.ReadOnly = false;
            apellido_text.ReadOnly = false;
            segurosocial_text.ReadOnly = false;
            licencia_text.ReadOnly = false;
            edad_text.ReadOnly = false;
            genero_text.ReadOnly = false;
            nacionalidad_text.ReadOnly = false;
            telefono_text.ReadOnly = false;
            dpi_text.ReadOnly = false;
            estadocivil_text.ReadOnly = false;
            direccion_text.ReadOnly = false;
            sueldo_text.ReadOnly = false;
            



        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dg_registrodeempleado.DataSource = db.consulta_DataGridView("select *from tbEmpleado");
            this.dg_registrodeempleado.Columns[0].Visible = false; // llena consulta de cuentas dataGridView2.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_cuentas_bancarias;");

            idpuesto_cmb.DataSource = db.consulta_ComboBox("select tbPuesto_id from tbPuesto;");
            idpuesto_cmb.DisplayMember = "tbPuesto_id";
            idpuesto_cmb.ValueMember = "tbPuesto_id";

            idcomisiones_cmb.DataSource = db.consulta_ComboBox("select tbComisiones_id from tbComisiones;");
            idcomisiones_cmb.DisplayMember = "tbComisiones_id";
            idcomisiones_cmb.ValueMember = "tbComisiones_id";

            idtipoausencia_cmb.DataSource = db.consulta_ComboBox("select tbTipoAusencia_id from tbTipoAusencia;");
            idtipoausencia_cmb.DisplayMember = "tbTipoAusencia_id";
            idtipoausencia_cmb.ValueMember = "tbTipoAusencia_id";

            idcapacitacion_cmb.DataSource = db.consulta_ComboBox("select tbCapacitacion_id from tbCapacitacion;");
            idcapacitacion_cmb.DisplayMember = "tbCapacitacion_id";
            idcapacitacion_cmb.ValueMember = "tbCapacitacion_id";





        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void barra1_click_editar_button()
        {
            
                editar = true;
                nombre_text.ReadOnly = false;
                apellido_text.ReadOnly = false;
                segurosocial_text.ReadOnly = false;
                licencia_text.ReadOnly = false;
                edad_text.ReadOnly = false;
                genero_text.ReadOnly = false;
                nacionalidad_text.ReadOnly = false;
                telefono_text.ReadOnly = false;
                dpi_text.ReadOnly = false;
                estadocivil_text.ReadOnly = false;
                direccion_text.ReadOnly = false;
                sueldo_text.ReadOnly = false;
                int i = dg_registrodeempleado.CurrentRow.Index;
                id = dg_registrodeempleado.Rows[i].Cells[0].Value.ToString();
                nombre_text.Text = dg_registrodeempleado.Rows[i].Cells[1].Value.ToString();
                apellido_text.Text = dg_registrodeempleado.Rows[i].Cells[2].Value.ToString();
                segurosocial_text.Text = dg_registrodeempleado.Rows[i].Cells[3].Value.ToString();
                licencia_text.Text = dg_registrodeempleado.Rows[i].Cells[4].Value.ToString();
                edad_text.Text = dg_registrodeempleado.Rows[i].Cells[5].Value.ToString();
                genero_text.Text = dg_registrodeempleado.Rows[i].Cells[6].Value.ToString();
                nacionalidad_text.Text = dg_registrodeempleado.Rows[i].Cells[7].Value.ToString();
                telefono_text.Text = dg_registrodeempleado.Rows[i].Cells[8].Value.ToString();
                dpi_text.Text = dg_registrodeempleado.Rows[i].Cells[9].Value.ToString();
                estadocivil_text.Text = dg_registrodeempleado.Rows[i].Cells[10].Value.ToString();
                direccion_text.Text = dg_registrodeempleado.Rows[i].Cells[11].Value.ToString();
                sueldo_text.Text = dg_registrodeempleado.Rows[i].Cells[12].Value.ToString();
        }

        private void barra1_click_buscar_button()
        {
            dg_registrodeempleado.DataSource = db.consulta_DataGridView("SELECT * FROM tbEmpleado WHERE tbEmpleado_nomEmple LIKE '" + nombre_text.Text + "%'");
            nombre_text.Text = "";
            nombre_text.ReadOnly = true;

            dg_registrodeempleado.DataSource = db.consulta_DataGridView("SELECT * FROM tbEmpleado WHERE tbEmpleado_apellEmple LIKE '" + apellido_text.Text + "%'");
            apellido_text.Text = "";
            apellido_text.ReadOnly = true;
        }

        private void barra1_click_eliminar_button()
        {
            
       int i = dg_registrodeempleado.CurrentRow.Index;
                id = dg_registrodeempleado.Rows[i].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR EL DATO", "ELIMINACION DE DATO", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string condicion = "tbEmpleado_idEmple=" + id;
                    db.eliminar("tbEmpleado", condicion);
                    dg_registrodeempleado.DataSource = db.consulta_DataGridView("select *from tbEmpleado");
                    
                }
                else if (dialogResult == DialogResult.No)
                {

                }

        }

        private void dg_registrodeempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
