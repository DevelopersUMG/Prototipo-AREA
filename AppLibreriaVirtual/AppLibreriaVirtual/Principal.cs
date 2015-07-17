using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppLibreriaVirtual
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores prov = new Proveedores();
            prov.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.Show();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            Ventas ven = new Ventas();
            ven.Show();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            Productos pro = new Productos();
            pro.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos pro = new Productos();
            pro.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores prov = new Proveedores();
            prov.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas ven = new Ventas();
            ven.Show();
        }     
    }
}
