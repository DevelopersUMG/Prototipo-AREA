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
    public partial class fr_consultas : Form
    {
        public fr_consultas()
        {
            InitializeComponent();
        }
        DBConnect con = new DBConnect(Properties.Settings.Default.odbc);


        private void barra1_click_buscar_button()
        {
            gb_consultas.Visible = true;
            sumaresta s = new sumaresta();
            s.sumaprof(1, 25, 1);
        }

        private void barra2_click_buscar_button()
        {
            if (!cb_opg.Text.Equals("Elija una opción"))
            {

                String pal = cb_opg.SelectedItem.ToString();
                if (pal.Equals("Producto"))
                {
                    dg_cg.DataSource = con.consulta_DataGridView("SELECT a.id_producto, a.nombre_producto AS 'Nombre del Producto', a.descripcion_producto AS 'Descripción', b.cantidad AS 'Cantidad', b.idtbm_bodega AS 'ID Bodega', b.idtbm_producto, c.idtbm_bodega, c.nombre_bodega as 'Nombre Bodega' FROM tbm_producto AS a, tbt_inventario_producto AS b, tbm_bodega AS c WHERE a.id_producto = b.idtbm_producto AND b.idtbm_bodega = c.idtbm_bodega");
                    dg_cg.Columns[0].Visible = false;
                    dg_cg.Columns[4].Visible = false;
                    dg_cg.Columns[5].Visible = false;
                    dg_cg.Columns[6].Visible = false;
                    dg_cg.Visible = true;
                }
                else
                {
                    if (pal.Equals("Producto Finalizado"))
                    {
                        dg_cg.DataSource = con.consulta_DataGridView("SELECT a.id_producto_finalizado, a.nombre_producto_finalizado AS 'Nombre del Producto', a.descripcion_producto_finalizado AS 'Descripción', a.precio_producto_finalizado AS 'Precio', b.cantidad AS 'Cantidad', b.idtbm_bodega AS 'ID Bodega', b.idproducto_finalizado, c.idtbm_bodega, c.nombre_bodega as 'Nombre Bodega' FROM tbm_producto_finalizado AS a, tbt_inventario_producto_finalizado AS b, tbm_bodega AS c WHERE a.id_producto_finalizado = b.idproducto_finalizado AND b.idtbm_bodega = c.idtbm_bodega");
                        dg_cg.Columns[0].Visible = false;
                        dg_cg.Columns[5].Visible = false;
                        dg_cg.Columns[6].Visible = false;
                        dg_cg.Columns[7].Visible = false;
                        dg_cg.Visible = true;
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            cb_pf.Visible = false;
            dg_consulta.Columns.Clear();
            if (rd_op1.Checked == true)
                {
            if (!cb_opcion.Text.Equals("Elija una opción"))
            {
                
                    String pal = cb_opcion.SelectedItem.ToString();
                    if (pal.Equals("Productos"))
                    {
                        dg_consulta.Columns.Clear();
                        dg_consulta.DataSource = con.consulta_DataGridView("select a.idtbm_bodega ,a.idtbm_producto, b.id_producto,c.nombre_bodega as 'Nombre Bodega', b.nombre_producto as 'Nombre Producto', a.cantidad as 'Existencia', c.idtbm_bodega  from tbt_inventario_producto as a, tbm_producto as b, tbm_bodega as c where a.idtbm_bodega=c.idtbm_bodega and a.idtbm_producto=b.id_producto");
                        dg_consulta.Columns[0].Visible = false;
                        dg_consulta.Columns[1].Visible = false;
                        dg_consulta.Columns[2].Visible = false;
                        dg_consulta.Columns[3].Width = 110;
                        dg_consulta.Columns[4].Width = 120;
                        dg_consulta.Columns[5].Width = 110;
                        dg_consulta.Columns[6].Visible = false;
                        dg_consulta.Visible = true;



                    }
                    else
                    {
                        if (pal.Equals("Producto Finalizado"))
                        {
                            dg_consulta.Columns.Clear();
                            dg_consulta.DataSource = con.consulta_DataGridView("select a.idtbm_bodega ,a.idproducto_finalizado, b.id_producto_finalizado,c.nombre_bodega as 'Nombre Bodega', b.nombre_producto_finalizado as 'Nombre Producto', a.cantidad as 'Existencia', c.idtbm_bodega  from tbt_inventario_producto_finalizado as a, tbm_producto_finalizado as b, tbm_bodega as c where a.idtbm_bodega=c.idtbm_bodega and a.idproducto_finalizado=b.id_producto_finalizado");
                            dg_consulta.Columns[0].Visible = false;
                            dg_consulta.Columns[1].Visible = false;
                            dg_consulta.Columns[2].Visible = false;
                            dg_consulta.Columns[3].Width = 110;
                            dg_consulta.Columns[4].Width = 120;
                            dg_consulta.Columns[5].Width = 110;
                            dg_consulta.Columns[6].Visible = false;
                            dg_consulta.Visible = true;
                        }
                    }
                }
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible =false;
            cb_pf.Visible = false;
            dg_consulta.Columns.Clear();
            if (rd_op2.Checked == true)
            {
                if (!cb_opcion.Text.Equals("Elija una opción"))
                {

                    String pal = cb_opcion.SelectedItem.ToString();
                    if (pal.Equals("Productos"))
                    {
                        dg_consulta.Columns.Clear();
                        dg_consulta.DataSource = con.consulta_DataGridView("select a.idtbm_bodega ,a.idtbm_producto, b.id_producto, b.nombre_producto as 'Nombre Producto', c.nombre_bodega as 'Nombre Bodega', a.cantidad as 'Existencia', c.idtbm_bodega  from tbt_inventario_producto as a, tbm_producto as b, tbm_bodega as c where a.idtbm_bodega=c.idtbm_bodega and a.idtbm_producto=b.id_producto");
                        dg_consulta.Columns[0].Visible = false;
                        dg_consulta.Columns[1].Visible = false;
                        dg_consulta.Columns[2].Visible = false;
                        dg_consulta.Columns[3].Width = 120;
                        dg_consulta.Columns[4].Width = 120;
                        dg_consulta.Columns[5].Width = 110;
                        dg_consulta.Columns[6].Visible = false;
                        dg_consulta.Visible = true;



                    }
                    else
                    {
                        if (pal.Equals("Producto Finalizado"))
                        {
                            dg_consulta.Columns.Clear();
                            dg_consulta.DataSource = con.consulta_DataGridView("select a.idtbm_bodega ,a.idproducto_finalizado, b.id_producto_finalizado,b.nombre_producto_finalizado as 'Nombre Producto',c.nombre_bodega as 'Nombre Bodega', a.cantidad as 'Existencia', c.idtbm_bodega  from tbt_inventario_producto_finalizado as a, tbm_producto_finalizado as b, tbm_bodega as c where a.idtbm_bodega=c.idtbm_bodega and a.idproducto_finalizado=b.id_producto_finalizado");
                            dg_consulta.Columns[0].Visible = false;
                            dg_consulta.Columns[1].Visible = false;
                            dg_consulta.Columns[2].Visible = false;
                            dg_consulta.Columns[3].Width = 120;
                            dg_consulta.Columns[4].Width = 120;
                            dg_consulta.Columns[5].Width = 110;
                            dg_consulta.Columns[6].Visible = false;
                            dg_consulta.Visible = true;
                        }
                    }
                }
            }

        }

        private void barra1_click_actualizar_button()
        {
            if (rd_op2.Checked == true)
            {
                label3.Visible = false;
                cb_pf.Visible = false;
                dg_consulta.Columns.Clear();
                if (rd_op1.Checked == true)
                {
                    if (!cb_opcion.Text.Equals("Elija una opción"))
                    {

                        String pal = cb_opcion.SelectedItem.ToString();
                        if (pal.Equals("Productos"))
                        {
                            dg_consulta.Columns.Clear();
                            dg_consulta.DataSource = con.consulta_DataGridView("select a.idtbm_bodega ,a.idtbm_producto, b.id_producto,c.nombre_bodega as 'Nombre Bodega', b.nombre_producto as 'Nombre Producto', a.cantidad as 'Existencia', c.idtbm_bodega  from tbt_inventario_producto as a, tbm_producto as b, tbm_bodega as c where a.idtbm_bodega=c.idtbm_bodega and a.idtbm_producto=b.id_producto");
                            dg_consulta.Columns[0].Visible = false;
                            dg_consulta.Columns[1].Visible = false;
                            dg_consulta.Columns[2].Visible = false;
                            dg_consulta.Columns[3].Width = 110;
                            dg_consulta.Columns[4].Width = 120;
                            dg_consulta.Columns[5].Width = 110;
                            dg_consulta.Columns[6].Visible = false;
                            dg_consulta.Visible = true;



                        }
                        else
                        {
                            if (pal.Equals("Producto Finalizado"))
                            {
                                dg_consulta.Columns.Clear();
                                dg_consulta.DataSource = con.consulta_DataGridView("select a.idtbm_bodega ,a.idproducto_finalizado, b.id_producto_finalizado,c.nombre_bodega as 'Nombre Bodega', b.nombre_producto_finalizado as 'Nombre Producto', a.cantidad as 'Existencia', c.idtbm_bodega  from tbt_inventario_producto_finalizado as a, tbm_producto_finalizado as b, tbm_bodega as c where a.idtbm_bodega=c.idtbm_bodega and a.idproducto_finalizado=b.id_producto_finalizado");
                                dg_consulta.Columns[0].Visible = false;
                                dg_consulta.Columns[1].Visible = false;
                                dg_consulta.Columns[2].Visible = false;
                                dg_consulta.Columns[3].Width = 110;
                                dg_consulta.Columns[4].Width = 120;
                                dg_consulta.Columns[5].Width = 110;
                                dg_consulta.Columns[6].Visible = false;
                                dg_consulta.Visible = true;
                            }
                        }
                    }
                }

            }
            else
            {
                if (rd_op1.Checked == true)
                {
                    label3.Visible = false;
                    cb_pf.Visible = false;
                    dg_consulta.Columns.Clear();
                    if (rd_op1.Checked == true)
                    {
                        if (!cb_opcion.Text.Equals("Elija una opción"))
                        {

                            String pal = cb_opcion.SelectedItem.ToString();
                            if (pal.Equals("Productos"))
                            {
                                dg_consulta.Columns.Clear();
                                dg_consulta.DataSource = con.consulta_DataGridView("select a.idtbm_bodega ,a.idtbm_producto, b.id_producto,c.nombre_bodega as 'Nombre Bodega', b.nombre_producto as 'Nombre Producto', a.cantidad as 'Existencia', c.idtbm_bodega  from tbt_inventario_producto as a, tbm_producto as b, tbm_bodega as c where a.idtbm_bodega=c.idtbm_bodega and a.idtbm_producto=b.id_producto");
                                dg_consulta.Columns[0].Visible = false;
                                dg_consulta.Columns[1].Visible = false;
                                dg_consulta.Columns[2].Visible = false;
                                dg_consulta.Columns[3].Width = 110;
                                dg_consulta.Columns[4].Width = 120;
                                dg_consulta.Columns[5].Width = 110;
                                dg_consulta.Columns[6].Visible = false;
                                dg_consulta.Visible = true;



                            }
                            else
                            {
                                if (pal.Equals("Producto Finalizado"))
                                {
                                    dg_consulta.Columns.Clear();
                                    dg_consulta.DataSource = con.consulta_DataGridView("select a.idtbm_bodega ,a.idproducto_finalizado, b.id_producto_finalizado,c.nombre_bodega as 'Nombre Bodega', b.nombre_producto_finalizado as 'Nombre Producto', a.cantidad as 'Existencia', c.idtbm_bodega  from tbt_inventario_producto_finalizado as a, tbm_producto_finalizado as b, tbm_bodega as c where a.idtbm_bodega=c.idtbm_bodega and a.idproducto_finalizado=b.id_producto_finalizado");
                                    dg_consulta.Columns[0].Visible = false;
                                    dg_consulta.Columns[1].Visible = false;
                                    dg_consulta.Columns[2].Visible = false;
                                    dg_consulta.Columns[3].Width = 110;
                                    dg_consulta.Columns[4].Width = 120;
                                    dg_consulta.Columns[5].Width = 110;
                                    dg_consulta.Columns[6].Visible = false;
                                    dg_consulta.Visible = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (rd_op3.Checked == true)
                        {
                            dg_consulta.Columns.Clear();
                            cb_pf.Items.Clear();
                            if (rd_op3.Checked == true)
                            {
                                if (!cb_opcion.Text.Equals("Elija una opción"))
                                {

                                    String pal = cb_opcion.SelectedItem.ToString();
                                    if (pal.Equals("Productos"))
                                    {
                                        label3.Visible = true;
                                        cb_pf.Visible = true;
                                        string query = "select nombre_producto from tbm_producto";
                                        ArrayList array = con.consultar(query);
                                        foreach (Dictionary<string, string> v in array)
                                        {
                                            cb_pf.Items.Add(v["nombre_producto"]);

                                        }



                                    }
                                    else
                                    {
                                        if (pal.Equals("Producto Finalizado"))
                                        {
                                            label3.Visible = true;
                                            cb_pf.Visible = true;
                                            string query = "select nombre_producto_finalizado from tbm_producto_finalizado";
                                            ArrayList array = con.consultar(query);
                                            foreach (Dictionary<string, string> v in array)
                                            {
                                                cb_pf.Items.Add(v["nombre_producto_finalizado"]);

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
 
                }
               
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dg_consulta.Columns.Clear();
            cb_pf.Items.Clear();
            if (rd_op3.Checked == true)
            {
                if (!cb_opcion.Text.Equals("Elija una opción"))
                {

                    String pal = cb_opcion.SelectedItem.ToString();
                    if (pal.Equals("Productos"))
                    {
                        label3.Visible = true;
                        cb_pf.Visible = true;
                        string query = "select nombre_producto from tbm_producto";
                        ArrayList array = con.consultar(query);
                        foreach (Dictionary<string, string> v in array)
                        {
                            cb_pf.Items.Add(v["nombre_producto"]);

                        }



                    }
                    else
                    {
                        if (pal.Equals("Producto Finalizado"))
                        {
                            label3.Visible = true;
                            cb_pf.Visible = true;
                            string query = "select nombre_producto_finalizado from tbm_producto_finalizado";
                            ArrayList array = con.consultar(query);
                            foreach (Dictionary<string, string> v in array)
                            {
                                cb_pf.Items.Add(v["nombre_producto_finalizado"]);

                            }
                        }
                    }
                }
            }
 
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cb_pf.Text.Equals("Elija una opción"))
            {
                String pal = cb_opcion.SelectedItem.ToString();
                String sel = cb_pf.SelectedItem.ToString();
                int id = 0;
                if (pal.Equals("Productos"))
                {
                    string query = "select id_producto,nombre_producto from tbm_producto where nombre_producto='" + sel + "'";
                    ArrayList array = con.consultar(query);
                    foreach (Dictionary<string, string> v in array)
                    {
                        id = Convert.ToInt32(v["id_producto"]);
                    }
                    dg_consulta.DataSource = con.consulta_DataGridView("select a.id_producto, a.nombre_producto as 'Nombre Producto',c.nombre_bodega as 'Nombre Bodega', b.cantidad as 'Existencia', b.idtbm_producto, b.idtbm_bodega, c.idtbm_bodega from tbm_producto as a, tbt_inventario_producto as b, tbm_bodega as c where  b.idtbm_producto='" + id + "' and a.id_producto='" + id + "' and b.idtbm_bodega=c.idtbm_bodega");
                    dg_consulta.Columns[0].Visible = false;
                    dg_consulta.Columns[1].Width = 120;
                    dg_consulta.Columns[2].Width = 120;
                    dg_consulta.Columns[3].Width = 120;
                    dg_consulta.Columns[4].Visible = false;
                    dg_consulta.Columns[5].Visible = false;
                    dg_consulta.Columns[6].Visible = false;
                    dg_consulta.Visible = true;
                }
                else
                {
                    if (pal.Equals("Producto Finalizado"))
                    {
                        string query = "select id_producto_finalizado,nombre_producto_finalizado from tbm_producto_finalizado where nombre_producto_finalizado='" + sel + "'";
                        ArrayList array = con.consultar(query);
                        foreach (Dictionary<string, string> v in array)
                        {
                            id = Convert.ToInt32(v["id_producto_finalizado"]);
                        }
                        dg_consulta.DataSource = con.consulta_DataGridView("select a.id_producto_finalizado, a.nombre_producto_finalizado as 'Nombre Producto',c.nombre_bodega as 'Nombre Bodega', b.cantidad as 'Existencia', b.idproducto_finalizado, b.idtbm_bodega, c.idtbm_bodega from tbm_producto_finalizado as a, tbt_inventario_producto_finalizado as b, tbm_bodega as c where  b.idproducto_finalizado='" + id + "' and a.id_producto_finalizado='" + id + "' and b.idtbm_bodega=c.idtbm_bodega");
                        dg_consulta.Columns[0].Visible = false;
                        dg_consulta.Columns[1].Width = 120;
                        dg_consulta.Columns[2].Width = 120;
                        dg_consulta.Columns[3].Width = 120;
                        dg_consulta.Columns[4].Visible = false;
                        dg_consulta.Columns[5].Visible = false;
                        dg_consulta.Columns[6].Visible = false;
                        dg_consulta.Visible = true;
                    }
                }
            }

        }

        
       
        

       
       

       

      

        

       
    }
}
