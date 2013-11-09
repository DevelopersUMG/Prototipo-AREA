using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using ODBCConnect;


namespace ADST_Colchoneria.Forms.Areas.Finanzas
{
    public partial class frm_nomenclatura : Form
    {
        public frm_nomenclatura()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        bool editar = false;
        string id;

        private void barra1_click_nuevo_button()
        {



      
       

                tb_codigo.ReadOnly = false;

                tb_nombrecuenta.ReadOnly = false;

                tb_total.ReadOnly = false;

                tb_cargo.ReadOnly = false;

                tb_tipo.ReadOnly = false;
                
                radioButton1.Checked = true;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;


                
        }
        private OdbcConnection conexion = new OdbcConnection("DNS="+Properties.Settings.Default.odbc);
      

        public void actualiza()
        {

            string tipoc= "";

            cb_clasecuenta.DataSource = db.consulta_ComboBox("select id_cuentas_banc, no_cuenta from tbt_cuentas_bancarias;");
            cb_clasecuenta.DisplayMember = "no_cuenta";
            cb_clasecuenta.ValueMember = "id_cuentas_banc";

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
           // if ((radioButton1.Checked)||(radioButton2.Checked))            
           // {
             //   MessageBox.Show("Solo debe seleccionarse uno ","Error de selecccion"  ,MessageBoxButtons.OK, MessageBoxIcon.Error);

           // }

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
          //  if ((radioButton1.Checked) || (radioButton2.Checked))
          //  {
             //   MessageBox.Show("Solo debe seleccionarse uno ", "Error de selecccion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}

 

            

        }
        private void frm_nomenclatura_Load(object sender, EventArgs e)
        {
            // llena consulta de bancos


            actualiza();


        }

        OdbcConnection DbConnection = new OdbcConnection("DSN=ADSTConnector");

        private int periodo()
        {
            //MessageBox.Show("DNS=" + Properties.Settings.Default.odbc);
            int i = 0;
            try {

                DbConnection.Open();
                OdbcCommand DbCommand = DbConnection.CreateCommand();
                DbCommand.CommandText = "select * from tbt_historial_cuentas;";
                OdbcDataReader DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {
                    i++;
                }
                conexion.Close();
                DbReader.Close();
                DbCommand.Dispose();

            }
            catch(OdbcException exception)
            {
                MessageBox.Show(exception.Message);
            }
            

            return i;
        }


        private void barra1_click_guardar_button()
        {

            string tipoc1 = "";
            string tipoc2 = "";
            


            cb_clasecuenta.DataSource = db.consulta_ComboBox("select id_cuentas_banc, no_cuenta from tbt_cuentas_bancarias;");
            cb_clasecuenta.DisplayMember = "no_cuenta";
            cb_clasecuenta.ValueMember = "id_cuentas_banc";


            if (radioButton1.Checked)
            { tipoc1 = "Acumulativo";
            }

            if (radioButton2.Checked)
            { tipoc1 = "Con detalle";
            }
            // if ((radioButton1.Checked)||(radioButton2.Checked))            
            // {
            //   MessageBox.Show("Solo debe seleccionarse uno ","Error de selecccion"  ,MessageBoxButtons.OK, MessageBoxIcon.Error)
            if (radioButton3.Checked)
            { tipoc2 = "Deudor";

            }

            if (radioButton4.Checked)
            {    tipoc2 = "Acreedor";
            }

           
                if (tb_codigo.ReadOnly == false)
                {
                    
                    int idh=periodo();


                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("id_cts", tb_codigo.Text);
                    dict.Add("nombre_cta", tb_nombrecuenta.Text);
                    dict.Add("total_cta", tb_total.Text);
                    dict.Add("saldo_actual", "0");
                  //  dict.Add("tipo_cta", "0");
                    dict.Add("saldo_anterior", "0");
                    dict.Add("cargo", tb_cargo.Text);
                    dict.Add("tipo_cta", tipoc1);
                    dict.Add("tipo_reporte", tb_tipo.Text);
                    dict.Add("id_cuentas_banc", cb_clasecuenta.SelectedValue.ToString());
                    dict.Add("tipo_saldo", tipoc2);
                    dict.Add("idtbt_historial_cuentas", idh.ToString());


                    if (editar)
                    {
                        db.actualizar("tbt_nomenclatura", dict, "id_cts=" + id);
                        editar = false;
                    }
                    else
                    {

          
                        //------------------------------------------------
                       if (tb_codigo.Text == "")
                        {
                            MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                           
                        }                         
                       else
                       {
                           
                                db.insertar("tbt_nomenclatura", dict);
                                 tb_codigo.Text = "";

                                 //actualiza();

                tb_codigo.ReadOnly = true;
                tb_nombrecuenta.Text = "";
                tb_nombrecuenta.ReadOnly = true;
                tb_total.Text = "";
                tb_total.ReadOnly = true;
                tb_cargo.Text = "";
                tb_cargo.ReadOnly = true;
                tb_tipo.Text = "";
                tb_tipo.ReadOnly = true;
                
                
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
                
                tb_codigo.ReadOnly = false;
                tb_nombrecuenta.ReadOnly = false;
                tb_total.ReadOnly = false;
                tb_cargo.ReadOnly = false;
                tb_tipo.ReadOnly = false;
                
               
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
            
             /*   int i = dataGridView1.CurrentRow.Index;
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
            */

            //manejo de cuentas bancarias
          

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barra1_click_buscar_button()
        {
            //manejo de bancos
            
            /*    string busca = textBox1.Text;
                dataGridView1.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_nomenclatura WHERE nombre_cta LIKE '" + textBox1.Text + "%'");
                textBox1.Text = "";
                textBox1.ReadOnly = true;
            */
                // if (busca= ){   
            
            //manejo de cuentas bancarias
            
        }

        private void barra1_click_actualizar_button()
        {

          /*  dataGridView1.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_historial_cuentas;");
            comboBox1.DataSource = db.consulta_ComboBox("select id_cuentas_banc, no_cuenta from tbt_cuentas_bancarias;");
            comboBox1.DisplayMember = "no_cuenta";
            comboBox1.ValueMember = "id_cuentas_banc";

            comboBox1.DataSource = db.consulta_ComboBox("select id_cts, nombre_cta from tbt_nomenclatura;");
            comboBox1.DisplayMember = "nombre_cta";
            comboBox1.ValueMember = "id_cts";
           */
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
