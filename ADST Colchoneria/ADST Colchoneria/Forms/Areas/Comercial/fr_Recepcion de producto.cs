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
    public partial class Recepcion_de_producto : Form
    {
        public Recepcion_de_producto()
        {
            InitializeComponent();
            this.cargar();
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        funciones_canel fun = new funciones_canel();

        public void cargar()
        {
            cb_Producto.DataSource = db.consulta_ComboBox("select idtbm_tipo_compra,nombre_tipo_compra from tbm_tipo_compra");
            cb_Producto.DisplayMember = "nombre_tipo_compra";
            cb_Producto.ValueMember = "idtbm_tipo_compra";
            String cadena = cb_Producto.GetItemText(cb_Producto.SelectedItem);
            llenado_detalle(cadena);    

        }
               

        public void llenado_detalle(String noordena)
        {
            if (noordena.Equals("Materia Prima"))
            {
                String query="select distinct no_compra from tbt_detalle_compra_materia_prima";
                cb_Noorden.DataSource = db.consulta_ComboBox(query);
                cb_Noorden.DisplayMember = "no_compra";
                cb_Noorden.ValueMember = "no_compra";

                //Se repite en el evento
                String a = cb_Noorden.SelectedValue.ToString();
                string query2 = "select tt.idtbm_bodega as codbodega, t.nombre_producto as Producto, tt.cantidad as Cantidad, t.costo_producto as Costo, (tt.cantidad*t.costo_producto) as Valor from tbt_detalle_compra_materia_prima tt inner join tbm_producto t on tt.idtbm_producto=t.idtbm_producto where tt.no_compra=" + a;
                dg_Descripcion.DataSource = db.consulta_DataGridView(query2);
                dg_Descripcion.Columns[0].Visible = false;

            }
            else if(noordena.Equals("Producto Finalizado"))
            {
                cb_Noorden.DataSource = db.consulta_ComboBox("select distinct no_compra from tbt_detalle_compra_producto_finalizado");
                cb_Noorden.DisplayMember = "no_compra";
                cb_Noorden.ValueMember = "no_compra";

                //Se repite en el evento
                String a = cb_Noorden.SelectedValue.ToString();
                string query2 = "select tt.idtbm_bodega as codbodega, t.nombre_producto_finalizado as Producto,tt.cantidad as Cantidad, t.precio as Precio, (tt.cantidad*t.precio) as Valor from tbt_detalle_compra_producto_finalizado tt inner join producto_finalizado t on tt.idproducto_finalizado=t.idproducto_finalizado where tt.no_compra=" + a;
                dg_Descripcion.DataSource = db.consulta_DataGridView(query2);

                
            }
            
        }

       

        private void cb_Producto_SelectedValueChanged(object sender, EventArgs e)
        {
            String cadena = cb_Producto.GetItemText(cb_Producto.SelectedItem);
            llenado_detalle(cadena);            
        }

        private void cb_Noorden_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String cadena = cb_Producto.GetItemText(cb_Producto.SelectedItem);
            llenado_detalle2(cadena);
        }


        public void llenado_detalle2(String noordena)
        {
            if (noordena.Equals("Materia Prima"))
            {                
                //Se repite en el evento
                String a = cb_Noorden.SelectedValue.ToString();
                string query2 = "select tt.idtbm_bodega as codbodega, t.nombre_producto as Producto, tt.cantidad as Cantidad, t.costo_producto as Costo, (tt.cantidad*t.costo_producto) as Valor from tbt_detalle_compra_materia_prima tt inner join tbm_producto t on tt.idtbm_producto=t.idtbm_producto where tt.no_compra=" + a;
                
                dg_Descripcion.DataSource = db.consulta_DataGridView(query2);


            }
            else if (noordena.Equals("Producto Finalizado"))
            {
                //Se repite en el evento
                String a = cb_Noorden.SelectedValue.ToString();
                string query2 = "select tt.idtbm_bodega as codbodega, t.nombre_producto_finalizado as Producto,tt.cantidad as Cantidad, t.precio as Precio, (tt.cantidad*t.precio) as Valor from tbt_detalle_compra_producto_finalizado tt inner join producto_finalizado t on tt.idproducto_finalizado=t.idproducto_finalizado where tt.no_compra=" + a;
                dg_Descripcion.DataSource = db.consulta_DataGridView(query2);
                //string query3=
            

                
            }


        }

        private void dg_Descripcion_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //textBox1.Text = fun.f2_sum_column(dg_Descripcion, "Valor");
        }

        private void dg_Descripcion_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }
    }
}
