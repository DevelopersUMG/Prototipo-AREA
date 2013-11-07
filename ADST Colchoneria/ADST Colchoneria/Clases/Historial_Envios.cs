using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;
using System.Data.Odbc;
//Ejemplo de implementacion de formas jerarquicamente
using ADST_Colchoneria.Forms;
using ADST_Colchoneria.Forms.Areas;
using ADST_Colchoneria.Forms.Areas.Logistica;
using ADST_Colchoneria.Forms.Principal;

namespace ADST_Colchoneria.Forms.Areas.Logistica
{
    class Historial_Envios
    {

        DBConnect gCon = new DBConnect(Properties.Settings.Default.odbc);

        public void historial(int inCaso, string stFactura)
        {
            int inEstado = 0;
            int inUbicacion = 0;
            DateTime dtActual = DateTime.Now;
            string stFormat_datetime = "yyyy-MM-dd HH:mm:ss";
            switch (inCaso)
            {
                case 0://ingreso de nueva factura, area comercial
                    inUbicacion = 1;
                    inEstado = 1;
                    break;

                case 1: //validacion de producto, area logistica
                   // Console.WriteLine("SE CAMBIO A - - -  estado 2"+inUbicacion+"   - "+inEstado);
                    inUbicacion = 1;
                    inEstado = 2;
                    break;

                case 2: //producto seleccionado y apartado, listo para ser cargado al camion, planificado su envio en viaje especifico, area logistica
                    inUbicacion = 2;
                    inEstado = 2;
                    break;

                case 3: //producto cargado al camion, viaje en ruta, producto en camino, "shipping", area logistica
                    inUbicacion = 3;
                    inEstado = 2;
                    break;

                case 4: //confirmacion de entrega de producto a destinatario, area logistica
                    inUbicacion = 4;
                    inEstado = 2;
                    break;

                case 5: //confirmacion de anulacion o declinacion a pedido por parte de destinatario, area logistica
                        //confirmacion de anulacion de pedido, area comercial o financiera
                    inUbicacion = 4;
                    inEstado = 3;
                    break;
            }
            string stTabla1 = "tbt_historialenvios";
            Dictionary<string, string> diDict2x2_1 = new Dictionary<string, string>();
            diDict2x2_1.Add("tx_fecha", dtActual.ToString(stFormat_datetime));
            diDict2x2_1.Add("tbm_factura_id_factura", stFactura);
            diDict2x2_1.Add("tbm_ubicacionpedido_id_ubicacionpedido", inUbicacion.ToString());
            diDict2x2_1.Add("tbm_estadopedido_id_estadopedido", inEstado.ToString());
            gCon.insertar(stTabla1, diDict2x2_1);
            Console.WriteLine(" >> "+diDict2x2_1);
            //Console.WriteLine("Fecha y hora: " + DateTime.Now.ToShortTimeString());
            if (inEstado == 2)
            {
                if (inUbicacion != 4)
                {
                    inUbicacion++;
                    inEstado = 1;
                    string stTabla2 = "tbt_historialenvios";
                    Dictionary<string, string> diDict2x2_2 = new Dictionary<string, string>();
                    diDict2x2_2.Add("tx_fecha", dtActual.ToString(stFormat_datetime));
                    diDict2x2_2.Add("tbm_factura_id_factura", stFactura);
                    diDict2x2_2.Add("tbm_ubicacionpedido_id_ubicacionpedido", inUbicacion.ToString());
                    diDict2x2_2.Add("tbm_estadopedido_id_estadopedido", inEstado.ToString());
                    gCon.insertar(stTabla2, diDict2x2_2);
                }
            }
        }


        public BindingSource busquedaporarea(int ubicacion, string filtro)
        {

            //string querybeta="(select tx_ubicacionpedido from tbm_ubicacionpedido where tbm_ubicacionpedido.id_ubicacionpedido=tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido)AS ubicacion";
            string query = "select tbm_factura_id_factura,(select tx_ubicacionpedido from tbm_ubicacionpedido where tbm_ubicacionpedido.id_ubicacionpedido=tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido)AS ubicacion, id_historialenvios from tbt_historialenvios WHERE tbm_ubicacionpedido_id_ubicacionpedido =  " + ubicacion + " and tbm_factura_id_factura=" + filtro + "";
            System.Collections.ArrayList array = gCon.consultar(query);
            int intamanoarray = array.Count;
            DataTable dt = new DataTable();
            dt.Columns.Add("Factura");
            //
            dt.Columns.Add("Ubicacion");
            dt.Columns.Add("Estado");

            foreach (Dictionary<string, string> dict in array)
            {


                dt.Rows.Add(dict["tbm_factura_id_factura"].ToString(), dict["ubicacion"].ToString(), "pendiente");
                //    dt.Rows.Add(new object[] { dict["tbm_factura_id_factura"].ToString() }, new object[] { "hoa" }, new object[] { "hoa" });//+stubicacion);//,"pendiente");



            }

            var source = new BindingSource();
            source.DataSource = dt;
            return source;


        }
        public BindingSource historialarea(int ubicacion)
        {
            // 
            //string querybeta="(select tx_ubicacionpedido from tbm_ubicacionpedido where tbm_ubicacionpedido.id_ubicacionpedido=tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido)AS ubicacion";
            string stQuery = "select tbm_factura_id_factura,(select tx_ubicacionpedido from tbm_ubicacionpedido where tbm_ubicacionpedido.id_ubicacionpedido=tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido)AS ubicacion, id_historialenvios from tbt_historialenvios WHERE tbm_ubicacionpedido_id_ubicacionpedido =  " + ubicacion + "";
            System.Collections.ArrayList arArray = gCon.consultar(stQuery);
            int inTamano_array = arArray.Count;
            DataTable dtTable = new DataTable();
            dtTable.Columns.Add("Factura");
            //
            dtTable.Columns.Add("Ubicacion");
            dtTable.Columns.Add("Estado");
            foreach (Dictionary<string, string> dict in arArray)
            {
                string stQuery2 = "select id_historialenvios from tbt_historialenvios WHERE tbm_factura_id_factura=" + dict["tbm_factura_id_factura"] + " and (tbm_estadopedido_id_estadopedido =  '3' or tbm_estadopedido_id_estadopedido =  '2') and tbm_ubicacionpedido_id_ubicacionpedido="+ubicacion+"";
                
                       
               
                System.Collections.ArrayList arArray2 = gCon.consultar(stQuery2);
                int inTamano_array2 = arArray2.Count;

               
                if (inTamano_array2 > 0)
                {
                    //MessageBox.Show("XX - - - " + stQuery2);  
                }
                else
                {
                    //MessageBox.Show("2XX - - - "+stQuery2);  
                    dtTable.Rows.Add(dict["tbm_factura_id_factura"].ToString(), dict["ubicacion"].ToString(), "pendiente");
                    //dt.Rows.Add(new object[] { dict["tbm_factura_id_factura"].ToString() }, new object[] { "hoa" }, new object[] { "hoa" });//+stubicacion);//,"pendiente");
                }
            }
            var vaSource = new BindingSource();
            vaSource.DataSource = dtTable;
            return vaSource;
        }
    }
}