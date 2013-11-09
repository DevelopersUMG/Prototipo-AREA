using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;
	
		 
	

namespace ADST_Colchoneria
{
    public partial class frm_cuentasporcobrar : Form
    {
        public frm_cuentasporcobrar()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        public void consulta()
        {
            string fecha = dtp_fechaconsulta.Value.ToShortDateString();
            string query;

            query = "select (serie_factura +'_'+ no_factura) as 'Numero de factura',total_cuenta_por_cobrar as 'Total del documento', fecha_emision as 'Fecha de emision',fecha_vence as 'Fecha de vencimiento',saldo_cuenta_por_cobrar as 'Saldo actual' from tbm_cuenta_por_cobrar where fecha_vence = " + fecha;
            dgv_consulta.DataSource = db.consulta_DataGridView(query);

        }


    }
}
