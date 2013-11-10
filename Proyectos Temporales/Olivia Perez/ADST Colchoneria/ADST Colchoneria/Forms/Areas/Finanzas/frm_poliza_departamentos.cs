using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;

namespace ADST_Colchoneria.Forms.Areas.Finanzas
{
    public partial class frm_poliza_departamentos : Form
    {
        public frm_poliza_departamentos()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("ADSTConnector");

        bool editar = false;
        string id;

        private void barra1_click_actualizar_button()
        {
            //1
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                datagvdepto.DataSource = db.consulta_DataGridView("select id_poliza as 'ID Poliza', nombre_cuenta as 'Nombre Departamento' from poliza_departamentos;");
                this.datagvdepto.Columns[0].Visible = false;
                

            }
            //2
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                datagvencabezado.DataSource = db.consulta_DataGridView("select id_encabezado as 'ID Encabezado', fecha as 'Fecha', concepto as 'Concepto', id_poliza as 'ID Poliza' from tbt_encabezado;");
                this.datagvencabezado.Columns[4].Visible = false;            
            }


            //3
            if (tabControl1.SelectedIndex.ToString() == "2")
            {
                datagvdetalle.DataSource = db.consulta_DataGridView("SELECT id_detalle as 'ID Detalle', total as 'Total', id_cts as 'ID Cuenta', id_poliza as 'ID Poliza', id_libro_diario as 'ID Libro Diario' FROM tbt_detalle;");
                this.datagvdetalle.Columns[0].Visible = false;
            }
        }

        private void barra1_click_nuevo_button()
        {
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                txtdepto.ReadOnly = false;
                txtdepto.Text = "";

            }
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                txtconcepto.ReadOnly = false;
                
                
                txtconcepto.Text = "";
                
               
            }

            if (tabControl1.SelectedIndex.ToString() == "2")
            {
                txttotal.ReadOnly = false;


                txttotal.Text = "";


            }
        }

        private void frm_poliza_departamentos_Load(object sender, EventArgs e)
        {
            // llena consulta de bancos
            datagvdepto.DataSource = db.consulta_DataGridView("select id_poliza as 'ID Poliza', nombre_cuenta as 'Nombre Departamento' from poliza_departamentos;");
            this.datagvdepto.Columns[0].Visible = false;

            // llena consulta de cuentas
            datagvencabezado.DataSource = db.consulta_DataGridView("select id_encabezado as 'ID Encabezado', fecha as 'Fecha', concepto as 'Concepto', id_poliza as 'ID Poliza' from tbt_encabezado;");
            this.datagvencabezado.Columns[0].Visible = false;
            this.datagvencabezado.Columns[3].Visible = false;


            // llena consulta 3
            datagvdetalle.DataSource = db.consulta_DataGridView("SELECT id_detalle as 'ID Detalle', total as 'Total', id_cts as 'ID Departamento', id_poliza as 'ID Poliza', id_libro_diario as 'ID Libro Diario' FROM tbt_detalle;");
            this.datagvdetalle.Columns[0].Visible = false;
            this.datagvdetalle.Columns[2].Visible = false;
            this.datagvdetalle.Columns[3].Visible = false;
            this.datagvdetalle.Columns[4].Visible = false;



            cmbfactura.DataSource = db.consulta_ComboBox("select idfactura, facturanombre from factura;");
            cmbfactura.DisplayMember = "facturanombre";
            cmbfactura.ValueMember = "idfactura";


        //    cmbpoliza.DataSource = db.consulta_ComboBox("select id_poliza, nombre_cuenta from Poliza_departamentos;");
          //  cmbpoliza.DisplayMember = "nombre_dpt";
            //cmbpoliza.ValueMember = "id_poliza";



            cmbcuenta.DataSource = db.consulta_ComboBox("select id_cts, nombre_cta from tbt_nomenclatura;");
            cmbcuenta.DisplayMember = "nombre_cta";
            cmbcuenta.ValueMember = "id_cts";



            cmbdiario.DataSource = db.consulta_ComboBox("select id_libro_diario, no_partida from tbt_libro_diario;");
            cmbdiario.DisplayMember = "no_partida";
            cmbdiario.ValueMember = "id_libro_diario";

            cmbdepto.DataSource = db.consulta_ComboBox("select id_poliza, nombre_cuenta from poliza_departamentos;");
            cmbdepto.DisplayMember = "nombre_cuenta";
            cmbdepto.ValueMember = "id_poliza";
        
        
        }

        int control = 0;


        private void barra1_click_guardar_button()

        {
            if (control == 0)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre_cuenta", txtdepto.Text);
                db.insertar("poliza_departamentos", dict);
                txtdepto.ReadOnly = true;
                textBox2 = txtdepto;
                
            }

            /*//manejo de bancos
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                if (txtdepto.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("nombre_dpt", txtdepto.Text);
                    dict.Add("factura_idfactura", cmbfactura.SelectedValue.ToString());

                    if (editar)
                    {
                        db.actualizar("Poliza_departamentos", dict, "id_poliza=" + id);
                        editar = false;

                    }
                    else
                    {

                        if (txtdepto.Text == "")
                        {
                            MessageBox.Show("Error debe llenar todos los campos");
                        }
                        else
                        {
                            string numero = this.datagvdepto.Rows.Count.ToString();
                            int i = Convert.ToInt32(numero);
                            string compara;
                            bool ingresa =true;

                            for (int x = 0; x < i; x++)
                            {
                                compara = datagvdepto.Rows[x].Cells[1].Value.ToString();
                                if (compara.Equals(txtdepto.Text))
                                {
                                    MessageBox.Show("El departamento ya esta ingresado" + txtdepto.Text + "    ya existe", "Error en ingreso de Departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtdepto.Text = "";
                                    ingresa = false;
                                }
                            }
                                if (ingresa)
                                {

                            db.insertar("Poliza_departamentos", dict);
                            txtdepto.Text = "";
                            txtdepto.ReadOnly = true;
                        }
                            }

                    }

                    datagvdepto.DataSource = db.consulta_DataGridView("select id_poliza as 'ID Poliza', nombre_cuenta as 'Nombre Cuenta' from poliza_departamentos;");

                }
                else
                {

                    MessageBox.Show("Debe precionar la opcion nuevo");
                }
                            }
            //manejo de cuentas
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                if (txtconcepto.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("fecha", datetpfecha.Value.Date.ToString("yyyy-MM-dd HH:mm"));
                    dict.Add("concepto", txtconcepto.Text);
                    dict.Add("id_poliza", cmbpoliza.SelectedValue.ToString());

                    if (editar)
                    {
                        db.actualizar("tbt_encabezado", dict, "id_encabezado=" + id);
                        editar = false;
                    }
                    else
                    {
                        if (txtconcepto.Text == "")
                        {
                            MessageBox.Show("Error debe llenar todos los campos");
                        }
                        else
                        {
                            db.insertar("tbt_encabezado", dict);
                            txtconcepto.Text = "";
                            txtconcepto.ReadOnly = true;
                            
                          
                           
                        }

                    }

                    datagvencabezado.DataSource = db.consulta_DataGridView("select id_encabezado as 'ID Encabezado', fecha as 'Fecha', concepto as 'Concepto', id_poliza as 'ID Poliza' from tbt_encabezado;");
                }
                else
                {
                    MessageBox.Show("Debe precionar la opcion nuevo");
                }


            }

            //insercion 3

            if (tabControl1.SelectedIndex.ToString() == "2")
            {
                if (txttotal.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("total", txttotal.Text);
                    dict.Add("id_cts", cmbcuenta.SelectedValue.ToString());
                    dict.Add("id_poliza", cmbdepto.SelectedValue.ToString());
                    dict.Add("id_libro_diario", cmbdiario.SelectedValue.ToString());

                    if (editar)
                    {
                        db.actualizar("tbt_detalle", dict, "id_detalle=" + id);
                        editar = false;
                    }
                    else
                    {
                        if (txttotal.Text == "")
                        {
                            MessageBox.Show("Error debe llenar todos los campos");
                        }
                        else
                        {
                            db.insertar("tbt_detalle", dict);
                            txttotal.Text = "";
                            txttotal.ReadOnly = true;



                        }

                    }

                    datagvdetalle.DataSource = db.consulta_DataGridView("SELECT id_detalle as 'ID Detalle', total as 'Total', id_cts as 'ID Cuenta', id_poliza as 'ID Poliza', id_libro_diario as 'ID Libro Diario' FROM tbt_detalle;");
                }
                else
                {
                    MessageBox.Show("Debe precionar la opcion nuevo");
                }


            }*/
        }

        private void barra1_click_editar_button()
        {
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                editar = true;
                txtdepto.ReadOnly = false;
                int i = datagvdepto.CurrentRow.Index;
                id = datagvdepto.Rows[i].Cells[0].Value.ToString();
                txtdepto.Text = datagvdepto.Rows[i].Cells[1].Value.ToString();

            }
            //manejo de cuentas bancarias
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                editar = true;
                txtconcepto.ReadOnly = false;
               
                int i = datagvencabezado.CurrentRow.Index;
                id = datagvencabezado.Rows[i].Cells[0].Value.ToString();
                txtconcepto.Text = datagvencabezado.Rows[i].Cells[1].Value.ToString();
               
            }
            //manejo de cuentas bancarias
            if (tabControl1.SelectedIndex.ToString() == "2")
            {
                editar = true;
                txttotal.ReadOnly = false;

                int i = datagvdetalle.CurrentRow.Index;
                id = datagvdetalle.Rows[i].Cells[0].Value.ToString();
                txttotal.Text = datagvdetalle.Rows[i].Cells[1].Value.ToString();

            }
        }

        private void barra1_click_eliminar_button()
        {
            //manejo de bancos
            if (tabControl1.SelectedIndex.ToString() == "0")
            {
                int i = datagvdepto.CurrentRow.Index;
                id = datagvdepto.Rows[i].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string condicion = "id_poliza=" + id;
                    db.eliminar("Poliza_departamentos", condicion);
                    datagvdepto.DataSource = db.consulta_DataGridView("select id_poliza as 'ID Poliza', nombre_cuenta as 'Nombre Cuenta' from poliza_departamentos;");
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            //manejo de cuentas bancarias
            if (tabControl1.SelectedIndex.ToString() == "1")
            {
                int i = datagvencabezado.CurrentRow.Index;
                id = datagvencabezado.Rows[i].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string condicion = "id_encabezado=" + id;
                    db.eliminar("tbt_encabezado", condicion);
                    datagvencabezado.DataSource = db.consulta_DataGridView("select id_encabezado as 'ID Encabezado', fecha as 'Fecha', concepto as 'Concepto', id_poliza as 'ID Poliza' from tbt_encabezado;");
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            //manejo de cuentas bancarias
            if (tabControl1.SelectedIndex.ToString() == "2")
            {
                int i = datagvdetalle.CurrentRow.Index;
                id = datagvdetalle.Rows[i].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string condicion = "id_detalle=" + id;
                    db.eliminar("tbt_detalle", condicion);
                    datagvdetalle.DataSource = db.consulta_DataGridView("SELECT id_detalle as 'ID Detalle', total as 'Total', id_cts as 'ID Cuenta', id_poliza as 'ID Poliza', id_libro_diario as 'ID Libro Diario' FROM tbt_detalle;");
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void barra1_click_buscar_button()
        {

            //manejo de bancos
            if (tabControl1.SelectedIndex.ToString() == "0")
            {

                if (txtdepto.Text == "")
                {
                    MessageBox.Show("Debe llenar el campo de busqueda", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {


                    string busca = txtdepto.Text;
                    datagvdepto.DataSource = db.consulta_DataGridView("SELECT * FROM Poliza_departamentos WHERE nombre_dpt LIKE '" + txtdepto.Text + "%'");
                    txtdepto.Text = "";
                    txtdepto.ReadOnly = true;


                }
                if (tabControl1.SelectedIndex.ToString() == "1")
                {
                    //string busca = cmbpoliza.SelectedValue.ToString();
                  //  datagvencabezado.DataSource = db.consulta_DataGridView("select *from tbt_encabezado where id_encabezado =" + busca + ";");

                }

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbfactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
