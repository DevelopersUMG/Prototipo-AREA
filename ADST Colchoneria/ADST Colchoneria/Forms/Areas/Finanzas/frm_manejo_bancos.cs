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


        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        
        bool editar = false;
        string id;

        public void actualiza()
        {
            try
            {
                cb_banc.DataSource = db.consulta_ComboBox("select idtbt_bancos, nomb_banco from tbt_bancos");
                cb_banc.DisplayMember = "nomb_banco";
                cb_banc.ValueMember = "idtbt_bancos";

                // llena consulta de bancos            
                dg_bancos.DataSource = db.consulta_DataGridView("select *from tbt_bancos;");
                dg_bancos.Columns[1].HeaderText = "Nombre del Banco";
                this.dg_bancos.Columns[0].Visible = false;


                string numero = this.dg_bancos.Rows.Count.ToString();
                int i = Convert.ToInt32(numero);
                if (i == 0)
                {

                }
                else
                {
                    //seleccionar la celda para la edicion
                    dg_bancos.CurrentCell = dg_bancos.Rows[0].Cells[1];
                }


                // llena consulta de cuentas
                dg_cuentas.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_cuentas_bancarias");
                dg_cuentas.Columns[1].HeaderText = "Numero de Cuenta";
                dg_cuentas.Columns[2].HeaderText = "Saldo Actual";
                dg_cuentas.Columns[3].HeaderText = "Saldo Anterior";
                this.dg_cuentas.Columns[0].Visible = false;
                this.dg_cuentas.Columns[4].Visible = false;
            }
            catch 
            {
            }
           

        }



        private void barra1_click_nuevo_button()
        {
            if (tb_bancos.SelectedIndex.ToString() == "0")
            {
                tb_nombanc.ReadOnly = false;
                tb_nombanc.Text = "";
                
            }
            if (tb_bancos.SelectedIndex.ToString() == "1")
            {
                tb_no_cuenta.ReadOnly = false;
                tb_saldoact.ReadOnly = false;
                tb_saldant.ReadOnly = false;
                tb_no_cuenta.Text = "";
                tb_saldoact.Text = "";
                tb_saldant.Text = "";
            }
        }

        private void frm_manejo_bancos_Load(object sender, EventArgs e)
        {
           actualiza();
        }

        private void barra1_click_guardar_button()
        {
           
            
            //manejo de bancos
            if (tb_bancos.SelectedIndex.ToString() == "0")
            {
                if (tb_nombanc.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("nomb_banco", tb_nombanc.Text);


                    if (editar)
                    {
                        db.actualizar("tbt_bancos", dict, "idtbt_bancos=" + id);
                        tb_nombanc.Text = "";
                        tb_nombanc.ReadOnly = true;
                        editar = false;

                    }
                    else
                    {

                        if (tb_nombanc.Text == "")
                        {
                            MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //MessageBox.Show("Error debe llenar todos los campos");
                        }
                        else
                        {
                            string numero = this.dg_bancos.Rows.Count.ToString();
                            int i = Convert.ToInt32(numero);
                            string compara;
                            bool ingresa = true;

                            for (int x = 0; x < i; x++)
                            {

                                compara = dg_bancos.Rows[x].Cells[1].Value.ToString();
                                if (compara.Equals(tb_nombanc.Text))
                                {
                                    MessageBox.Show("El banco " + tb_nombanc.Text + " ya existe", "Error en ingreso de bancos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tb_nombanc.Text = "";
                                    ingresa = false;
                                }

                            }

                            if (ingresa) {
                                db.insertar("tbt_bancos", dict);
                                tb_nombanc.Text = "";
                                tb_nombanc.ReadOnly = true;
                            }

                           
                        }
                                                
                    }

                    actualiza();

                }
                else
                {

                    
                }

                

            }


                //manejo de cuentas
                if (tb_bancos.SelectedIndex.ToString() == "1")
                {
                    if (tb_no_cuenta.ReadOnly == false)
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();
                        dict.Add("no_cuenta", tb_no_cuenta.Text);
                        dict.Add("saldo_actual", tb_saldoact.Text);
                        dict.Add("saldo_anterior", tb_saldant.Text);
                        dict.Add("idtbt_bancos", cb_banc.SelectedValue.ToString());

                        if (editar)
                        {
                            db.actualizar("tbt_cuentas_bancarias", dict, "id_cuentas_banc=" + id);
                            tb_no_cuenta.Text = "";
                            tb_saldoact.Text = "";
                            tb_saldant.Text = "";
                            tb_no_cuenta.ReadOnly=true;
                            tb_saldoact.ReadOnly = true;
                            tb_saldant.ReadOnly = true;
                            editar = false;
                        }
                        else
                        {
                            if (tb_no_cuenta.Text == "" || tb_saldoact.Text == "" || tb_saldant.Text == "")
                            {
                                MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {

                                string numero = this.dg_cuentas.Rows.Count.ToString();
                                int i = Convert.ToInt32(numero);
                                string compara;
                                bool ingresa = true;

                               
                                for (int x = 0; x < i; x++)
                                {
                                    compara = dg_cuentas.Rows[x].Cells[1].Value.ToString();
                                    if (compara.Equals(tb_no_cuenta.Text))
                                    {
                                        MessageBox.Show("El numero de cuenta " + tb_no_cuenta.Text + " ya existe", "Error en ingreso de bancos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        tb_no_cuenta.Text = "";
                                        ingresa = false;
                                    }
                                 
                                }

                                if (ingresa) {
                                    db.insertar("tbt_cuentas_bancarias", dict);
                                    tb_no_cuenta.Text = "";
                                    tb_no_cuenta.ReadOnly = true;
                                    tb_saldoact.Text = "";
                                    tb_saldoact.ReadOnly = true;
                                    tb_saldant.Text = "";
                                    tb_saldant.ReadOnly = true;
                                }                                                             
              
                            }

                        }
                        actualiza();
                   }
                    else
                    {
                        MessageBox.Show("Debe precionar la opcion nuevo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //MessageBox.Show("Debe precionar la opcion nuevo");
                    }

                    
                }
            
        }
        

        private void barra1_click_editar_button()
        {
             //manejo de bancos
            if (tb_bancos.SelectedIndex.ToString() == "0")
            {
                editar = true;
                tb_nombanc.ReadOnly = false;
                int i = dg_bancos.CurrentRow.Index;
                id = dg_bancos.Rows[i].Cells[0].Value.ToString();
                tb_nombanc.Text = dg_bancos.Rows[i].Cells[1].Value.ToString();

            }
            //manejo de cuentas bancarias
            if (tb_bancos.SelectedIndex.ToString() == "1")
            {
                editar = true;
                tb_no_cuenta.ReadOnly = false;
                tb_saldoact.ReadOnly = false;
                tb_saldant.ReadOnly = false;
                int i = dg_cuentas.CurrentRow.Index;
                id = dg_cuentas.Rows[i].Cells[0].Value.ToString();
                tb_no_cuenta.Text = dg_cuentas.Rows[i].Cells[1].Value.ToString();
                tb_saldoact.Text = dg_cuentas.Rows[i].Cells[2].Value.ToString();
                tb_saldant.Text = dg_cuentas.Rows[i].Cells[3].Value.ToString();
            }
        }

        private void barra1_click_eliminar_button()
        {
            //manejo de bancos
            if (tb_bancos.SelectedIndex.ToString() == "0")
            {
                int i = dg_bancos.CurrentRow.Index;
                id = dg_bancos.Rows[i].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string condicion = "idtbt_bancos=" + id;
                    db.eliminar("tbt_bancos", condicion);
                    actualiza();                    
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            //manejo de cuentas bancarias
            if (tb_bancos.SelectedIndex.ToString() == "1")
            {
                int i = dg_cuentas.CurrentRow.Index;
                id = dg_cuentas.Rows[i].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string condicion = "id_cuentas_banc=" + id;
                    db.eliminar("tbt_cuentas_bancarias", condicion);
                    dg_cuentas.DataSource = db.consulta_DataGridView("select *from tbt_cuentas_bancarias");
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            
           
        }

        private void barra1_click_buscar_button()
        {
            
            
           //manejo de bancos
            if (tb_bancos.SelectedIndex.ToString() == "0")
            {
                if (tb_nombanc.Text == "")
                {
                    MessageBox.Show("Debe llenar el campo de busqueda", "Informacion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    dg_bancos.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_bancos WHERE nomb_banco LIKE '" + tb_nombanc.Text + "%'");
                    tb_nombanc.Text = "";
                    tb_nombanc.ReadOnly = true;

                }
                
            }
            //manejo de cuentas bancarias
            if (tb_bancos.SelectedIndex.ToString() == "1")
            {

                    string busca = cb_banc.SelectedValue.ToString();
                    dg_cuentas.DataSource = db.consulta_DataGridView("select *from tbt_cuentas_bancarias where idtbt_bancos =" + busca + ";");

            }
                
                
            }
            
    




        private void barra1_click_imprimir_button()
        {
            //manejo de bancos
            if (tb_bancos.SelectedIndex.ToString() == "0")
            {
                
            }
            //manejo de cuentas bancarias
            if (tb_bancos.SelectedIndex.ToString() == "1")
            {

            } 
         
        }

        private void barra1_click_actualizar_button()
        {
            //manejo de bancos
            if (tb_bancos.SelectedIndex.ToString() == "0")
            {
                dg_bancos.DataSource = db.consulta_DataGridView("select *from tbt_bancos");
                this.dg_bancos.Columns[0].Visible = false;
            }
            //manejo de cuentas bancarias
            if (tb_bancos.SelectedIndex.ToString() == "1")
            {
                dg_cuentas.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_cuentas_bancarias;");
                cb_banc.DataSource = db.consulta_ComboBox("select idtbt_bancos, nomb_banco from tbt_bancos;");
                cb_banc.DisplayMember = "nomb_banco";
                cb_banc.ValueMember = "idtbt_bancos";
            
            }
        }



       

      
                      
        }


        
}
