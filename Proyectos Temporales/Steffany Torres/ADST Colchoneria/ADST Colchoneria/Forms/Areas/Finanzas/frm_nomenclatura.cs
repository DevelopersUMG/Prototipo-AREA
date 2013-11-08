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



      
       

                textBox1.ReadOnly = false;

                textBox2.ReadOnly = false;

                textBox3.ReadOnly = false;

                textBox4.ReadOnly = false;

                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;


                
        }

        public void actualiza()
        {

            string tipoc;

            comboBox2.DataSource = db.consulta_ComboBox("select id_cuentas_banc, no_cuenta from tbt_cuentas_bancarias;");
            comboBox2.DisplayMember = "no_cuenta";
            comboBox2.ValueMember = "id_cuentas_banc";

            //Tipo cuenta

            if (radioButton1.Checked)
            {

                // Do something when RadioButton is checked
                tipoc = "Acumulativo";


            }

            if (radioButton2.Checked)
            {

                // Do something here when RadioButton is not checked
                tipoc = "Con detalle";


            }
            if ((radioButton1.Checked)||(radioButton2.Checked))            
            {
                MessageBox.Show("Solo debe seleccionarse uno ","Error de selecccion"  ,MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //Origen saldo
            if (radioButton3.Checked)
            {

                // Do something when RadioButton is checked
                tipoc = "Deudor";


            }

            if (radioButton2.Checked)
            {

                // Do something here when RadioButton is not checked
                tipoc = "Acreedor";


            }
            if ((radioButton1.Checked) || (radioButton2.Checked))
            {
                MessageBox.Show("Solo debe seleccionarse uno ", "Error de selecccion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

 

            

        }
        private void frm_nomenclatura_Load(object sender, EventArgs e)
        {
            // llena consulta de bancos


            actualiza();


        }

        private void barra1_click_guardar_button()
        {
           
                if (textBox1.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("id_cts", textBox1.Text);
                    dict.Add("nombre_cta", textBox2.Text);
                    dict.Add("total_cta", textBox3.Text);
                    dict.Add("saldo_actual", "0");
                    dict.Add("saldo_anterior", "0");
                    dict.Add("cargo", textBox4.Text);
                    //dict.Add("tipo_cta", textBox4.Text);
                    dict.Add("tipo_reporte", textBox5.Text);
                    dict.Add("tipo_saldo", textBox6.Text);
                    dict.Add("id_cuentas_banc", comboBox2.SelectedValue.ToString());

                    if (editar)
                    {
                        db.actualizar("tbt_nomenclatura", dict, "id_cts=" + id);
                        editar = false;
                    }
                    else
                    {

                        //------------------------------------------------
                       if (textBox1.Text == "")
                        {
                            MessageBox.Show("Error debe llenar todos los campos");
                        }                         
                       else
                       {
                           
                                db.insertar("tbt_nomenclatura", dict);
                                 textBox1.Text = "";

                                 actualiza();

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
                
                            }

                           
                        }
                                                
                    }

                   // dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_nomenclatura");
    


                  

                   
                else
                {
                    MessageBox.Show("Debe precionar la opcion nuevo");
                }
               
                //manejo de cuentas*/


           

            
        }
      
        private void barra1_click_editar_button()
        {
            
                editar = true;
                
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
               
              /*  int i = dataGridView1.CurrentRow.Index;
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox7.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
           */
          
            
        }

        private void barra1_click_eliminar_button()
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
            

            //manejo de cuentas bancarias
          

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barra1_click_buscar_button()
        {
            //manejo de bancos
            
                string busca = textBox1.Text;
                dataGridView1.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_nomenclatura WHERE nombre_cta LIKE '" + textBox1.Text + "%'");
                textBox1.Text = "";
                textBox1.ReadOnly = true;

                // if (busca= ){   
            
            //manejo de cuentas bancarias
            
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
