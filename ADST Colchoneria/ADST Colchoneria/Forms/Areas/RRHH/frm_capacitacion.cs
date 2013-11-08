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
    public partial class frm_capacitacion : Form
    {
        public frm_capacitacion()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("ADSTConnector");

        bool editar = false;
        string id;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void barra1_click_guardar_button()
        {
            if (nombredecapacitacion_text.ReadOnly == false)
            {
                // string tabla = "tbEmpleado";
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("tbCapacitacion_nom", nombredecapacitacion_text.Text);
                dict.Add("tbCapacitacion_descripcion", descripcion_text.Text);
                dict.Add("tbCapacitacion_ponente", ponente_text.Text);
                dict.Add("tbCapacitacion_area", area_text.Text);
                dict.Add("tbCapacitacion_fecha", fecha_text.Text);
                dict.Add("tbCapacitacion_hora", hora_text.Text);
                
                // db.insertar(tabla, dict);
                //dict.Add("id_cuentas_banc", comboBox1.SelectedValue.ToString());

                if (editar)
                {
                    db.actualizar("tbCapacitacion", dict, "tbCapacitacion_id=" + id);
                    editar = false;
                }
                else
                {
                    db.insertar("tbCapacitacion", dict);
                }

                dataGridView1.DataSource = db.consulta_DataGridView("select *from tbCapacitacion");
            }
            else
            {
                MessageBox.Show("Debe precionar la opcion nuevo");
            }
            nombredecapacitacion_text.Text = "";
            nombredecapacitacion_text.ReadOnly = true;
            descripcion_text.Text = "";
            descripcion_text.ReadOnly = true;
            ponente_text.Text = "";
            ponente_text.ReadOnly = true;
            area_text.Text = "";
            area_text.ReadOnly = true;
            fecha_text.Text = "";
            fecha_text.ReadOnly = true;
            hora_text.Text = "";
            hora_text.ReadOnly = true;
            

            //manejo de cuentas
        }

        private void barra1_click_nuevo_button()
        {
            nombredecapacitacion_text.ReadOnly = false;
            descripcion_text.ReadOnly = false;
            ponente_text.ReadOnly = false;
            area_text.ReadOnly = false;
            fecha_text.ReadOnly = false;
            hora_text.ReadOnly = false;
            
        }

        private void barra1_click_editar_button()
        {

            editar = true;
            nombredecapacitacion_text.ReadOnly = false;
            descripcion_text.ReadOnly = false;
            ponente_text.ReadOnly = false;
            area_text.ReadOnly = false;
            fecha_text.ReadOnly = false;
            hora_text.ReadOnly = false;
            
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();
            nombredecapacitacion_text.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            descripcion_text.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            ponente_text.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            area_text.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            fecha_text.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            hora_text.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            
        }

        private void barra1_click_buscar_button()
        {
            dataGridView1.DataSource = db.consulta_DataGridView("SELECT * FROM tbCapacitacion WHERE tbCapacitacion_nom LIKE '" + nombredecapacitacion_text.Text + "%'");
            nombredecapacitacion_text.Text = "";
            nombredecapacitacion_text.ReadOnly = true;

            dataGridView1.DataSource = db.consulta_DataGridView("SELECT * FROM tbCapacitacion WHERE tbCapacitacion_descripcion LIKE '" + descripcion_text.Text + "%'");
            descripcion_text.Text = "";
            descripcion_text.ReadOnly = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.consulta_DataGridView("select *from tbCapacitacion");
            this.dataGridView1.Columns[0].Visible = false; // llena consulta de cuentas dataGridView2.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_cuentas_bancarias;");

            //dataGridView2.DataSource = db.consulta_DataGridView("select e.tbEmpleado_idEmple, e.tbEmpleado_nomEmple from tbEmpleado ");
            string query = "select e.tbEmpleado_idEmple, e.tbEmpleado_nomEmple, c.tbCapacitacion_nom from tbEmpleado e, tbCapacitacion c where e.tbCapacitacion_tbCapacitacion_id = c.tbCapacitacion_id";
            dataGridView2.DataSource = db.consulta_DataGridView(query);
            //dataGridView2.Columns[0].Visible = false;
            //dataGridView2.Columns[3].Visible = false;
            //dataGridView2.Focus();

        }

        private void barra1_click_eliminar_button()
        {

            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR EL DATO", "ELIMINACION DE DATO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string condicion = "tbCapacitacion_id=" + id;
                db.eliminar("tbCapacitacion", condicion);
                dataGridView1.DataSource = db.consulta_DataGridView("select *from tbCapacitacion");

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
