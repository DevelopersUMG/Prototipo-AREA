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

namespace ADST_Colchoneria.Forms.Areas.Produccion
{
    public partial class frm_categoria : Form
    {
        DBConnect con = new DBConnect(Properties.Settings.Default.odbc);
        public frm_categoria()
        {
            InitializeComponent();
        }

        private void barra1_Load(object sender, EventArgs e)
        {

        }

        private void frm_categoria_Load(object sender, EventArgs e)
        {

        }

    }
}
