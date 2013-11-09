using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ADST_Colchoneria.Forms.Areas.Finanzas
{
    public partial class frm_finanzas_principal : Form
    {
        public frm_finanzas_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_manejo_bancos frm = new frm_manejo_bancos();
            frm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_nomenclatura frm = new frm_nomenclatura();
            frm.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizacion_cts frm = new actualizacion_cts();
            frm.Visible = true;
        }
    }
}
