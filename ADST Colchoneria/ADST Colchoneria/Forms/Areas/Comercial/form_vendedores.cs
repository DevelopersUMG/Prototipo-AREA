using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;


namespace WindowsFormsApplication1
{
    public partial class form_vendedores : Form
    {
        private DBConnect db = new DBConnect("area_comercial");
        int id_parametro;


        public form_vendedores(int a)
        {
            id_parametro = a;
            InitializeComponent();
        }

        public form_vendedores()
        {
            // TODO: Complete member initialization
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_procentaje.Visible = false;

            box_tipo_comision.DataSource = db.consulta_ComboBox("select idtbm_tipo_comision, nombre_tipo_comision, porcentaje_tipo_comision from tbm_tipo_comision");
            box_tipo_comision.DisplayMember = "nombre_tipo_comision";
            box_tipo_comision.ValueMember = "idtbm_tipo_comision";


        }
            

             
             private void btn_aceptar_Click(object sender, EventArgs e)
             {
                 string tabla = "tbm_vendedor";
                 Dictionary<string, string> dict = new Dictionary<string, string>();
                 dict.Add("idtbm_vendedor", text_nombre_vend.Text);
                 dict.Add("idtbEmpleado", id_parametro.ToString());                 
                 dict.Add("idtbm_tipo_comision", box_tipo_comision.SelectedValue.ToString());


                 db.insertar(tabla, dict);
                 MessageBox.Show("Agregado con Exito!");

             }
        
    }
}
