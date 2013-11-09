using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ODBCConnect;

namespace ADST_Colchoneria
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        bool bandcom = false, bandcom2 = false;
        ArrayList productos = new ArrayList();
        int factura = 0;
        int cliente = 0;
        string serie;
        //int c = -1, f = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            textBox1.Select();

            comboBox1.DataSource = db.consulta_ComboBox("select v.idtbm_vendedor as 'idvendedor',concat(e.tbempleado_nomEmple,' ',e.tbempleado_apellemple) as 'nombre' from tbm_vendedor v, tbempleado e where v.idtbempleado=e.idtbempleado");
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idvendedor";

            comboBox2.DataSource = db.consulta_ComboBox("select idtbm_bodega,nombre_bodega from tbm_bodega");
            comboBox2.DisplayMember = "nombre_bodega";
            comboBox2.ValueMember = "idtbm_bodega";

            comboBox4.DataSource = db.consulta_ComboBox("select idtbm_bodega,nombre_bodega from tbm_bodega");
            comboBox4.DisplayMember = "nombre_bodega";
            comboBox4.ValueMember = "idtbm_bodega";

            comboBox8.DataSource = db.consulta_ComboBox("select idtbm_moneda,nombre_moneda from tbm_moneda");
            comboBox8.DisplayMember = "nombre_moneda";
            comboBox8.ValueMember = "idtbm_moneda";

            comboBox7.DataSource = db.consulta_ComboBox("select idtbm_tipo_pago,nombre_tipo_pago from tbm_tipo_pago");
            comboBox7.DisplayMember = "nombre_tipo_pago";
            comboBox7.ValueMember = "idtbm_tipo_pago";

            no_serie();
            bandcom2 = true;
            
        }

        private void barra1_click_nuevo_button()
        {
            if (tabControl1.SelectedIndex != 1)
            {
                tabControl1.SelectedIndex = 1;
                textBox1.Focus();
            }
        }

        private void barra1_click_buscar_button()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                dataGridView2.Columns.Clear();   
                string query = "select cast(f.serie_factura as char) as 'Serie', f.no_factura as 'No. factura', DATE_FORMAT(f.fecha_factura,'%d/%m/%Y') as 'Fecha', ";
                query += "c.nit_cliente as 'NIT', c.nombre_cliente as 'Cliente',concat(e.tbempleado_nomemple,' ',e.tbempleado_apellemple) as 'Vendedor', b.nombre_bodega as 'Bodega' ";
                query += "from tbm_factura f, tbm_cliente c, tbm_vendedor v, tbm_bodega b, tbempleado e ";
                query += "where c.idtbm_cliente=f.idtbm_cliente and f.idtbm_vendedor = v.idtbm_vendedor and f.idtbm_bodega=b.idtbm_bodega and v.idtbempleado=e.idtbempleado ";
                query += "and f.idtbm_bodega = " + comboBox4.SelectedValue;

                if (checkBox1.Checked) query += " and f.idtbm_vendedor = " + comboBox5.SelectedValue;
                if (checkBox2.Checked) query += " and f.idtbm_cliente = " + comboBox6.SelectedValue;
                if (checkBox5.Checked) query += " and f.idtbm_moneda = " + comboBox9.SelectedValue;
                if (checkBox6.Checked) query += " and f.idtbm_tipo_pago = " + comboBox10.SelectedValue;

                if (checkBox3.Checked && !checkBox4.Checked)
                {
                    string st = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    query += " and f.fecha_factura like '" + st + "%'";
                }

                if (checkBox3.Checked && checkBox4.Checked)
                {
                    string st = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    string st1 = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                    st += " 00:00:00";
                    st1 += " 23:59:59";
                    query += " and f.fecha_factura >= '" + st + "' and f.fecha_factura <= '" + st1 + "'";
                }

                dataGridView2.DataSource = db.consulta_DataGridView(query);
                
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    char a = (char)Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                    dataGridView2.Rows[i].Cells[0].Value = a;
                }

                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "Ver detalles";
                col.Name = "";
                col.FillWeight = 50;
                dataGridView2.Columns.Add(col);

                for (int i = 0; i < dataGridView2.ColumnCount; i++)
                {
                    dataGridView2.Columns[i].FillWeight = 50;
                }
            }
            else
            {
                tabControl1.SelectedIndex = 0;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(bandcom2) no_serie();          
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                string nit = textBox1.Text.ToLower();
                if (nit.Length > 3 && nit[nit.Length - 2] == '-')
                {
                    string query = "select idtbm_cliente,nombre_cliente from tbm_cliente where nit_cliente='" + nit + "'";
                    Console.WriteLine(query);
                    System.Collections.ArrayList ar = db.consultar(query);
                    if (ar.Count > 0)
                    {
                        Dictionary<string, string> d = (Dictionary<string, string>)ar[0];
                        textBox2.Text = d["nombre_cliente"];
                        cliente = Convert.ToInt32(d["idtbm_cliente"]);
                        panel1.Visible = true;
                        bandcom = false;
                        comboBox3.DataSource = db.consulta_ComboBox("select id_producto_finalizado,nombre_producto_finalizado from tbm_producto_finalizado");
                        comboBox3.DisplayMember = "nombre_producto_finalizado";
                        comboBox3.ValueMember = "id_producto_finalizado";
                        bandcom = true;
                        comboBox3.SelectedIndex = 1;
                        
                        //textBox3.Select();
                        dataGridView1.ColumnCount = 4;

                        DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                        col.UseColumnTextForButtonValue = true;
                        col.Text = "-";
                        col.Name = "Quitar";
                        col.FillWeight = 50;
                        dataGridView1.Columns.Add(col);
                        dataGridView1.Columns[0].ReadOnly = false;

                        comboBox3.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado");
                    }

                }
                else
                {
                    textBox2.Text = "";
                }
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                MessageBox.Show("HOla");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bandcom)
            {
                string query = "select id_producto_finalizado,precio_producto_finalizado as 'precio' from tbm_producto_finalizado where id_producto_finalizado=" + comboBox3.SelectedValue;
                Dictionary<string, string> d = db.consultar_un_registro(query);
                textBox4.Text = d["precio"];
                textBox3.Text = d["id_producto_finalizado"];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool band = true;
            for (int i = 0; i < productos.Count; i++)
            {
                if (Convert.ToInt32(comboBox3.SelectedValue) == Convert.ToInt32(productos[i]))
                {
                    band = false;
                    break;
                }
            }
            if (band)
            {
                dataGridView1.RowCount++;
                int f = dataGridView1.RowCount - 1;
                dataGridView1.Rows[f].Cells[0].Value = textBox5.Text;
                dataGridView1.Rows[f].Cells[1].Value = comboBox3.Text;
                dataGridView1.Rows[f].Cells[2].Value = textBox4.Text;
                double t = Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox4.Text);
                dataGridView1.Rows[f].Cells[3].Value = t.ToString("N2");
                calcular_total();
                textBox5.Text = "1";
                productos.Add(Convert.ToInt32(comboBox3.SelectedValue));
                comboBox3.Focus();
            }
            else
            {
                comboBox3.Focus();
                MessageBox.Show("Producto ya agregado");
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                double t = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[0].Value) * Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = t.ToString("N2");
            }
        }

        private void barra1_click_guardar_button()
        {
            if (tabControl1.SelectedIndex == 1)
            {
                Pago pago = new Pago(Convert.ToDouble(label10.Text));
                pago.ShowDialog();
                if (pago.estado())
                {
                    int a;
                    bool error = false;
                    char c = serie[0];
                    int s = (int)c;
                    db.empezar_transaccion();
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("no_factura", factura.ToString());
                    dict.Add("serie_factura", s.ToString());
                    dict.Add("fecha_factura", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm"));
                    dict.Add("idtbm_vendedor", comboBox1.SelectedValue.ToString());
                    dict.Add("idtbm_bodega", comboBox2.SelectedValue.ToString());
                    dict.Add("idtbm_cliente", cliente.ToString());
                    dict.Add("idtbm_moneda", comboBox8.SelectedValue.ToString());
                    dict.Add("idtbm_tipo_pago", comboBox7.SelectedValue.ToString());
                    a = db.insertar("tbm_factura", dict);
                    if (a == 0) error = true;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dict = new Dictionary<string, string>();
                        dict.Add("no_factura", factura.ToString());
                        dict.Add("serie_factura", s.ToString());
                        dict.Add("idtbm_bodega", comboBox2.SelectedValue.ToString());
                        dict.Add("cantidad", dataGridView1.Rows[i].Cells[0].Value.ToString());
                        dict.Add("id_producto_finalizado", productos[i].ToString());
                        a = db.insertar("tbt_detalle_factura", dict);
                        if (a == 0) error = true;
                    }
                    db.terminar_transaccion(error);
                    dataGridView1.RowCount = 0;
                    productos = new ArrayList();
                    panel1.Visible = false;
                    textBox5.Text = "1";
                    //label10.Text = "0.00";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    no_serie();
                    calcular_total();
                    if (!error) MessageBox.Show("Factura generada exitósamente");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                productos.RemoveAt(e.RowIndex);
                calcular_total();
            }
        }

        private void calcular_total()
        {
            double t = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                t += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            label10.Text = t.ToString("N2");
        }

        private void no_serie()
        {
            int i =Convert.ToInt32(comboBox2.SelectedValue);
            Dictionary<string, string> d = db.consultar_un_registro("select serie from tbm_bodega where idtbm_bodega=" + i);
            i = Convert.ToInt32(d["serie"]);
            char c = (char)i;
            textBox6.Text = ""+c;
            serie = textBox6.Text;

            d = db.consultar_un_registro("select max(no_factura)+1 as 'no' from tbm_factura where serie_factura="+i);
            if (d["no"] != "") factura = Convert.ToInt32(d["no"]);
            else factura++;
            textBox7.Text = factura.ToString();
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4_Click(sender, e);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Decimal))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox5.Enabled = true;
                comboBox5.DataSource = db.consulta_ComboBox("select v.idtbm_vendedor as 'idvendedor',e.nombre as 'nombre' from tbm_vendedor v, tbempleado e where v.idtbempleado=e.idtbempleado");
                comboBox5.DisplayMember = "nombre";
                comboBox5.ValueMember = "idvendedor";
            }
            else
            {
                comboBox5.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox6.Enabled = true;
                comboBox6.DataSource = db.consulta_ComboBox("select idtbm_cliente,nombre_cliente from tbm_cliente");
                comboBox6.DisplayMember = "nombre_cliente";
                comboBox6.ValueMember = "idtbm_cliente";
            }
            else
            {
                comboBox6.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                dateTimePicker2.Enabled = true;
                checkBox4.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
                checkBox4.Enabled = false;
                checkBox4.Checked = false;
                dateTimePicker3.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                dateTimePicker3.Enabled = true;
            }
            else
            {
                dateTimePicker3.Enabled = false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int f = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
                char c = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString()[0];
                int s = (int)c;
                string d = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
                Dictionary<string, string> z = db.consultar_un_registro("select idtbm_bodega from tbm_bodega where nombre_bodega='" + d + "'");
                int b = Convert.ToInt32(z["idtbm_bodega"]);
                new Detalle_factura(f, s, b).ShowDialog();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                comboBox9.Enabled = true;
                comboBox9.DataSource = db.consulta_ComboBox("select idtbm_moneda,nombre_moneda from tbm_moneda");
                comboBox9.DisplayMember = "nombre_moneda";
                comboBox9.ValueMember = "idtbm_moneda";
            }
            else
            {
                comboBox9.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                comboBox10.Enabled = true;
                comboBox10.DataSource = db.consulta_ComboBox("select idtbm_tipo_pago,nombre_tipo_pago from tbm_tipo_pago");
                comboBox10.DisplayMember = "nombre_tipo_pago";
                comboBox10.ValueMember = "idtbm_tipo_pago";
            }
            else
            {
                comboBox10.Enabled = false;
            }
        }

            
    }
}
