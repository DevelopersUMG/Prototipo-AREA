using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;

namespace ADST_Colchoneria.Forms.Areas.Finanzas
{
    public partial class frm_historial_cuentas : Form
    {
        public frm_historial_cuentas()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("ADSTConnector");

        bool editar = false;
        string id;

        private void frm_historial_cuentas_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_historial_cuentas;");
            this.dataGridView1.Columns[0].Visible = false;

            comboBox1.DataSource = db.consulta_ComboBox("select id_cts, nombre_cta from tbt_nomenclatura;");
            comboBox1.DisplayMember = "nombre_cta";
            comboBox1.ValueMember = "id_cts";

        }

        private void barra1_click_nuevo_button()
        {
           // dateTimePicker1.Enabled = true;
           // dateTimePicker2.Enabled = true;
        }

        private void barra1_click_guardar_button()
        {
            if (dateTimePicker1.Enabled == true)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("fecha_inicio", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm"));
                dict.Add("fecha_final", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm"));
                dict.Add("id_cts", comboBox1.SelectedValue.ToString());

                if (editar)
                {
                    db.actualizar("tbt_historial_cuentas", dict, "idtbt_historial_cuentas=" + id);
                    editar = false;
                }
                else
                {


                    db.insertar("tbt_historial_cuentas", dict);
                }

                dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_historial_cuentas");
            }
            else
            {
                MessageBox.Show("Debe precionar la opcion nuevo");
            }
        }

        private void barra1_click_editar_button()
        {
          /*  editar = true;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;

            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();*/
        }

        private void barra1_click_eliminar_button()
        {
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string condicion = "idtbt_historial_cuentas=" + id;
                db.eliminar("tbt_historial_cuentas", condicion);
                dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_historial_cuentas");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void barra1_click_actualizar_button()
        {
            dataGridView1.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_historial_cuentas;");
            comboBox1.DataSource = db.consulta_ComboBox("select id_cuentas_banc, no_cuenta from tbt_cuentas_bancarias;");
            comboBox1.DisplayMember = "no_cuenta";
            comboBox1.ValueMember = "id_cuentas_banc";

            comboBox1.DataSource = db.consulta_ComboBox("select id_cts, nombre_cta from tbt_nomenclatura;");
            comboBox1.DisplayMember = "nombre_cta";
            comboBox1.ValueMember = "id_cts";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
