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
        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        bool editar = false;
        string id;

        public void actualizar()
        {
            if (dateTimePicker1.Enabled == true)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("fecha_inicio", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm"));
                dict.Add("fecha_final", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm"));


                if (editar)
                {
                    db.actualizar("tbt_historial_cuentas", dict, "idtbt_historial_cuentas=" + id);
                    editar = false;
                }
                else
                {


                    db.insertar("tbt_historial_cuentas", dict);
                }

                // dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_historial_cuentas");
            }
            else
            {
                MessageBox.Show("Debe precionar la opcion nuevo");
            }

        }

        private void frm_historial_cuentas_Load(object sender, EventArgs e)
        {
            
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

       
       

        private void barra1_click_actualizar_button()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizar();
            frm_nomenclatura frm = new frm_nomenclatura();
            frm.Visible = true;
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
