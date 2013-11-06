using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
// Ejemplo de implementacion de formas jerarquicamente
using ADST_Colchoneria.Forms;
using ADST_Colchoneria.Forms.Areas;
using ADST_Colchoneria.Forms.Areas.Produccion;
using ADST_Colchoneria.Forms.Principal;
using Microsoft.VisualBasic;

namespace ADST_Colchoneria.Forms.Areas.Produccion
{
    public partial class frm_categoria : Form
    {
        DBConnect con = new DBConnect(Properties.Settings.Default.odbc);
        public frm_categoria()
        {
            InitializeComponent();
        }

        private void frm_categoria_Load(object sender, EventArgs e)
        {
            nuevo();          
        }

        public void nuevo()
        {
            tabControl1.SelectedTab = tabPage1;

        }
        public void guardar()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingrese un nombre");
                textBox1.Clear();
            }
            else
            {
                string query2 = "select * from tbm_categoria where nombre_categoria='" + textBox1.Text + "'";
                System.Collections.ArrayList array = con.consultar(query2);
                int intamanoarray = 0;
                intamanoarray = array.Count;

                String nombre = textBox1.Text;

                if (intamanoarray != 0)
                {
                    MessageBox.Show("La categoria ya existe");
                    textBox1.Clear();
                }
                else
                {
                    string tabla = "tbm_categoria";
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("nombre_categoria", textBox1.Text);
                    con.insertar(tabla, dict);
                    MessageBox.Show("Categoria creada exitosamente");
                    textBox1.Clear();
                    
                }
            }

        }

        public void buscar()
        {
            comboBox();
            tabControl1.SelectedTab = tabPage2;
            string consulta = "select id_categoria as codigo, nombre_categoria as Categoria from tbm_categoria";
            dataGridView1.DataSource = con.consulta_DataGridView(consulta);
        }

        public void comboBox()
        {
           /*string consulta1 = "select 	id_categoria, nombre_categoria from tbm_categoria";
            comboBox1.DataSource = con.consulta_ComboBox(consulta1);
            comboBox1.DisplayMember = "nombre_categoria";
            comboBox1.ValueMember = "id_categoria"; */
    
        }

        private void eliminar()
        {

            string tabla = "tbm_categoria";
            string condicion = "id_categoria=" + comboBox1.SelectedValue;
            con.eliminar(tabla, condicion);
            MessageBox.Show("Categoria eliminada exitosamente");

        }

        private void editar()
        {
           string editado = Microsoft.VisualBasic.Interaction.InputBox("Ingresa un Nombre:");


           if (editado == "")
           {
               MessageBox.Show("Ingrese un nombre");
               textBox1.Clear();
           }
           else
           {

               string query2 = "select * from tbm_categoria where nombre_categoria='" + editado + "'";
               System.Collections.ArrayList array = con.consultar(query2);
               int intamanoarray = 0;
               intamanoarray = array.Count;

               String nombre = editado;

               if (intamanoarray != 0)
               {
                   MessageBox.Show("La categoria ya existe");
                   textBox1.Clear();
               }

               else
               {
                   string tabla = "tbm_categoria";
                   Dictionary<string, string> dict = new Dictionary<string, string>();
                   dict.Add("nombre_categoria", editado);
                   string condicion = "id_categoria=" + comboBox1.SelectedValue;
                   con.actualizar(tabla, dict, condicion);
                   MessageBox.Show("Categoria modificada exitosamente");

               }
           }

        }

        private void actualizar()
        {
            buscar();
            //comboBox();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string consulta1 = "select 	id_categoria, nombre_categoria from tbm_categoria";
            comboBox1.DataSource = con.consulta_ComboBox(consulta1);
            comboBox1.DisplayMember = "nombre_categoria";
            comboBox1.ValueMember = "id_categoria"; 
        }
    }
}
