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
        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        bool editar = false;
        string id;

        private void frm_libro_diario_Load(object sender, EventArgs e)
        {
            try 
            {
                dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_libro_diario;");
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Numero partida";
            
            }
            catch { }

            
        }

        private void barra1_click_nuevo_button()
        {
            tb_partida.ReadOnly = false;
            tb_partida.Text = "";
        }

        private void barra1_click_guardar_button()
        {
            if (tb_partida.ReadOnly == false)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("no_partido", tb_partida.Text);
                

                if (editar)
                {
                    db.actualizar("tbt_libro_diario", dict, "id_libro_diario=" + id);
                    tb_partida.Text = "";
                    
                   
                    editar = false;
                }
                else
                {
                    if (tb_partida.Text == "" )
                    {
                        MessageBox.Show("Error debe llenar todos los campos");
                    }
                    else
                    {

                       
                            db.insertar("tbt_libro_diario", dict);
                            tb_partida.Text = "";
                            tb_partida.ReadOnly = true;
                           

                        

                    }

                }

                dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_libro_diario");
            }
            else
            {
                MessageBox.Show("Debe precionar la opcion nuevo");
            }

        }

        private void barra1_click_editar_button()
        {
            editar = true;
            tb_partida.ReadOnly = false;
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tb_partida.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
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
       

       

        
    }
}
