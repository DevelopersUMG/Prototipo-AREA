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
using ADST_Colchoneria.Forms.Areas.Logistica;

namespace ADST_Colchoneria.Forms.Areas.Comercial
{
    public partial class frm_modulofactura : Form
    {
        public frm_modulofactura()
        {
            InitializeComponent();
        }
        DBConnect con = new DBConnect(Properties.Settings.Default.odbc);
        private void button1_Click(object sender, EventArgs e)
        {
            GUARDA();
        }

        public void GUARDA() {
            string tabla1 = "tbm_factura";
            Dictionary<string, string> dict2x2 = new Dictionary<string, string>();

            
            
            dict2x2.Add("cliente", txtcliente.Text);
            dict2x2.Add("direccion", txtdireccion.Text);
            dict2x2.Add("departamento", cmbdepto.Text);
            dict2x2.Add("municipio", cmbmuni.Text);
            
            con.insertar(tabla1, dict2x2);


            string xnofactura = "";
            string query11 = "SELECT MAX(id_factura)AS id FROM tbm_factura";
            System.Collections.ArrayList array = con.consultar(query11);
            foreach(Dictionary<string,string> dict in array){

                xnofactura = dict["id"].ToString();
            
            }
            Console.WriteLine("VALOR MAXIMO: " + xnofactura);

            int f = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                f++;
            
            }
            int xx = 1;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (xx < f)
                    {
                        string tabla = "tbt_detallefactura";
                        Dictionary<string, string> dict2x = new Dictionary<string, string>();
                        string xcodigo = (Convert.ToString(row.Cells[1].Value));
                        string xcantidad = (Convert.ToString(row.Cells[0].Value));
                        dict2x.Add("cod_producto", xcodigo);
                        dict2x.Add("cantidad", xcantidad);
                        dict2x.Add("tbm_factura_id_factura", xnofactura);
                        con.insertar(tabla, dict2x);
                    }
                    xx++;
                }
                Historial_Envios x = new Historial_Envios();
                x.historial(0,xnofactura);
        }
    }
}
