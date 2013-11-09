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
    public partial class fr_Proveedores : Form
    {
        public fr_Proveedores()
        {
            InitializeComponent();
            desactivar();
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        funciones_canel fun = new funciones_canel();      

        private void barra1_click_nuevo_button()
        {
            activar();
        }

        private void barra1_click_guardar_button()
        {
            if (fun.estado_insercion(panel1) == 0)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre_proveedor", txtproveedor.Text);
                dict.Add("telefono_nombre_proveedor", txttelefono.Text);
                dict.Add("direccion_nombre_proveedor", txtdireccion.Text);
                db.insertar("tbm_proveedor", dict);
                this.desactivar();
            }
        }


        public void activar()
        {
            fun.activar_controles(panel1);
        }

        public void desactivar()
        {
            fun.desactivar_controles(panel1);
        }

    }
}
