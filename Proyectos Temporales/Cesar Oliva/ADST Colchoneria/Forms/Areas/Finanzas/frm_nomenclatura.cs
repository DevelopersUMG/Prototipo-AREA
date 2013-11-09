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

            if (tc_nomenclatura.SelectedIndex.ToString() == "0")
            {


                tb_totalc.ReadOnly = false;
                tb_nomcue.ReadOnly = false;

                tb_totalc.ReadOnly = false;

                tb_cargo.ReadOnly = false;

                tb_tipcue.ReadOnly = false;

                tb_tiporep.ReadOnly = false;


                tb_tiposal.ReadOnly = false;
            }
            if (tc_nomenclatura.SelectedIndex.ToString() == "1")
            {
                dtp_fini.Enabled = true;
                dtp_ffin.Enabled = true;

            }
        }

        private void frm_nomenclatura_Load(object sender, EventArgs e)
        {
            // llena consulta de bancos
           

           dg_nome.DataSource = db.consulta_DataGridView("select *from tbt_nomenclatura");
           this.dg_nome.Columns[0].Visible = false;

           dataGridView2.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_historial_cuentas;");

            cb_cuet.DataSource = db.consulta_ComboBox("select id_cuentas_banc, no_cuenta from tbt_cuentas_bancarias;");
            cb_cuet.DisplayMember = "no_cuenta";
            cb_cuet.ValueMember = "id_cuentas_banc";

            cb_catal.DataSource = db.consulta_ComboBox("select id_cts, nombre_cta from tbt_nomenclatura;");
            cb_catal.DisplayMember = "nombre_cta";
            cb_catal.ValueMember = "id_cts";


        }

        private void barra1_click_guardar_button()
        {
            if (tc_nomenclatura.SelectedIndex.ToString() == "0")
            {
                if (tb_nomcue.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("nombre_cta", tb_nomcue.Text);
                    dict.Add("total_cta", tb_totalc.Text);
                    dict.Add("saldo_actual", "0");
                    dict.Add("saldo_anterior", "0");
                    dict.Add("cargo", tb_cargo.Text);
                    dict.Add("tipo_cta", tb_tipcue.Text);
                    dict.Add("tipo_reporte", tb_tiporep.Text);
                    dict.Add("tipo_saldo", tb_tiposal.Text);
                    dict.Add("id_cuentas_banc", cb_cuet.SelectedValue.ToString());

                    if (editar)
                    {
                        db.actualizar("tbt_nomenclatura", dict, "id_cts=" + id);
                        editar = false;
                    }
                    else
                    {
                        db.insertar("tbt_nomenclatura", dict);
                    }

                    dg_nome.DataSource = db.consulta_DataGridView("select *from tbt_nomenclatura");
                }
                else
                {
                    MessageBox.Show("Debe precionar la opcion nuevo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                tb_nomcue.Text = "";
                tb_nomcue.ReadOnly = true;
                tb_totalc.Text = "";
                tb_totalc.ReadOnly = true;
                tb_cargo.Text = "";
                tb_cargo.ReadOnly = true;
                tb_tipcue.Text = "";
                tb_tipcue.ReadOnly = true;
                tb_tiporep.Text = "";
                tb_tiporep.ReadOnly = true;
                tb_tiposal.Text = "";
                tb_tiposal.ReadOnly = true;
                //manejo de cuentas

            }

            if (tc_nomenclatura.SelectedIndex.ToString() == "1")
            {
                if (dtp_fini.Enabled == true)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("fecha_inicio", dtp_fini.Value.Date.ToString("yyyy-MM-dd HH:mm"));
                    dict.Add("fecha_final", dtp_fini.Value.Date.ToString("yyyy-MM-dd HH:mm"));
                    dict.Add("id_cts", cb_catal.SelectedValue.ToString());
                   
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
            }


            
        }
      
        private void barra1_click_editar_button()
        {
            if (tc_nomenclatura.SelectedIndex.ToString() == "0")
            {
                editar = true;
                tb_nomcue.ReadOnly = false;
                tb_totalc.ReadOnly = false;
                tb_cargo.ReadOnly = false;
                tb_tipcue.ReadOnly = false;
                tb_tiporep.ReadOnly = false;
                tb_tiposal.ReadOnly = false;
                int i = dg_nome.CurrentRow.Index;
                id = dg_nome.Rows[i].Cells[0].Value.ToString();
                tb_nomcue.Text = dg_nome.Rows[i].Cells[1].Value.ToString();
                tb_totalc.Text = dg_nome.Rows[i].Cells[2].Value.ToString();
                tb_cargo.Text = dg_nome.Rows[i].Cells[3].Value.ToString();
                tb_tipcue.Text = dg_nome.Rows[i].Cells[4].Value.ToString();
                tb_tiporep.Text = dg_nome.Rows[i].Cells[5].Value.ToString();
                tb_tiposal.Text = dg_nome.Rows[i].Cells[6].Value.ToString();
            }
            if (tc_nomenclatura.SelectedIndex.ToString() == "1")
            {
                editar = true;
                tb_totalc.ReadOnly = false;
                tb_cargo.ReadOnly = false;
             
                int i = dataGridView2.CurrentRow.Index;
                id = dataGridView2.Rows[i].Cells[0].Value.ToString();
                tb_totalc.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
                tb_cargo.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
               
            }
            
        }

        private void barra1_click_eliminar_button()
        {
            if (tc_nomenclatura.SelectedIndex.ToString() == "0")
            {
                int i = dg_nome.CurrentRow.Index;
                id = dg_nome.Rows[i].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string condicion = "id_cts=" + id;
                    db.eliminar("tbt_nomenclatura", condicion);
                    dg_nome.DataSource = db.consulta_DataGridView("select *from tbt_nomenclatura");
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            //manejo de cuentas bancarias
            if (tc_nomenclatura.SelectedIndex.ToString() == "1")
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

        private void barra1_click_buscar_button()
        {
            //manejo de bancos
            if (tc_nomenclatura.SelectedIndex.ToString() == "0")
            {
                string busca = tb_nomcue.Text;
                dg_nome.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_nomenclatura WHERE nombre_cta LIKE '" + tb_nomcue.Text + "%'");
                tb_nomcue.Text = "";
                tb_nomcue.ReadOnly = true;

                // if (busca= ){   
            }
            //manejo de cuentas bancarias
            if (tc_nomenclatura.SelectedIndex.ToString() == "1")
            {

            }
        }

        private void barra1_click_actualizar_button()
        {

            dataGridView2.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_historial_cuentas;");
            cb_cuet.DataSource = db.consulta_ComboBox("select id_cuentas_banc, no_cuenta from tbt_cuentas_bancarias;");
            cb_cuet.DisplayMember = "no_cuenta";
            cb_cuet.ValueMember = "id_cuentas_banc";

            cb_catal.DataSource = db.consulta_ComboBox("select id_cts, nombre_cta from tbt_nomenclatura;");
            cb_catal.DisplayMember = "nombre_cta";
            cb_catal.ValueMember = "id_cts";
        }

       
    }
}
