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
// Ejemplo de implementacion de formas jerarquicamente
using ADST_Colchoneria.Forms;
using ADST_Colchoneria.Forms.Areas;
using ADST_Colchoneria.Forms.Areas.Logistica;
using ADST_Colchoneria.Forms.Principal;



namespace ADST_Colchoneria.Forms.Areas.Logistica
{
    public partial class frm_logistica_historial_factura : Form
    {
        public frm_logistica_historial_factura()
        {
            InitializeComponent();

            //busqueda();
        }
DBConnect gCon = new DBConnect(Properties.Settings.Default.odbc);





public void buscarfactura(string nofactura) {

    if (nofactura.Equals(""))
    {
        MessageBox.Show("Ingrese un numero de factura");
       

    }
    else
    {
        dataGridView1.Columns.Clear();

        string stQuery = "select tx_fecha AS Fecha, (select tx_ubicacionpedido from tbm_ubicacionpedido where tbm_ubicacionpedido.id_ubicacionpedido=tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido) AS Ubicacion, (select tx_estadopedido from tbm_estadopedido  where tbm_estadopedido.id_estadopedido=tbt_historialenvios.tbm_estadopedido_id_estadopedido) AS Estado from tbt_historialenvios where tbm_factura_id_factura=" + nofactura + "";

        dataGridView1.DataSource = gCon.consulta_DataGridView(stQuery);
    }
}



        private void frm_logistica_historial_factura_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barra1_click_buscar_button()
        {
            buscarfactura(txt_buscar.Text);
        }

        public void ultimoestado() {

            string stQuery1 = "select MAX() from ";
            
            System.Collections.ArrayList arArray = gCon.consultar(stQuery1);
            foreach (Dictionary<string, string> dict in arArray)
            {
               // textBox2.Text = dict["cliente"];
               // textBox3.Text = dict["direccion"];
              //  textBox4.Text = dict["departamento"];
            //    textBox5.Text = dict["municipio"];
            } 
        
        }
    }
}
