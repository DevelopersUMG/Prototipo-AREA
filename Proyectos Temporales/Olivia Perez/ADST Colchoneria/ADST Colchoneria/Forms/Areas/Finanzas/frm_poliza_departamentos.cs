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
    public partial class frm_poliza_departamentos : Form
    {
        public frm_poliza_departamentos()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("ADSTConnector");

        bool editar = false;
        string id;

        private void barra1_click_actualizar_button()
        {

        }

        private void barra1_click_nuevo_button()
        {
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                textBox3.ReadOnly = false;
                textBox3.Text = "";

            }
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                /*textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";  */
            }
        }

        private void frm_poliza_departamentos_Load(object sender, EventArgs e)
        {
            // llena consulta de bancos
            dataGridView1.DataSource = db.consulta_DataGridView("select *from Poliza_departamentos");
            this.dataGridView1.Columns[0].Visible = false;

            // llena consulta de cuentas
            dataGridView2.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_encabezado;");

            // llena consulta 3
            dataGridView3.DataSource = db.consulta_DataGridView("SELECT * FROM tbt_detalle;");

            comboBox3.DataSource = db.consulta_ComboBox("select id_poliza, nombre_dpt from Poliza_departamentos;");
            comboBox3.DisplayMember = "nombre_dpt";
            comboBox3.ValueMember = "id_poliza";
        }

        private void barra1_click_guardar_button()
        {
            //manejo de bancos
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                if (textBox3.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("nombre_dpt", textBox3.Text);


                    if (editar)
                    {
                        db.actualizar("Poliza_departamentos", dict, "id_poliza=" + id);
                        editar = false;

                    }
                    else
                    {

                        if (textBox3.Text == "")
                        {
                            MessageBox.Show("Error debe llenar todos los campos");
                        }
                        else
                        {
                            db.insertar("Poliza_departamentos", dict);
                            textBox3.Text = "";
                            textBox3.ReadOnly = true;
                        }

                    }

                    dataGridView1.DataSource = db.consulta_DataGridView("select *from Poliza_departamentos");

                }
                else
                {

                    MessageBox.Show("Debe precionar la opcion nuevo");
                }



            }
        }

        private void barra1_click_editar_button()
        {
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                editar = true;
                textBox3.ReadOnly = false;
                int i = dataGridView1.CurrentRow.Index;
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();

            }
        }
    }
}
