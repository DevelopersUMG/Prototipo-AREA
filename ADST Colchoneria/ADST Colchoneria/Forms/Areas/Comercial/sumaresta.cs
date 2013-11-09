using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ODBCConnect;
using System.Collections;
namespace ADST_Colchoneria
{
    class sumaresta
    {
        DBConnect con = new DBConnect(Properties.Settings.Default.odbc);
        int cantid = 0;
        //Suma y Resta Materia Prima
        public void sumamat(int idpro, int cant,int idbod)
        {
            int s1 = 0;
            int s2 = 0;
            string query4 = "select count(idtbm_producto) as 's1', count(idtbm_bodega) as 's2' from tbt_inventario_producto where idtbm_producto='" + idpro+"' and idtbm_bodega='"+idbod+"'" ;
            ArrayList array2 = con.consultar(query4);
            foreach (Dictionary<string, string> v1 in array2)
            {
                s1 = Convert.ToInt32(v1["s1"]);
                s2 = Convert.ToInt32(v1["s2"]);
                if ((s1 > 0) && (s2 > 0))
                {
                    string query = "select cantidad from tbt_inventario_producto where idtbm_bodega='" + idbod + "' and idtbm_producto='" + idpro + "'";

                    ArrayList array = con.consultar(query);
                    foreach (Dictionary<string, string> v in array)
                    {
                        cantid = Convert.ToInt32(v["cantidad"]);
                    }
                    String tabla = "tbt_inventario_producto";
                    Dictionary<String, String> dict;
                    dict = new Dictionary<String, String>();
                    dict.Add("cantidad", (cantid + cant).ToString());
                    con.actualizar(tabla, dict, "idtbm_bodega='" + idbod + "' and idtbm_producto='" + idpro + "'");
                    MessageBox.Show("Actualizado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos, no se puede actualizar", "Error", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            
        }

        public void restamat(int idpro, int cant, int idbod)
        {
            int s1 = 0;
            int s2 = 0;
            string query4 = "select count(idtbm_producto) as 's1', count(idtbm_bodega) as 's2' from tbt_inventario_producto where idtbm_producto='" + idpro + "' and idtbm_bodega='" + idbod + "'";
            ArrayList array2 = con.consultar(query4);
            foreach (Dictionary<string, string> v1 in array2)
            {
                s1 = Convert.ToInt32(v1["s1"]);
                s2 = Convert.ToInt32(v1["s2"]);
                if ((s1 > 0) && (s2 > 0))
                {
                    String query = "select cantidad from tbt_inventario_producto where idtbm_bodega='" + idbod + "' and idtbm_producto='" + idpro + "'";

                    ArrayList array = con.consultar(query);
                    foreach (Dictionary<string, string> v in array)
                    {
                        cantid = Convert.ToInt32(v["cantidad"]);
                    }
                    //MessageBox.Show(cantid.ToString());
                    String tabla = "tbt_inventario_producto";
                    Dictionary<String, String> dict;
                    dict = new Dictionary<String, String>();
                    dict.Add("cantidad", (cantid - cant).ToString());
                    if ((cantid > 0) && (cant < cantid))
                    {
                        con.actualizar(tabla, dict, "idtbm_bodega='" + idbod + "' and idtbm_producto='" + idpro + "'");
                        MessageBox.Show("Actualizado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos, no se puede actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        //Suma y Resta Materia Finalizado
        public void sumaprof(int idpro, int cant, int idbod)
        {
            int s1 = 0;
            int s2 = 0;
            string query4 = "select count(idproducto_finalizado) as 's1', count(idtbm_bodega) as 's2' from tbt_inventario_producto_finalizado where idproducto_finalizado='" + idpro + "' and idtbm_bodega='" + idbod + "'";
            ArrayList array2 = con.consultar(query4);
            foreach (Dictionary<string, string> v1 in array2)
            {
                s1 = Convert.ToInt32(v1["s1"]);
                s2 = Convert.ToInt32(v1["s2"]);
                if ((s1 > 0) && (s2 > 0))
                {
                    string query = "select cantidad from tbt_inventario_producto_finalizado where idtbm_bodega='" + idbod + "' and idproducto_finalizado='" + idpro + "'";

                    ArrayList array = con.consultar(query);
                    foreach (Dictionary<string, string> v in array)
                    {
                        cantid = Convert.ToInt32(v["cantidad"]);
                    }

                    String tabla = "tbt_inventario_producto_finalizado";
                    Dictionary<String, String> dict;
                    dict = new Dictionary<String, String>();
                    dict.Add("cantidad", (cantid + cant).ToString());
                    con.actualizar(tabla, dict, "idtbm_bodega='" + idbod + "' and idproducto_finalizado='" + idpro + "'");
                    MessageBox.Show("Actualizado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos, no se puede actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }   
        }

        public void restaprof(int idpro, int cant, int idbod)
        {
            int s1 = 0;
            int s2 = 0;
            string query4 = "select count(idproducto_finalizado) as 's1', count(idtbm_bodega) as 's2' from tbt_inventario_producto_finalizado where idproducto_finalizado='" + idpro + "' and idtbm_bodega='" + idbod + "'";
            ArrayList array2 = con.consultar(query4);
            foreach (Dictionary<string, string> v1 in array2)
            {
                s1 = Convert.ToInt32(v1["s1"]);
                s2 = Convert.ToInt32(v1["s2"]);
                if ((s1 > 0) && (s2 > 0))
                {
                    string query = "select cantidad from tbt_inventario_producto_finalizado where idtbm_bodega='" + idbod + "' and idproducto_finalizado='" + idpro + "'";

                    ArrayList array = con.consultar(query);
                    foreach (Dictionary<string, string> v in array)
                    {
                        cantid = Convert.ToInt32(v["cantidad"]);
                    }

                    String tabla = "tbt_inventario_producto_finalizado";
                    Dictionary<String, String> dict;
                    dict = new Dictionary<String, String>();
                    dict.Add("cantidad", (cantid - cant).ToString());
                    if ((cantid > 0) && (cant < cantid))
                    {
                        con.actualizar(tabla, dict, "idtbm_bodega='" + idbod + "' and idproducto_finalizado='" + idpro + "'");
                        MessageBox.Show("Actualizado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos, no se puede actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }   
        }
    }
}
