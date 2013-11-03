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

namespace ADST_Colchoneria
{
    public partial class frm_Logistica_envios : Form
    {
        public frm_Logistica_envios()
        {
            InitializeComponent();
            
            
            string query = "select idAplicaciones AS Codigo, txAplicacion AS Descripcion, frAplicacion AS Cantidad from aplicaciones";

            ContruirDatagridview(1, query, "");
            tabControl1.TabPages.Remove(tabPage2);
        }
        DBConnect con = new DBConnect("ADSTConnector");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void AnalizarDATA()
        {
            int x = 0;
        
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
              
               
                if (chk.Value == chk.FalseValue || chk.Value == null)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                  Console.WriteLine("1");
                   chk.Value = chk.TrueValue;
                   x++;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    
                    Console.WriteLine("2");
                   chk.Selected = true;
                  chk.Value = chk.FalseValue;
                 
                }
                
       
            } //if (chk.Value == chk.FalseValue || chk.Value == null)
                    //{
                      //chk.Value = chk.TrueValue;
                   //     Console.WriteLine("1");
                    //}
                   // else
                   // {
                      //  chk.Value = chk.FalseValue;
                     //   Console.WriteLine("2");
                       // x--;
                   // }

                   // Console.WriteLine("Fila: " + (Convert.ToString(Fila.Cells[0].Value)));
                   // if ((Convert.ToString(Fila.Cells[0].Value) == "SI"))
                   // {

                   //     inControl_pk = 1;
                   // }
                   // if ((Convert.ToString(Fila.Cells[1].Value) == ""))
                    //{
                    //    inControl_cr = 1;

                   // }

                   // x++;
                
            if (x == 0) { Console.WriteLine("Todo limpio"); } else { Console.WriteLine("Falta"); }
            }



        private void CreateUnboundButtonColumn()
        {
            // Initialize the button column.
            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();
            buttonColumn.Name = "Details";
            buttonColumn.HeaderText = "Details";
            buttonColumn.Text = "View Details";

            // Use the Text property for the button text for all cells rather
            // than using each cell's value as the text for its own button.
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the control.
            dataGridView1.Columns.Insert(0, buttonColumn);
        }
        public void ContruirDatagridview(int x,string query,string queryerror) {
            if (x == 1) {
             try{
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = con.consulta_DataGridView(query);


             }
             catch (Exception xe)
             {
                 dataGridView1.Columns.Clear();
                 dataGridView1.DataSource = con.consulta_DataGridView(queryerror);

             }
            }

            if (x == 2)
            {
                
                    dataGridView2.Columns.Clear();
                    dataGridView2.DataSource = con.consulta_DataGridView(query);


                    DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
                    //CheckBox chk = new CheckBox();    
                    CheckboxColumn.Width = 20;
                    dataGridView2.Columns.Add(CheckboxColumn);
    
            }
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
           // VerificarAmbieguedad();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            this.tabControl1.SelectedIndex = 1;
            string query = "select idAplicaciones AS Codigo, txAplicacion AS Descripcion, frAplicacion AS Cantidad from aplicaciones";
            
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Insert(1, tabPage2);
ContruirDatagridview(2,query,"");
            tabControl1.SelectTab("tabPage2");
        }

 

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string query = "select idAplicaciones AS Codigo, txAplicacion AS Descripcion, frAplicacion AS Cantidad from aplicaciones where idAplicaciones=" + txt_buscar .Text+ "";

            ContruirDatagridview(1, query, "select idAplicaciones AS Codigo, txAplicacion AS Descripcion, frAplicacion AS Cantidad from aplicaciones");
           
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            
           
                string query = "select idAplicaciones AS Codigo, txAplicacion AS Descripcion, frAplicacion AS Cantidad from aplicaciones";
            
            ContruirDatagridview(1, query,"");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnalizarDATA();
        }

        }







    }



