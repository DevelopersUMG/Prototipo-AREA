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
    public partial class frm_Reportecuentasporpagar : Form
    {
        public frm_Reportecuentasporpagar()
        {
            InitializeComponent();
        }


        DBConnect db = new DBConnect (Properties.Settings.Default.odbc);

        public void consulta() 
        {
            string fecha = dtp_fechaconsulta.Value.ToShortDateString();
            string query;

            query = "select no_compra as 'Numero de documento',total_cuenta_por_pagar as 'Total del documento', fecha_emision as 'Fecha de emision',fecha_vence as 'Fecha de vencimiento',saldo_cuenta_por_pagar as 'Saldo actual' from tbm_cuenta_por_pagar where fecha_vence = " + fecha;
            dgv_consulta.DataSource = db.consulta_DataGridView(query);

        }

        


    }
}
