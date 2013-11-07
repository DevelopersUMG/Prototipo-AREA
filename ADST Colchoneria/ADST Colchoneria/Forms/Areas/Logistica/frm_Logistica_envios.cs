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
// Ejemplo de implementacion de formas jerarquicamente
using ADST_Colchoneria.Forms;
using ADST_Colchoneria.Forms.Areas;
using ADST_Colchoneria.Forms.Areas.Logistica;
using ADST_Colchoneria.Forms.Principal;


namespace ADST_Colchoneria
{
    public partial class frm_Logistica_envios : Form
    {
        public frm_Logistica_envios()
        {
            InitializeComponent();
            button3.Hide();
           // string stQuery = "select tbm_factura_id_factura as 'Factura', tx_ubicacionpedido as 'Ubicacion', tx_estadopedido as 'Estado' from tbm_estadopedido, tbm_ubicacionpedido, tbt_historialenvios where tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=1 and tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=tbm_ubicacionpedido.id_ubicacionpedido and tbt_historialenvios.tbm_estadopedido_id_estadopedido=1 and tbt_historialenvios.tbm_estadopedido_id_estadopedido=tbm_estadopedido.id_estadopedido";
            //string stQuery = "select tbm_factura_id_factura as 'Factura', tx_ubicacionpedido as 'Ubicacion', tx_estadopedido as 'Estado' from tbm_estadopedido, tbm_ubicacionpedido, tbt_historialenvios where tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=1 and tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=tbm_ubicacionpedido.id_ubicacionpedido and tbt_historialenvios.tbm_estadopedido_id_estadopedido=1 and tbt_historialenvios.tbm_estadopedido_id_estadopedido=tbm_estadopedido.id_estadopedido";
            //string stQuery = "select tbm_factura_id_factura as 'Factura', tbm_estadopedido_id_estadopedido as 'Bodega' from tbt_historialenvios where tbm_ubicacionpedido_id_ubicacionpedido=1 and tbm_estadopedido_id_estadopedido=1";
           // ContruirDatagridview(1, stQuery, "");
            tabControl1.TabPages.Remove(tabPage2);

            llenarbodega();
        }

        public void llenarbodega() {
            Historial_Envios x = new Historial_Envios();
            // 1
            dataGridView1.DataSource = (x.historialarea(1));
 

            }
        
    

        string stId_factura = "";
        DBConnect gCon = new DBConnect(Properties.Settings.Default.odbc);

        private void dataGridView1_CellContentClick(object obSender, DataGridViewCellEventArgs evE)
        {
        }

        private void textBox1_TextChanged(object obSender, EventArgs evE)
        {
        }

        private void tabPage2_Click(object obSender, EventArgs evE)
        {
        }

        private void Form1_Load(object obSender, EventArgs evE)
        {   
        }

        public void Obtener_factura()
        {
            stId_factura = "";
            stId_factura = txt_buscar.Text;
        }

        public void AnalizarDATA()
        {
            try
            {
                int inX = 0;
                foreach (DataGridViewRow dgRow in dataGridView2.Rows)
                {
                    DataGridViewCheckBoxCell dgChk = (DataGridViewCheckBoxCell)dgRow.Cells[0];
                    if (dgChk.Value == dgChk.FalseValue || dgChk.Value == null)
                    {
                        dgRow.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        Console.WriteLine("1");
                        dgChk.Value = dgChk.TrueValue;
                        inX++;
                    }
                    else
                    {
                        dgRow.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        Console.WriteLine("2");
                        dgChk.Selected = true;
                        dgChk.Value = dgChk.FalseValue;
                    }
                }
                if (inX == 0)
                {
                    Console.WriteLine("Todo limpio");
                    //agregar reparando
                    agregar_historial(1);
                    salir();
                }
                else
                {
                    MessageBox.Show("Producto faltante");
                }
            }
            catch (Exception fe) {
                creardetalle();
            }
        }

        public void agregar_historial(int inX)
        {
            Historial_Envios x = new Historial_Envios();
           // Console.WriteLine("SE CAMBIO A - - -  estado 2");
            x.historial(inX, stId_factura);
        }

        public void ContruirDatagridview(int inX,string stQuery,string stQueryerror)
        {
            if(inX == 1)
            {
                try
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = gCon.consulta_DataGridView(stQuery);
                }
                catch (Exception exE)
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = gCon.consulta_DataGridView(stQueryerror);
                }
            }
            if(inX == 2)
            {
                dataGridView2.Columns.Clear();
                dataGridView2.DataSource = gCon.consulta_DataGridView(stQuery);
                DataGridViewCheckBoxColumn dgCheckboxColumn = new DataGridViewCheckBoxColumn();
                //CheckBox chk = new CheckBox();    
                dgCheckboxColumn.Width = 20;
                dataGridView2.Columns.Add(dgCheckboxColumn);
            }
        }

        private void button4_Click(object obSender, EventArgs evE)
        {
            // VerificarAmbieguedad();
        }

        private void button1_Click(object obSender, EventArgs evE)
        {
            creardetalle();
            creardetalle();
           }

        private void dataGridView1_Click(object obSender, EventArgs evE)
        {
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void button2_Click(object obSender, EventArgs evE)
        {
            Obtener_factura();
            //crear a que factura hacerle BUSQUEDA

            buscarpendientesunicamente();
          //  string stQuery = "select tbm_factura_id_factura as 'Factura', tx_ubicacionpedido as 'Ubicacion', tx_estadopedido as 'Estado' from tbm_estadopedido, tbm_ubicacionpedido, tbt_historialenvios where tbm_factura_id_factura=" + stId_factura + " and tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=1 and tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=tbm_ubicacionpedido.id_ubicacionpedido and tbt_historialenvios.tbm_estadopedido_id_estadopedido=1 and tbt_historialenvios.tbm_estadopedido_id_estadopedido=tbm_estadopedido.id_estadopedido";
          //  ContruirDatagridview(1, stQuery, "select idAplicaciones AS Codigo, txAplicacion AS Descripcion, frAplicacion AS Cantidad from aplicaciones");
        }

        public void buscarpendientesunicamente() {

            int xx = 0;
         foreach (DataGridViewRow Fila in dataGridView1.Rows)// recorrer fila por fila
            {

             
            string stsubquery="";
            stsubquery = stsubquery + (Convert.ToString(Fila.Cells[0].Value));
           // Console.WriteLine("ENVIOS: "+stsubquery);
            if (stsubquery.Equals(stId_factura)) {
                Historial_Envios x = new Historial_Envios();
                dataGridView1.DataSource = (x.busquedaporarea(1, stId_factura));

                MessageBox.Show("Factura encontrada");

                xx++;
            }

}

         if (xx == 0) { MessageBox.Show("No se encontro la factura");
         button3.Hide();
         button1.Visible = false;
         }
         else
         {


             // Factura encontrada en el area de bodega pendiente
             button1.Visible = true;
         }
    }

        private void tabControl1_Click(object obSender, EventArgs evE)
        {
            confirmar();
            
        }

        private void button3_Click(object obSender, EventArgs evE)
        {
            AnalizarDATA();
           
        }

        private void dataGridView2_CellContentClick(object obSender, DataGridViewCellEventArgs dgE)
        {
        }


        public void salir() {

            DialogResult result = MessageBox.Show("Desea confirmar otro envio?", "Envios", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                confirmar();
                txt_buscar.Text=("");
            }
            else if (result == DialogResult.No)
            {

                this.Hide();

            }
           
        
        }

        public void confirmar() {

            Historial_Envios x = new Historial_Envios();
            dataGridView1.DataSource = (x.historialarea(1));
            this.tabControl1.SelectedIndex = 0;
            tabControl1.TabPages.Remove(tabPage2);
            button1.Visible = false;
            button3.Hide();
        }


        public void creardetalle() {


            Obtener_factura();
            this.tabControl1.SelectedIndex = 1;

            try
            {
                string stQuery1 = "select (select nombre from tbm_departamentos where tbm_departamentos.idtbm_departamentos=(select idtbm_departamentos from tbm_municipio where tbm_municipio.idtbm_municipio=(select idtbm_municipio from tbm_cliente where tbm_cliente.idtbm_cliente=tbm_factura.idtbm_cliente)))AS departamento,(select nombre from tbm_municipio where tbm_municipio.idtbm_municipio=(select idtbm_municipio from tbm_cliente where tbm_cliente.idtbm_cliente=tbm_factura.idtbm_cliente))AS municipio,(select direccion_cliente from tbm_cliente where tbm_cliente.idtbm_cliente=tbm_factura.idtbm_cliente)AS direccion,(select nombre_cliente from tbm_cliente where tbm_cliente.idtbm_cliente=tbm_factura.idtbm_cliente) AS cliente from tbm_factura where no_factura=" + stId_factura + "";
                string stQuery = "select cantidad AS Cantidad,idtbm_bodega AS Descripcion from tbt_detalle_factura where no_factura=" + stId_factura + "";
                System.Collections.ArrayList arArray = gCon.consultar(stQuery1);
                foreach (Dictionary<string, string> dict in arArray)
                {
                    textBox2.Text = dict["cliente"];
                    textBox3.Text = dict["direccion"];
                    textBox4.Text = dict["departamento"];
                    textBox5.Text = dict["municipio"];
                } 
                
                ContruirDatagridview(2, stQuery, "");
                
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Insert(1, tabPage2);

            tabControl1.SelectTab("tabPage2");
        button3.Show();

            }
            catch (Exception fe)
            {
                Console.WriteLine("Error ala hora de consultar detalle de factura");
            }

        
        
        }
    }
}