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
    public partial class frm_actualizar_cts : Form
    {
        public frm_actualizar_cts()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("ADSTConnector");
        bool editar = false;
        string id;

        private void actualizar_cts_Load(object sender, EventArgs e)
        {
         
            actualiza();

            // llena consulta de polizas

            try {
                dataGridView3.DataSource = db.consulta_DataGridView("select id_encabezado Numero_de_poliza, fecha Fecha, concepto Concepto from tbt_encabezado");

                dataGridView1.DataSource = db.consulta_DataGridView("select total Total from tbt_detalle");
            }
            catch { }

            

        
        
        }

        private void barra1_click_editar_button()
        {
            //manejo de bancos
            if (tb_cta.SelectedIndex.ToString() == "0")
            {
                editar = true;
                tb_nomcta.ReadOnly = false;
                int i = dg_cuenta.CurrentRow.Index;
                id = dg_cuenta.Rows[i].Cells[0].Value.ToString();
                tb_nomcta.Text = dg_cuenta.Rows[i].Cells[1].Value.ToString();

            }
        }

        private void barra1_click_actualizar_button()
        {


            if (tb_cta.SelectedIndex.ToString() == "0")
            {
                editar = true;
                tb_nomcta.ReadOnly = false;
                int i = dg_cuenta.CurrentRow.Index;
                id = dg_cuenta.Rows[i].Cells[0].Value.ToString();
                tb_nomcta.Text = dg_cuenta.Rows[i].Cells[1].Value.ToString();

            }


        }




        public void actualiza()
        {
            // llena consulta de bancos
            
            //llena consuta de cuentas

           // dg_cuenta.DataSource = db.consulta_DataGridView("select id_cts, nombre_cta as 'Nombre del Banco' from tbt_nomenclatura");
            //this.dg_cuenta.Columns[0].Visible = false;

            // llena consulta de cuentas
            
            //dg_cuentas.DataSource = db.consulta_DataGridView("select id_cuentas_banc, no_cuenta as 'Numero Cuenta', saldo_actual as 'Saldo Actual', saldo_anterior as 'Saldo Anterior',idtbt_bancos FROM tbt_cuentas_bancarias;");
            //this.dg_cuentas.Columns[0].Visible = false;
            //this.dg_cuentas.Columns[4].Visible = false;


        }

        private void lb_nomban_Click(object sender, EventArgs e)
        {

        }

        private void barra1_click_guardar_button()
        {
            if (tb_cta.SelectedIndex.ToString() == "0")
            {
                if (tb_nomcta.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("nombre_cta", tb_nomcta.Text);


                    if (editar)
                    {
                        db.actualizar("tbt_nomenclatura", dict, "id_cts=" + id);
                        tb_nomcta.Text = "";
                        editar = false;

                    }
                    else
                    {

                        if (tb_nomcta.Text == "")
                        {
                            MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string numero = this.dg_cuenta.Rows.Count.ToString();
                            int i = Convert.ToInt32(numero);
                            string compara;
                            bool ingresa = true;

                            for (int x = 0; x < i; x++)
                            {

                                compara = dg_cuenta.Rows[x].Cells[1].Value.ToString();
                                if (compara.Equals(tb_nomcta.Text))
                                {
                                    MessageBox.Show("La cuenta " + tb_nomcta.Text + " ya existe", "Error en ingreso de cts", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tb_nomcta.Text = "";
                                    ingresa = false;
                                }

                            }

                            if (ingresa)
                            {
                                db.insertar("tbt_nomenclatura", dict);
                                tb_nomcta.Text = "";
                                tb_nomcta.ReadOnly = true;
                            }


                        }

                    }

                    actualiza();

                }
                else
                {

                    MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }



            }
        }

        private void barra1_Load(object sender, EventArgs e)
        {

        }

        private void barra1_click_nuevo_button()
        {
            if (tb_cta.SelectedIndex.ToString() == "0")
            {
                tb_nomcta.ReadOnly = false;
                tb_nomcta.Text = "";

            }
             }

        private void barra1_click_buscar_button()
        {
            if (tb_cta.SelectedIndex.ToString() == "0")
            {
                if (tb_nomcta.Text == "")
                {
                    MessageBox.Show("Debe llenar el campo de busqueda", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    dg_cuenta.DataSource = db.consulta_DataGridView("SELECT nombre_cta FROM tbt_nomenclatura WHERE nombre_cta LIKE '" + tb_nomcta.Text + "%'");
                    tb_nomcta.Text = "";
                    tb_nomcta.ReadOnly = true;

                }

            }
        }

        private void barra1_click_eliminar_button()
        {
            
            //actualizar saldos
            if (tb_cta.SelectedIndex.ToString() == "0")
            {
                

                DialogResult dialogResult = MessageBox.Show("No puede eliminar los saldos de las cuentas solo actualizarlos");
               
            }
            //verificar polizas
            if (tb_cta.SelectedIndex.ToString() == "1")
            {
                DialogResult dialogResult = MessageBox.Show("No puede eliminar datos de las cuentas solo verificar polizas");
               
            }
            
           
        }

        
        
    }
}
