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
    public partial class Detalle_factura : Form
    {
        int factura, serie, bodega;

        public Detalle_factura(int f, int s, int b)
        {
            InitializeComponent();
            this.factura = f;
            this.serie = s;
            this.bodega = b;
        }

        private void Detalle_factura_Load(object sender, EventArgs e)
        {
            string query = "select d.cantidad as 'Cantidad', p.nombre_producto_finalizado as 'Producto', p.precio_producto_finalizado as 'Precio' ";
            query += "from tbt_detalle_factura d, tbm_producto_finalizado p where d.id_producto_finalizado=p.id_producto_finalizado and d.idtbm_bodega="+bodega;
            query += " and d.no_factura=" + factura + " and d.serie_factura=" + serie;
            dataGridView1.DataSource = new DBConnect(Properties.Settings.Default.odbc).consulta_DataGridView(query);

            query = "select f.no_factura as 'no',f.serie_factura as 'serie' ,f.fecha_factura as 'fecha',c.nombre_cliente as 'cliente',c.nit_cliente as 'nit', concat(e.tbempleado_nomemple,' ',e.tbempleado_apellemple) as 'vendedor', b.nombre_bodega as 'bodega', m.nombre_moneda as 'moneda', p.nombre_tipo_pago as 'pago' ";
            query += " from tbm_factura f, tbm_cliente c,tbm_bodega b, tbm_vendedor v, tbempleado e, tbm_moneda m, tbm_tipo_pago p ";
            query += " where f.idtbm_cliente=c.idtbm_cliente and f.idtbm_vendedor=v.idtbm_vendedor and f.idtbm_bodega=b.idtbm_bodega and e.idtbempleado=v.idtbempleado and f.idtbm_moneda=m.idtbm_moneda and f.idtbm_tipo_pago=p.idtbm_tipo_pago ";
            query += " and f.no_factura=" + factura + " and f.serie_factura=" + serie + " and f.idtbm_bodega = " + bodega;

            
            Dictionary<string, string> d = new DBConnect(Properties.Settings.Default.odbc).consultar_un_registro(query);
            textBox3.Text = d["bodega"];
            char a = d["serie"][0];
            int i = (int)a;
            textBox6.Text = i.ToString();
            textBox7.Text = d["no"];
            textBox4.Text = d["vendedor"];
            textBox1.Text = d["nit"];
            textBox2.Text = d["cliente"];    
            d["fecha"] = d["fecha"].Substring(0, 10);            
            DateTime dt = Convert.ToDateTime(d["fecha"]);
            dateTimePicker1.Value = dt;
            textBox8.Text = d["moneda"];
            textBox5.Text = d["pago"];

            double t = 0;
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                t += Convert.ToDouble(dataGridView1.Rows[j].Cells[0].Value) * Convert.ToDouble(dataGridView1.Rows[j].Cells[2].Value);
            }
            label10.Text = t.ToString("N2");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
