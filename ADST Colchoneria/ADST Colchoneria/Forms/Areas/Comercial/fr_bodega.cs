using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;
using System.Collections;

namespace ADST_Colchoneria
{
    public partial class fr_bodega : Form
    {
        public fr_bodega()
        {
            InitializeComponent();
        }
        DBConnect con = new DBConnect(Properties.Settings.Default.odbc);
        bool modi = false;
        bool hab = false;
        private void bodega_Load(object sender, EventArgs e)
        {
            consultar();
        }

        public void consultar()
        {
            dg_ver.Columns.Clear();

            dg_ver.DataSource = con.consulta_DataGridView("select idtbm_bodega, nombre_bodega as 'Nombre', serie as 'Serie' from tbm_bodega");
            dg_ver.Columns[0].Visible = false;
            
        }

        private void barra1_click_nuevo_button()
        {
            pn_in.Visible = true;
            tb_nombre.Text = "";
            tb_serie.Text = "";
            tb_nombre.Focus();
            hab = true;
        }

        private void barra1_click_actualizar_button()
        {
            consultar();
        }

        private void barra1_click_guardar_button()
        {
            if (hab == true)
            {
                if (!"".Equals(tb_nombre.Text) && (!"".Equals(tb_serie.Text)))
                {

                    Dictionary<string, string> dict;
                    datos(out dict);
                    if (!modi)
                    {
                        con.insertar("tbm_bodega", dict);
                    }
                    else
                    {
                        con.actualizar("tbm_bodega", dict, "idtbm_bodega='" + dg_ver.CurrentRow.Cells["idtbm_bodega"].Value + "'");/////////////
                    }
                    modi = false;
                    tb_nombre.Text = "";
                    pn_in.Visible = false;
                }
                else
                {
                    MessageBox.Show("Faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void datos(out Dictionary<string, string> dict)
        {
            dict = new Dictionary<string, string>();
            dict.Add("nombre_bodega", tb_nombre.Text);
            dict.Add("serie", tb_serie.Text);
            
        }

        private void barra1_click_eliminar_button()
        {
            if (MessageBox.Show("¿Estás seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int p = Convert.ToInt32(dg_ver.CurrentRow.Cells["idtbm_bodega"].Value);
                    con.eliminar("tbm_bodega", "idtbm_bodega=" + p);
                    MessageBox.Show("Registro eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
        }

        private void barra1_click_editar_button()
        {
            string query = "select nombre_bodega,serie from tbm_bodega where idtbm_bodega = " + dg_ver.CurrentRow.Cells["idtbm_bodega"].Value + "";
          
            ArrayList array = con.consultar(query);
            foreach (Dictionary<string, string> v in array)
            {
                tb_nombre.Text = v["nombre_bodega"];
                tb_serie.Text=v["serie"];
                modi = true;
                
            }
            pn_in.Visible = true;
            tb_nombre.Focus();
            
        }

        


    }
}
