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
    public partial class frm_nomenclatura : Form
    {
        public frm_nomenclatura()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("ADSTConnector");

        bool editar = false;
        string id;

        private void barra1_click_nuevo_button()
        {

            if (tabControl1.SelectedIndex.ToString() == "0")
            {


                textBox2.ReadOnly = false;
                textBox1.ReadOnly = false;

                textBox2.ReadOnly = false;

                textBox3.ReadOnly = false;

                textBox4.ReadOnly = false;

                textBox5.ReadOnly = false;


                textBox6.ReadOnly = false;
            }
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;

            }
        }

        private void frm_nomenclatura_Load(object sender, EventArgs e)
        {
            // llena consulta de bancos
           

           dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_nomenclatura");
           this.dataGridView1.Columns[0].Visible = false;

           dataGridView2.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_historial_cuentas;");

            comboBox1.DataSource = db.consulta_ComboBox("select id_cuentas_banc, no_cuenta from tbt_cuentas_bancarias;");
            comboBox1.DisplayMember = "no_cuenta";
            comboBox1.ValueMember = "id_cuentas_banc";

            comboBox2.DataSource = db.consulta_ComboBox("select id_cts, nombre_cta from tbt_nomenclatura;");
            comboBox2.DisplayMember = "nombre_cta";
            comboBox2.ValueMember = "id_cts";


        }

        private void barra1_click_guardar_button()
        {
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                if (textBox1.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("nombre_cta", textBox1.Text);
                    dict.Add("total_cta", textBox2.Text);
                    dict.Add("saldo_actual", "0");
                    dict.Add("saldo_anterior", "0");
                    dict.Add("cargo", textBox3.Text);
                    dict.Add("tipo_cta", textBox4.Text);
                    dict.Add("tipo_reporte", textBox5.Text);
                    dict.Add("tipo_saldo", textBox6.Text);
                    dict.Add("id_cuentas_banc", comboBox1.SelectedValue.ToString());

                    if (editar)
                    {
                        db.actualizar("tbt_nomenclatura", dict, "id_cts=" + id);
                        editar = false;
                    }
                    else
                    {
                        db.insertar("tbt_nomenclatura", dict);
                    }

                    dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_nomenclatura");
                }
                else
                {
                    MessageBox.Show("Debe precionar la opcion nuevo");
                }
                textBox1.Text = "";
                textBox1.ReadOnly = true;
                textBox2.Text = "";
                textBox2.ReadOnly = true;
                textBox3.Text = "";
                textBox3.ReadOnly = true;
                textBox4.Text = "";
                textBox4.ReadOnly = true;
                textBox5.Text = "";
                textBox5.ReadOnly = true;
                textBox6.Text = "";
                textBox6.ReadOnly = true;
                //manejo de cuentas
                if (tabControl1.SelectedIndex.ToString() == "1")
                {
                    if (dateTimePicker1.Enabled == false)
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();
                        dict.Add("Fecha_inicio", dateTimePicker1.ToString());
                        dict.Add("Fecha_final", dateTimePicker2.ToString());
             
                        dict.Add("id_cts", comboBox2.SelectedValue.ToString());

                        if (editar)
                        {
                            db.actualizar("tbt_historial_cuentas", dict, "idtbt_historial_cuentas=" + id);
                            editar = false;
                        }
                        else
                        {
                            db.insertar("tbt_historial_cuentas", dict);
                        }

                        dataGridView2.DataSource = db.consulta_DataGridView("select *from tbt_historial_cuentas");
                    }
                    else
                    {
                        MessageBox.Show("Debe precionar la opcion nuevo");
                    }

                    
                  // dateTimePicker1.Enabled = false;
                  
                 // dateTimePicker2.Enabled = false;
                   
                }
            }
        }
      
        private void barra1_click_editar_button()
        {
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                editar = true;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                int i = dataGridView1.CurrentRow.Index;
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            }
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                editar = true;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
             
                int i = dataGridView2.CurrentRow.Index;
                id = dataGridView2.Rows[i].Cells[0].Value.ToString();
                textBox2.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
                textBox3.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
               
            }
            
        }

        private void barra1_click_eliminar_button()
        {
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                int i = dataGridView1.CurrentRow.Index;
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string condicion = "id_cts=" + id;
                    db.eliminar("tbt_nomenclatura", condicion);
                    dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_nomenclatura");
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            //manejo de cuentas bancarias
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                int i = dataGridView2.CurrentRow.Index;
                id = dataGridView2.Rows[i].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string condicion = "id_cuentas_banc=" + id;
                    db.eliminar("tbt_cuentas_bancarias", condicion);
                    dataGridView2.DataSource = db.consulta_DataGridView("select *from tbt_cuentas_bancarias");
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
