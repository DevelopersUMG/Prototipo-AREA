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
    public partial class frm_manejo_bancos : Form
    {
        public frm_manejo_bancos()
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
                textBox1.ReadOnly = false;
                textBox1.Text = "";
                
            }
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void frm_manejo_bancos_Load(object sender, EventArgs e)
        {
            // llena consulta de bancos
            dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_bancos;");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nombre de bancos";
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
            // llena consulta de cuentas
            dataGridView2.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_cuentas_bancarias;");


            comboBox1.DataSource = db.consulta_ComboBox("select idtbt_bancos, nomb_banco from tbt_bancos;");
            comboBox1.DisplayMember = "nomb_banco";
            comboBox1.ValueMember = "idtbt_bancos";
        }

        private void barra1_click_guardar_button()
        { if (textBox1.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("nomb_banco", textBox1.Text);


                    if (editar)
                    {
                        db.actualizar("tbt_bancos", dict, "idtbt_bancos=" + id);
                        textBox1.Text = "";
                        editar = false;

                    }
                    else
                    {

                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Error debe llenar todos los campos");
                        }
                        else
                        {
                            string numero = this.dataGridView1.Rows.Count.ToString();
                            int i = Convert.ToInt32(numero);
                            string compara;
                            bool ingresa = true;

                            for (int x = 0; x < i; x++)
                            {

                                compara = dataGridView1.Rows[x].Cells[1].Value.ToString();
                                if (compara.Equals(textBox1.Text))
                                {
                                    MessageBox.Show("El banco " + textBox1.Text + " ya existe", "Error en ingreso de bancos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBox1.Text = "";
                                    ingresa = false;
                                }

                            }

                            if (ingresa) {
                                db.insertar("tbt_bancos", dict);
                                textBox1.Text = "";
                                textBox1.ReadOnly = true;
                            }

                           
                        }
                                                
                    }

                    dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_bancos");

                }
                else
                {

                    MessageBox.Show("Debe precionar la opcion nuevo");
                }

           
            
            //manejo de bancos
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
               
                

            }


                //manejo de cuentas
                if (tabControl1.SelectedIndex.ToString() == "1")
                {
                    if (textBox2.ReadOnly == false)
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();
                        dict.Add("no_cuenta", textBox2.Text);
                        dict.Add("saldo_actual", textBox3.Text);
                        dict.Add("saldo_anterior", textBox4.Text);
                        dict.Add("idtbt_bancos", comboBox1.SelectedValue.ToString());

                        if (editar)
                        {
                            db.actualizar("tbt_cuentas_bancarias", dict, "id_cuentas_banc=" + id);
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            editar = false;
                        }
                        else
                        {
                            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                            {
                                MessageBox.Show("Error debe llenar todos los campos");
                            }
                            else
                            {

                                string numero = this.dataGridView2.Rows.Count.ToString();
                                int i = Convert.ToInt32(numero);
                                string compara;
                                bool ingresa = true;

                               
                                for (int x = 0; x < i; x++)
                                {
                                    compara = dataGridView2.Rows[x].Cells[1].Value.ToString();
                                    if (compara.Equals(textBox2.Text))
                                    {
                                        MessageBox.Show("El numero de cuenta " + textBox2.Text + " ya existe", "Error en ingreso de bancos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        textBox2.Text = "";
                                        ingresa = false;
                                    }
                                 
                                }

                                if (ingresa) {
                                    db.insertar("tbt_cuentas_bancarias", dict);
                                    textBox2.Text = "";
                                    textBox2.ReadOnly = true;
                                    textBox3.Text = "";
                                    textBox3.ReadOnly = true;
                                    textBox4.Text = "";
                                    textBox4.ReadOnly = true;
                                }                                                             
              
                            }

                        }

                        dataGridView2.DataSource = db.consulta_DataGridView("select *from tbt_cuentas_bancarias");
                    }
                    else
                    {
                        MessageBox.Show("Debe precionar la opcion nuevo");
                    }

                    
                }
            
        }
        

        private void barra1_click_editar_button()
        {
             //manejo de bancos
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                editar = true;
                textBox1.ReadOnly = false;
                int i = dataGridView1.CurrentRow.Index;
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();

            }
            //manejo de cuentas bancarias
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                editar = true;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                int i = dataGridView2.CurrentRow.Index;
                id = dataGridView2.Rows[i].Cells[0].Value.ToString();
                textBox2.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
                textBox3.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
                textBox4.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            }
        }

        private void barra1_click_eliminar_button()
        {
            //manejo de bancos
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                int i = dataGridView1.CurrentRow.Index;
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string condicion = "idtbt_bancos=" + id;
                    db.eliminar("tbt_bancos", condicion);
                    dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_bancos");
                    
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

        private void barra1_click_buscar_button()
        {
            
            
           //manejo de bancos
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                dataGridView1.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_bancos WHERE nomb_banco LIKE '" + textBox1.Text + "%'");
                textBox1.Text = "";
                textBox1.ReadOnly = true;

                // if (busca= ){   
            }
            //manejo de cuentas bancarias
            if (tabControl1.SelectedIndex.ToString() == "1")
            {

                /*
                string busca = textBox1.Text;
                dataGridView1.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_bancos WHERE nomb_banco LIKE '" + textBox1.Text + "%'");
                textBox1.Text = "";
                textBox1.ReadOnly = true;*/

                string busca = comboBox1.SelectedValue.ToString();
                dataGridView2.DataSource = db.consulta_DataGridView("select *from tbt_cuentas_bancarias where idtbt_bancos ="+busca+";");

            }
            
          

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string tab = tabControl1.SelectedIndex.ToString();
            MessageBox.Show(tab);
        }

        private void barra1_click_imprimir_button()
        {
            //manejo de bancos
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                
            }
            //manejo de cuentas bancarias
            if (tabControl1.SelectedIndex.ToString() == "1")
            {

            } 
         
        }

        private void barra1_click_actualizar_button()
        {
            //manejo de bancos
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_bancos");
                this.dataGridView1.Columns[0].Visible = false;
            }
            //manejo de cuentas bancarias
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                dataGridView2.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_cuentas_bancarias;");
                comboBox1.DataSource = db.consulta_ComboBox("select idtbt_bancos, nomb_banco from tbt_bancos;");
                comboBox1.DisplayMember = "nomb_banco";
                comboBox1.ValueMember = "idtbt_bancos";
            
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       

      
                      
        }


        
}
