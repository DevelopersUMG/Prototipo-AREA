using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;
using System.Collections;

namespace ADST_Colchoneria
{
    public partial class fr_Compras : Form
    {
        public fr_Compras()
        {
            InitializeComponent();
            iniciar();
            txtcantidad.Text = "1";
            txtcantidad.SelectAll();

            
        }
        
        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        funciones_canel fun = new funciones_canel();
        DataGridViewColumn columna;
        String stipo_compra = null;
        int id_bodega = 0;
        int idtipPago = 0;
        int id_moneda = 0;
        int itipo_compra = 0;
        int idproveedor = 0;
        int idproducto = 0;
        String cantidad = null;
        

        private static int cod_compra = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }
        public void iniciar()//TERMINADO
        {
            desactivar_master();
            //MASTEER
            //combo de tipo de compra
            cmbtipodecompra.DataSource = db.consulta_ComboBox("select idtbm_tipo_compra,nombre_tipo_compra from tbm_tipo_compra");
            cmbtipodecompra.DisplayMember = "nombre_tipo_compra";
            cmbtipodecompra.ValueMember = "idtbm_tipo_compra";
           // cmbtipodecompra.Items.RemoveAt(cmbtipodecompra.Items.Count);
            //combo de proveedor
            cmbproveedor.DataSource = db.consulta_ComboBox("select idtbm_proveedor,nombre_proveedor from tbm_proveedor");
            cmbproveedor.DisplayMember = "nombre_proveedor";
            cmbproveedor.ValueMember = "idtbm_proveedor";
            //combo de moneda
            cmbmoneda.DataSource = db.consulta_ComboBox("select idtbm_moneda,nombre_moneda from tbm_moneda");
            cmbmoneda.DisplayMember = "nombre_moneda";
            cmbmoneda.ValueMember = "idtbm_moneda";

            //combo de tipo de pago
            cmbtipopago.DataSource = db.consulta_ComboBox("select idtbm_tipo_pago,nombre_tipo_pago from tbm_tipo_pago");
            cmbtipopago.DisplayMember = "nombre_tipo_pago";
            cmbtipopago.ValueMember = "idtbm_tipo_pago";

            //combo de bodega
            cmbbodega.DataSource = db.consulta_ComboBox("select idtbm_bodega,nombre_bodega from tbm_bodega");
            cmbbodega.DisplayMember = "nombre_bodega";
            cmbbodega.ValueMember = "idtbm_bodega";
           
        }


        public void llenado_informacion(int opcion,DataGridView tabla,int no_compra,int id_bodega)
        {
            String sno_compra = Convert.ToString(no_compra);
            String sid_bodega = Convert.ToString(id_bodega);
            Dictionary<string, string> dictmaestra = new Dictionary<string, string>();
            
                dictmaestra.Add("no_compra", sno_compra);
                dictmaestra.Add("idtbm_bodega", sid_bodega);
                dictmaestra.Add("fecha_compra", null);
                dictmaestra.Add("idtbm_tipo_pago", Convert.ToString(idtipPago));
                dictmaestra.Add("idtbm_moneda", Convert.ToString(id_moneda));
                dictmaestra.Add("idtbm_tipo_compra", Convert.ToString(itipo_compra));
                dictmaestra.Add("idtbm_proveedor", Convert.ToString(idproveedor));
                db.insertar("tbm_compra", dictmaestra);                
          

            Dictionary<int, double> d = new Dictionary<int, double>();
            int codigo = 0;
            double cantidad = 0;

            foreach (DataGridViewRow fila in tabla.Rows)
            {
                if ((opcion == 1) || (opcion == 2))
                {
                    codigo = Convert.ToInt32(fila.Cells["idproducto"].Value.ToString());
                    cantidad = Convert.ToDouble(fila.Cells["CANTIDAD"].Value.ToString());
                }
                else if (opcion == 3)
                {
                    codigo = Convert.ToInt32(fila.Cells["idproducto"].Value.ToString());
                    cantidad = Convert.ToDouble(fila.Cells["PRECIO"].Value.ToString());

                }
                if (d.ContainsKey(codigo))
                {
                    double value = d[codigo];
                    d[codigo] = value + cantidad;
                }
                else
                {
                    d.Add(codigo, cantidad);
                }
            }

            //AQUI PARA INSERTAR A LOS DETALLES DE COMPRA
            Dictionary<String, String> dictio = new Dictionary<String, String>();
            foreach (var info in d)
            {
                String id_producto = Convert.ToString(info.Key);
                String cant_producto = Convert.ToString(info.Value);

                if ((opcion == 1))
                {
                    dictio.Add("no_compra", sno_compra);
                    dictio.Add("idtbm_bodega", sid_bodega);
                    dictio.Add("cantidad", cant_producto);
                    dictio.Add("idtbm_producto", id_producto);
                    db.insertar("tbt_detalle_compra_materia_prima", dictio);
                    dictio.Remove("no_compra");
                    dictio.Remove("idtbm_bodega");
                    dictio.Remove("cantidad");
                    dictio.Remove("idtbm_producto");
                    
                }            
                else if ((opcion==2))
                {
                    dictio.Add("no_compra", sno_compra);
                    dictio.Add("idtbm_bodega", sid_bodega);
                    dictio.Add("cantidad", cant_producto);
                    dictio.Add("idproducto_finalizado", id_producto);
                    db.insertar("tbt_detalle_compra_producto_finalizado", dictio);
                    dictio.Remove("no_compra");
                    dictio.Remove("idtbm_bodega");
                    dictio.Remove("cantidad");
                    dictio.Remove("idproducto_finalizado");

                }
                else if (opcion == 3)
                {
                   
                    dictio.Add("no_compra",sno_compra);
                    dictio.Add("idtbm_bodega",sid_bodega);
                    dictio.Add("idtbm_servicio",id_producto);
                    dictio.Add("costo",cant_producto);
                    db.insertar("tbt_detalle_compra_servicio",dictio);
                    dictio.Remove("no_compra");
                    dictio.Remove("idtbm_bodega");
                    dictio.Remove("idtbm_servicio");
                    dictio.Remove("costo");
                }
            }

        }       
        public void detalle(String tcompra) //TERMINADO
        {
            tbldetalle.Columns.Clear();
          
            if (tcompra.Equals("Materia Prima"))
            {
                //String[] encabezados = { "nocompra", "idtbmbodega", "Fecha_compra", "idtbm_tipo_pago", "idtbm_moneda", "idtbm_tipo_compra", "idtbm_proveedor" };
                               
                //combo de producto
                cmbproducto.DataSource = db.consulta_ComboBox("select idtbm_producto,nombre_producto from tbm_producto");
                cmbproducto.DisplayMember = "nombre_producto";
                cmbproducto.ValueMember = "idtbm_producto"; 

                String[] encabezados = { " no_compra", " idbodega", "idproducto", "NOMBRE PRODUCTO", "CANTIDAD", "COSTO","TOTAL"};
                

                for (int i = 0; i < encabezados.Length; i++)
                {
                    columna = new DataGridViewTextBoxColumn();
                    
                    columna.Name = encabezados[i];
                    if (i <= 2)
                        columna.Visible = false; //convertirlo en false
                    tbldetalle.Columns.Add(columna);
                }
                
            }
            else if (tcompra.Equals("Producto Finalizado"))
            {
                //combo de producto               
                cmbproducto.DataSource = db.consulta_ComboBox("select idproducto_finalizado,nombre_producto_finalizado from producto_finalizado");
                cmbproducto.DisplayMember = "nombre_producto_finalizado";
                cmbproducto.ValueMember = "idproducto_finalizado";

                String[] encabezados = { "no_compra", " idbodega", "idproducto", "NOMBRE PRODUCTO", "CANTIDAD", "PRECIO", "TOTAL" };
                

                for (int i = 0; i < encabezados.Length; i++)
                {
                    columna = new DataGridViewTextBoxColumn();
                    columna.Name = encabezados[i];
                    if (i <= 2)
                        columna.Visible = false; //convertirlo en false
                    tbldetalle.Columns.Add(columna);
                }
                  
            }
            else if(tcompra.Equals("Servicios Varios"))
            {
                //combo de producto
                cmbproducto.DataSource = db.consulta_ComboBox("select idtbm_servicio,nombre_servicio from tbm_servicio");
                cmbproducto.DisplayMember = "nombre_servicio";
                cmbproducto.ValueMember = "idtbm_servicio";

                String[] encabezados = { "no_compra", " idbodega", "idproducto", "NOMBRE PRODUCTO", "PRECIO" };
                

                for (int i = 0; i < encabezados.Length; i++)
                {
                    columna = new DataGridViewTextBoxColumn();
                    columna.Name = encabezados[i];
                    if (i <= 2)
                        columna.Visible = false; //convertirlo en false
                    tbldetalle.Columns.Add(columna);
                }
               
            }
            
        }


        private void cmbtipodecompra_SelectedValueChanged(object sender, EventArgs e)
        {
            stipo_compra = cmbtipodecompra.GetItemText(cmbtipodecompra.SelectedItem); //variable declarada al inicio
            detalle(stipo_compra);
        }

        

        //PARA LAS TABLAS DETALLE
        public void insertar_detalle_materia_prima_y_finalizado(int opcion,int no_compra,int idbodega,string cantidad,int idproducto)
        {
            String query=null;
            if (opcion==1)
            query = "select nombre_producto as 'nombre', costo_producto as 'costo' from tbm_producto where idtbm_producto=" + idproducto;
            if(opcion==2)
            query = "select nombre_producto_finalizado as 'nombre', precio as 'costo' from producto_finalizado where idproducto_finalizado=" + idproducto;
            if (opcion == 3)
                query = "select nombre_servicio as 'nombre' from tbm_servicio where idtbm_servicio=" + idproducto;

            String nombreProducto = null;
            String costo=null;
            double total=0;
            
            ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dic in array)
            {
                nombreProducto=dic["nombre"];            
                if((opcion==1)||(opcion==2))
                costo = dic["costo"];             
            }
            if((opcion==1)||(opcion==2))
            total = Convert.ToDouble(costo) * Convert.ToDouble(cantidad);
            if (opcion == 3)
            total = Convert.ToDouble(cantidad);          

            tbldetalle.Rows.Add(no_compra, idbodega,idproducto,nombreProducto, cantidad,costo,total);
            int indice = tbldetalle.RowCount - 1;
            tbldetalle.FirstDisplayedScrollingRowIndex = indice;
        }
       
       
      
        private void btnagregar_Click(object sender, EventArgs e)
        {
            //insertarPrincipal(cod_compra,id_bodega,"",idtipPago,id_moneda,tipocompra,idproveedor);
          Dictionary<string, string> dic = db.consultar_un_registro("select MAX(no_compra) as 'codigo' from tbm_compra");          
           cod_compra  =Convert.ToInt32(dic["codigo"].ToString())+1; //incrementamos FOREIGN KEY
           
            id_bodega=Convert.ToInt32(cmbbodega.SelectedValue.ToString()); //indice de la bodega

            idtipPago=Convert.ToInt32(cmbtipopago.SelectedValue.ToString()); //indice tipo de pago

            id_moneda=Convert.ToInt32(cmbmoneda.SelectedValue.ToString());

            itipo_compra=Convert.ToInt32(cmbtipodecompra.SelectedValue.ToString());

            idproveedor=Convert.ToInt32(cmbproveedor.SelectedValue.ToString());

            idproducto=Convert.ToInt32(cmbproducto.SelectedValue.ToString());


            cantidad = txtcantidad.Text;
            
            if (stipo_compra.Equals("Materia Prima"))
            {                
                insertar_detalle_materia_prima_y_finalizado(1, cod_compra, id_bodega, cantidad, idproducto);
            }
            else if (stipo_compra.Equals("Producto Finalizado"))
            {
                insertar_detalle_materia_prima_y_finalizado(2, cod_compra, id_bodega, cantidad, idproducto);
            }
            else if (stipo_compra.Equals("Servicios Varios"))
            {
                insertar_detalle_materia_prima_y_finalizado(3, cod_compra, id_bodega, cantidad, idproducto);

            }
            
        }
        

        private void tbldetalle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (stipo_compra.Equals("Materia Prima"))
            {
                txtsumatotal.Text = fun.f2_sum_column(tbldetalle, "TOTAL");
            }
            else if (stipo_compra.Equals("Producto Finalizado"))
            {
                txtsumatotal.Text = fun.f2_sum_column(tbldetalle, "TOTAL");
            }
            else if (stipo_compra.Equals("Servicios Varios"))
            {
                txtsumatotal.Text = fun.f2_sum_column(tbldetalle, "PRECIO");

            }

        }

        private void tbldetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            if (stipo_compra.Equals("Materia Prima"))
            {
                txtsumatotal.Text = fun.f2_sum_column(tbldetalle, "TOTAL");
            }
            else if (stipo_compra.Equals("Producto Finalizado"))
            {
                txtsumatotal.Text = fun.f2_sum_column(tbldetalle, "TOTAL");
            }
            else if (stipo_compra.Equals("Servicios Varios"))
            {
                txtsumatotal.Text = fun.f2_sum_column(tbldetalle, "PRECIO");
            }

            
        }

        private void barra1_click_guardar_button()
        {            
            if (stipo_compra.Equals("Materia Prima"))
            {
                llenado_informacion(1,tbldetalle, cod_compra, id_bodega);
            }
            else if (stipo_compra.Equals("Producto Finalizado"))
            {
                llenado_informacion(2,tbldetalle, cod_compra, id_bodega);
            }
            else if (stipo_compra.Equals("Servicios Varios"))
            {
                llenado_informacion(3,tbldetalle, cod_compra, id_bodega);
            }
        }

        private void tbldetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.fun.color_tabla(tbldetalle);
        }

        private void barra1_click_nuevo_button()
        {
            activar_master();
        }

        public void activar_master()
        {
            foreach (Control combo in panel1.Controls)
            {

                if (combo is ComboBox)
                {
                    combo.Enabled=true;

                }
                
            }

        }
        public void activar_detalle()
        {

        }
        public void desactivar_master()
        {
            foreach (Control combo in panel1.Controls)
            {

                if (combo is ComboBox)
                {
                    
                    combo.Enabled = false;
                }
            }

        }
        public void desactivar_detalle()
        {

        }

        private void barra1_click_actualizar_button()
        {
            String query = "select * from tbm_compra";
            //query = "select tu.no_compra, tu.cantidad";
            //query += "from tbt_detalle_compra_materia_prima tu";
            //query += "INNER JOIN ";


            dataGridView1.DataSource = db.consulta_DataGridView(query);
        }
        
    }     
}

