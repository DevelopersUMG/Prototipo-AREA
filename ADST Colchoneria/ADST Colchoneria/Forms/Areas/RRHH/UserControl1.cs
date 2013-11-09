using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reportes
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public delegate void delegadoo();
        public event delegadoo click_generar;


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void generar_Click(object sender, EventArgs e)
        {
            if (click_generar == null) return;
            click_generar();

         
        }
    }
}
