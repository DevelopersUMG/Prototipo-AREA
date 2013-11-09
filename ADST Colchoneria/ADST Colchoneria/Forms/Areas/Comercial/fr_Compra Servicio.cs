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
    public partial class Compra_Servicio : Form
    {
        public Compra_Servicio()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
    }
}
