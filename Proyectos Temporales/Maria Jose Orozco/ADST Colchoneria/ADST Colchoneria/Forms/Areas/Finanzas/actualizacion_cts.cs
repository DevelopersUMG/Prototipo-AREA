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
    public partial class actualizacion_cts : Form
    {
        public actualizacion_cts()
        {
            InitializeComponent();
            
        }

        DBConnect db = new DBConnect("ADSTConnector");
        bool editar = false;
        string id;

        private void actualizacion_cts_Load(object sender, EventArgs e)
        {
            // llena consulta de polizas


            dataGridView3.DataSource = db.consulta_DataGridView("select id_encabezado Numero_de_poliza, fecha Fecha, concepto Concepto from tbt_encabezado");
            
            dataGridView1.DataSource = db.consulta_DataGridView("select total Total from tbt_detalle");

           // dataGridView2.DataSource = db.consulta_DataGridView("select * from tbt_cuentas_bancarias");
          
         dataGridView2.DataSource = db.consulta_DataGridView("select * from tbt_cuentas_bancarias");

        }

        private void barra1_Load(object sender, EventArgs e)
        {

        }

        private void barra1_click_actualizar_button()
        {
            //manejo de cuentas
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                dataGridView2.DataSource = db.consulta_DataGridView("select *from tbt_nomenclatura");
                this.dataGridView1.Columns[0].Visible = false;
            }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barra1_click_editar_button()
        {
            //manejo de bancos
          if (tabControl1.SelectedIndex.ToString() == "0")
            {
                editar = true;
                textBox1.ReadOnly = false;
                int i = dataGridView2.CurrentRow.Index;
                id = dataGridView2.Rows[i].Cells[0].Value.ToString();
                textBox1.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();

            }
            //manejo de cuentas bancarias

            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                editar = true;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
           
                int i = dataGridView2.CurrentRow.Index;
                id = dataGridView2.Rows[i].Cells[0].Value.ToString();
                textBox1.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
                textBox2.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
                
            }
        }

        private void barra1_click_nuevo_button()
        {
            
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                
            }
        }

        private void barra1_click_guardar_button()
        {
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                if (textBox2.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("cargo", textBox1.Text);
                    dict.Add("saldo_actual", textBox2.Text);
                   

                  

                    dataGridView2.DataSource = db.consulta_DataGridView("select *from tbt_nomenclatura");
                }
                else
                {
                    MessageBox.Show("Debe precionar la opcion nuevo");
                }

                textBox1.Text = "";
                textBox2.ReadOnly = true;
                ;
            }
            
        }
    }
}
