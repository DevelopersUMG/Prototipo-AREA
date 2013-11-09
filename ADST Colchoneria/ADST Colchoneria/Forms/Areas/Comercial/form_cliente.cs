using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;


namespace WindowsFormsApplication1
{
    public partial class form_clientes : Form
    {

        private DBConnect db = new DBConnect("area_comercial");
        private bool band = false,cambio = false, band_edit = false, band_nuevo = false, band_eliminar = false;

        public form_clientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void CLientes_Load(object sender, EventArgs e)
        {

            consultar();

            ocultar();



        }
        private void consultar()
        {
            string query2 = "select c.idtbm_cliente as 'ID', c.nombre_cliente as 'Nombre', c.nit_cliente as 'NIT', c.direccion_cliente as 'Direccion', m.nombre as 'Municipio', d.nombre as 'Departamento' from tbm_cliente c, tbm_municipio m, tbm_departamentos d where c.idtbm_municipio = m.idtbm_municipio and m.idtbm_departamentos = d.idtbm_departamentos";
            grid_clientes.DataSource = db.consulta_DataGridView(query2);
            grid_clientes.Columns[0].Visible = false;
        }

        public void ocultar()
        {
            text_nombre_cliente.Enabled = false;
            text_nit.Enabled = false;
            text_direccion.Enabled = false;
            box_departamento.Enabled = false;
            box_municipio.Enabled = false;
            label_nombre.Enabled = false;
            label_nit.Enabled = false;
            label_municipio.Enabled = false;
            label_direccion.Enabled = false;
            label_departamento.Enabled = false;
        }
        public void mostrar()
        {
            text_nombre_cliente.Enabled = true;
            text_nit.Enabled = true;
            text_direccion.Enabled = true;
            box_departamento.Enabled = true;
            box_municipio.Enabled = true;
            label_nombre.Enabled = true;
            label_nit.Enabled = true;
            label_municipio.Enabled = true;
            label_direccion.Enabled = true;
            label_departamento.Enabled = true;
        }

        private void barra1_click_nuevo_button()
        {

            text_nombre_cliente.Text = ""; ;
            text_nit.Text = "";
            text_direccion.Text = "";
            box_departamento.Text = "";
            box_municipio.Text = "";


            band_nuevo = true;
            band_edit = false;
            box_departamento.DataSource = db.consulta_ComboBox("select idtbm_departamentos, nombre from tbm_departamentos");
            box_departamento.DisplayMember = "nombre";
            box_departamento.ValueMember = "idtbm_departamentos";
            band = true;
            mostrar();
           
        }

        private void barra1_click_guardar_button()
        {
            if (band_nuevo)
            {

                if (text_nombre_cliente.Text != "" && text_nit.Text != "" && text_direccion.Text != "" && box_municipio.Text != "")
                {
                    string tabla = "tbm_cliente";
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("nombre_cliente", text_nombre_cliente.Text);
                    dict.Add("nit_cliente", text_nit.Text);
                    dict.Add("direccion_cliente", text_direccion.Text);
                    dict.Add("idtbm_municipio", box_municipio.SelectedValue.ToString());


                    db.insertar(tabla, dict);
                    MessageBox.Show("Agregado con Exito!");

                    consultar();

                    band_nuevo = false;
                    ocultar();
                }
                else
                    MessageBox.Show("Error - Hay campos sin llenar");
            }
            if (band_edit)
            {
                int rowIndex = grid_clientes.CurrentCell.RowIndex;
                int a = Convert.ToInt32(grid_clientes.Rows[rowIndex].Cells[0].Value);

                string tabla = "tbm_cliente";
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre_cliente", text_nombre_cliente.Text);
                dict.Add("nit_cliente", text_nit.Text);
                dict.Add("direccion_cliente", text_direccion.Text);
                dict.Add("idtbm_municipio", box_municipio.SelectedValue.ToString());

                db.actualizar(tabla, dict, "idtbm_cliente =" + a);
                MessageBox.Show("Modificado con Exito!");

                consultar();
                ocultar();
            }
            else
            {
                MessageBox.Show("No se puede guardar");
            }
        }

        private void box_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (band)
            {
                box_municipio.Enabled = true;
                box_municipio.DataSource = db.consulta_ComboBox("select idtbm_municipio, nombre from tbm_municipio where idtbm_departamentos = " + box_departamento.SelectedValue);
                box_municipio.DisplayMember = "nombre";
                box_municipio.ValueMember = "idtbm_municipio";
            }
        }

        private void barra1_click_editar_button()
        {
            if(cambio)
            {

                mostrar();
                box_departamento.DataSource = db.consulta_ComboBox("select idtbm_departamentos, nombre from tbm_departamentos");
                box_departamento.DisplayMember = "nombre";
                box_departamento.ValueMember = "idtbm_departamentos";
                band = true;

                band_edit = true;
            }
            
        }


        private void grid_clientes_SelectionChanged(object sender, EventArgs e)
        {
            cambio = true;

            if (band_nuevo)
            {
            }
      
            else
            {

                int rowIndex = grid_clientes.CurrentCell.RowIndex;
                //int a = Convert.ToInt32(grid_clientes.Rows[rowIndex].Cells[0].Value);

                text_direccion.Text = grid_clientes.Rows[rowIndex].Cells[3].Value.ToString();
                text_nit.Text = grid_clientes.Rows[rowIndex].Cells[2].Value.ToString();
                box_departamento.Text = grid_clientes.Rows[rowIndex].Cells[5].Value.ToString();
                text_nombre_cliente.Text = grid_clientes.Rows[rowIndex].Cells[1].Value.ToString();
                box_municipio.Text = grid_clientes.Rows[rowIndex].Cells[4].Value.ToString();
                ocultar();
            }
        }

        private void barra1_click_actualizar_button()
        {
            consultar();

            ocultar();

        }

        private void barra1_click_eliminar_button()
        {
            band_nuevo = false;
            band_edit = false;
            band_eliminar = true;
            
            int rowIndex = grid_clientes.CurrentCell.RowIndex;

            DialogResult dialogResult = MessageBox.Show("Seguro quieres eliminar?", "Eliminar Cliente", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = Convert.ToInt32(grid_clientes.Rows[rowIndex].Cells[0].Value);

                db.eliminar("tbm_cliente", "idtbm_cliente = " + a);

                consultar();

                ocultar();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            
            
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barra1_click_imprimir_button()
        {
            MessageBox.Show("NO HAY IMPRESORA CONECTADA");
        }
    }
}
