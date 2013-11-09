using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// DLL Objeto Comunes
using ODBCConnect;
using System.Data.Odbc;
using MySql.Data.MySqlClient;

// Ejemplo de implementacion de formas jerarquicamente
using ADST_Colchoneria.Forms;
//using ADST_Colchoneria.Forms.Areas;
//using ADST_Colchoneria.Forms.Areas.Comercial;
using ADST_Colchoneria.Forms.Principal;


namespace ADST_Colchoneria.Forms.Principal
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = ("Usuario: " + Properties.Settings.Default.xusuario + "      Rol:" + Properties.Settings.Default.xrol + "      ODBC: " + Properties.Settings.Default.odbc);

            this.toolTip1.SetToolTip(toolStrip1, "Una version simple del menu que se desplegara en el MDI final (una lista) agregar botones para pruebas si desean");
            this.toolTip1.SetToolTip(button1, "Llamar un form (EL MDI FINAL) evitara duplicidad de formas abiertos y lo contendra en el mismo");
            this.toolTip1.SetToolTip(button2, "Tratamiento de un error en odbc (VER CODIGO FUENTE)");
            MessageBox.Show("Este es un prototipo de MDI");
        
            MessageBox.Show("No considerar este form como parte del proyecto final"+"\n"+" (NO INSTANCIAR VARIABLES)");
          
        }
        DBConnect con = new DBConnect(Properties.Settings.Default.odbc);

        private void button1_Click(object sender, EventArgs e)
        {
            Factura f = new Factura();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fr_bodega fr = new fr_bodega();
            fr.Show();
        }

        private void frm_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fr_Compras c = new fr_Compras();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_cuentasporcobrar f = new frm_cuentasporcobrar();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_clientes f = new form_clientes();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            form_vendedores f = new form_vendedores();
            f.Show();
        }
    }
}
