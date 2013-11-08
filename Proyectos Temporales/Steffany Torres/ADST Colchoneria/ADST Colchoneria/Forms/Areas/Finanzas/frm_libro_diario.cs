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
    public partial class frm_libro_diario : Form
    {
        public frm_libro_diario()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("ADSTConnector");

        bool editar = false;
        string id;

        private void frm_libro_diario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_libro_diario");
            this.dataGridView1.Columns[0].Visible = false;


            comboBox1.DataSource = db.consulta_ComboBox("select id_detalle from tbt_detalle;");
            comboBox1.DisplayMember = "id_detalle";
            comboBox1.ValueMember = "id_detalle";
        }

        private void barra1_click_nuevo_button()
        {
            textBox1.ReadOnly = false;
            textBox1.Text = "";
                
        }

        private void barra1_click_guardar_button()
        {
            if (textBox1.ReadOnly == false)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("numero de partida", textBox1.Text);


                if (editar)
                {
                    db.actualizar("tbt_libro_diario", dict, "id_libro_diario=" + id);
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

                        if (ingresa)
                        {
                            db.insertar("tbt_libro_diario", dict);
                            textBox1.Text = "";
                            textBox1.ReadOnly = true;
                        }


                    }

                }


                dataGridView1.DataSource = db.consulta_DataGridView("select numero de partida as 'Numero Partida', id_encabezado as 'ID encabezado'  from tbt_libro_diario;");

                

            }
            else
            {

                MessageBox.Show("Debe precionar la opcion nuevo");
            }

        }

        private void barra1_Load(object sender, EventArgs e)
        {

        }

        private void barra1_click_editar_button()
        {
            editar = true;
            textBox1.ReadOnly = false;
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();

        }

        private void barra1_click_eliminar_button()
        {
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string condicion = "id_libro_diario=" + id;
                db.eliminar("tbt_libro_diario", condicion);
                dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_libro_diario");

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void barra1_click_buscar_button()
        {
            string busca = comboBox1.SelectedValue.ToString();
            dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_encabezado where id_encabezado =" + busca + ";");
        }
    }
}
