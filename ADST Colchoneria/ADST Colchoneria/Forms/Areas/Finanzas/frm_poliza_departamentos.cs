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
    public partial class frm_poliza_departamentos : Form
    {
        public frm_poliza_departamentos()
        {
            InitializeComponent();
            this.cbcuenta.SelectedItem = null;
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);


        OdbcConnection DbConnection = new OdbcConnection("DSN=" + Properties.Settings.Default.odbc);


        int control = 0;
        string id = "";
        string tipo = "";
        int dif = 0;
        int nuevo = 0;
        bool editar = false;


        private void barra1_click_guardar_button_1()
        {

            if (groupBox1.Enabled == true||gbencabezado.Enabled==true||gbdetalle.Enabled==true)
            {


                if (control == 0)
                {
                    if (tbpoliza.Text == "")
                    {
                        MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else 
                    {
                        Dictionary<string, string> dict1 = new Dictionary<string, string>();
                        dict1.Add("nombre_cuenta", tbpoliza.Text);
                        db.insertar("poliza_departamentos", dict1);
                        groupBox1.Enabled = false;
                        gbencabezado.Enabled = true;
                    }                
                }
                if (control == 1)
                {
                    if (tbconcepto.Text == "")
                    {
                        MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else 
                    {
                        try
                        {
                            DbConnection.Open();
                            OdbcCommand DbCommand = DbConnection.CreateCommand();
                            DbCommand.CommandText = "select id_poliza from poliza_departamentos where nombre_cuenta='" + tbpoliza.Text + "';";
                            OdbcDataReader DbReader = DbCommand.ExecuteReader();

                            while (DbReader.Read())
                            {
                                id = DbReader["id_poliza"].ToString();
                            }
                            DbConnection.Close();
                        }
                        catch (OdbcException a)
                        {
                            MessageBox.Show(a.Message);
                        }

                        Dictionary<string, string> dict2 = new Dictionary<string, string>();
                        dict2.Add("fecha", datetpfecha.Value.Date.ToString("yyyy-MM-dd HH:mm"));
                        dict2.Add("concepto", tbconcepto.Text);
                        dict2.Add("id_poliza", id);
                        db.insertar("tbt_encabezado", dict2);
                        gbencabezado.Enabled = false;
                        gbdetalle.Enabled = true;

                    }
                    
                }

                if (control == 2)
                {
                    if (tbtotal.Text == "") 
                    {
                        MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try
                        {
                            DbConnection.Open();
                            OdbcCommand DbCommand = DbConnection.CreateCommand();
                            DbCommand.CommandText = "select tipo_cta from tbt_nomenclatura where id_cts=" + cbcuenta.ValueMember.ToString();
                            OdbcDataReader DbReader = DbCommand.ExecuteReader();

                            while (DbReader.Read())
                            {
                                tipo = DbReader["tipo_cta"].ToString();
                            }
                            DbConnection.Close();
                        }
                        catch (OdbcException a)
                        {
                            MessageBox.Show(a.Message);
                        }


                        Dictionary<string, string> dict3 = new Dictionary<string, string>();
                        dict3.Add("total", tbtotal.Text);
                        dict3.Add("tipo", tipo);
                        if (rbcargo.Checked)
                        {
                            dict3.Add("cargo", tbtotal.Text);
                            //MessageBox.Show("es de cargo");
                        }
                        if (rbabono.Checked)
                        {
                            dict3.Add("abono", tbtotal.Text);
                            //MessageBox.Show("es de abono");
                        }
                        dict3.Add("id_poliza", id);
                        dict3.Add("id_libro_diario", "1");
                        dict3.Add("id_cts", cbcuenta.SelectedValue.ToString());         //comboBox1.ValueMember.ToString()
                        db.insertar("tbt_detalle", dict3);
                        gbdetalle.Enabled = false;
                    }

                    
                }

                if (control == 2)
                {
                    actualiza();
                    nuevo++;

                }

              
                 control++;    
               
                   
               

            }
            else 
            {
                MessageBox.Show("Debe precionar el boton nuevo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

   
        }

        private void barra1_click_nuevo_button()
        {

            
            if (nuevo == 0) {
                groupBox1.Enabled = true;
            }
            if (nuevo == 1) 
            {
                control = 0;
                groupBox1.Enabled = true;
                tbpoliza.Text = "";
                tbconcepto.Text = "";
                tbtotal.Text = "";

                rbabono.Checked = false;
                rbcargo.Checked = false;
                nuevo = 0;

            }
  


           

        }

        public void actualiza() 
        {
            try
            {
                if (control != 2)
                {
                    cbcuenta.DataSource = db.consulta_ComboBox("select id_cts,nombre_cta from tbt_nomenclatura;");
                    cbcuenta.DisplayMember = "nombre_cta";
                    cbcuenta.ValueMember = "id_cts";
                }

                dgpolizas.DataSource = db.consulta_DataGridView("select *from tbt_detalle");
                dgpolizas.Columns[0].HeaderText = "ID";
                dgpolizas.Columns[1].Visible = false;
                dgpolizas.Columns[2].HeaderText = "Tipo de Cuenta";
                dgpolizas.Columns[3].HeaderText = "Cargo";
                dgpolizas.Columns[4].HeaderText = "Abono";
                dgpolizas.Columns[5].Visible = false;
                dgpolizas.Columns[6].Visible = false;
                dgpolizas.Columns[7].HeaderText = "Nomenclatura";

                string totalcargo = "";

                try
                {
                    DbConnection.Open();
                    OdbcCommand DbCommand = DbConnection.CreateCommand();
                    DbCommand.CommandText = "select sum(cargo) as totalcargo from tbt_detalle;";
                    OdbcDataReader DbReader = DbCommand.ExecuteReader();

                    while (DbReader.Read())
                    {
                        totalcargo = DbReader["totalcargo"].ToString();
                    }
                    DbConnection.Close();
                }
                catch (OdbcException a)
                {
                    MessageBox.Show(a.Message);
                }

                label9.Text = totalcargo;
                if (label9.Text == "") {
                    label9.Text = "0";
                }
                



                string totalabono = "";

                try
                {
                    DbConnection.Open();
                    OdbcCommand DbCommand = DbConnection.CreateCommand();
                    DbCommand.CommandText = "select sum(abono) as totalabono from tbt_detalle;";
                    OdbcDataReader DbReader = DbCommand.ExecuteReader();

                    while (DbReader.Read())
                    {
                        totalabono = DbReader["totalabono"].ToString();
                    }
                    DbConnection.Close();
                }
                catch (OdbcException a)
                {
                    MessageBox.Show(a.Message);
                }

                label10.Text = totalabono;
                if (label10.Text == "")
                {
                    label10.Text = "0";
                }
                




                dif = Int32.Parse(label9.Text) - Int32.Parse(label10.Text);
                if (dif != 0)
                {
                    label11.ForeColor = System.Drawing.Color.Red;
                }
                else {
                    label11.ForeColor = System.Drawing.Color.White;
                }
                label11.Text = dif.ToString();
            }
            catch 
            {
            }
         


        }

        private void frm_poliza_departamentos_Load(object sender, EventArgs e)
        {
            actualiza();
        }

        private void frm_poliza_departamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dif != 0)
            {
                MessageBox.Show("EL diferencial debe estar en cero", "Error de diferencial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                switch (e.CloseReason)
                {
                    case CloseReason.UserClosing:
                        e.Cancel = true;
                        break;
                }       
            }
            else
            {
                

            }
        }

        private void barra1_click_actualizar_button()
        {
            actualiza();
        }

        private void barra1_click_eliminar_button()
        {
            int i = dgpolizas.CurrentRow.Index;
            id = dgpolizas.Rows[i].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string condicion = "id_detalle=" + id;
                db.eliminar("tbt_detalle", condicion);
                actualiza();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void barra1_click_editar_button()
        {

        }

        private void gbencabezado_Enter(object sender, EventArgs e)
        {

        }

        
    }       
}
