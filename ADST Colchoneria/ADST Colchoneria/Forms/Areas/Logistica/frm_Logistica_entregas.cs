using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frm_Logistica_entregas : Form
    {
        public frm_Logistica_entregas()
        {
            InitializeComponent();
            llenarAreaCarga();
        }

        public void llenarAreaCarga()
        {
            Historial_Envios x = new Historial_Envios();
            dataGridView1.DataSource = (x.historialarea(2));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Logistica_entregas_Load(object sender, System.EventArgs e)
        {

        }
    }
}
