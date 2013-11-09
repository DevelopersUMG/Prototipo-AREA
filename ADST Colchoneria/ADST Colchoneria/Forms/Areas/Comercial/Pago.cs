using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADST_Colchoneria
{
    public partial class Pago : Form
    {
        private double total;
        public bool band = false;
        private bool blHasDot = false;

        public Pago(double t)
        {
            InitializeComponent();
            this.total = t;
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
            textBox4.Text = total.ToString("N2");
            double iva = total * 0.12;
            textBox3.Text = iva.ToString("N2");
            textBox1.Text = (total - iva).ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool estado()
        {
            return this.band;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            calcular();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !blHasDot)
            {
                //Allows only one Dot Char
                blHasDot = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcular();
            }
        }

        private void calcular()
        {
            double t = Convert.ToDouble(textBox2.Text);
            if (total > t)
            {
                label5.Visible = comboBox1.Visible = true;
            }
            else if (total == t)
            {
                band = true;
                button1.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            band = true;
            button1.Enabled = true;
        }

       
    }
}
