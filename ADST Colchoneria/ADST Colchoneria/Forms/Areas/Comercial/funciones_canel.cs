using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace ADST_Colchoneria
{
    class funciones_canel
    {

        public void llenado_informacion(DataGridView tabla,int no_compra,int id_bodega)
        {
            Dictionary<int ,int> d = new Dictionary<int,int>();
            foreach (DataGridViewRow fila in tabla.Rows)
            {
                int codigo =Convert.ToInt32(fila.Cells["idproducto"].Value.ToString());
                int cantidad=Convert.ToInt32(fila.Cells["CANTIDAD"].Value.ToString());
                if (d.ContainsKey(codigo))
                {
                    int value = d[codigo];
                    d[codigo] = value + cantidad;
                    Console.WriteLine(d[codigo]);
                  
               
                }
                else
                {
                    d.Add(codigo,cantidad);                    
                }
            }
            foreach (var info in d)
            {
                int id_producto = info.Key;
                int cant_producto = info.Value;
            }
        }   
        public String f2_sum_column(DataGridView dataGridView, String nombreColumna)
        {
            var formato = System.Globalization.CultureInfo.GetCultureInfo("es-GT");
            string retorno;
            double suma = 0;
            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                String info = Convert.ToString(fila.Cells[nombreColumna].Value.ToString());
                suma = double.Parse(info, formato) + suma;
            }
            retorno = string.Format(formato, "{0:0.0000}",suma);
            return retorno;
        }
        public String f1_sum_column(DataGridView dataGridView, String nombreColumna)
        {
            var formato = System.Globalization.CultureInfo.GetCultureInfo("es-GT");
            string retorno;
            double suma = 0;
            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                String info = Convert.ToString(fila.Cells[nombreColumna].Value.ToString());
                suma = Convert.ToDouble(info) + suma;
            }
            retorno = string.Format(formato, "{0:0.0000}", suma);
            return retorno;
        }

        public Double Double_conversion(String valor)
        {
            var formato = System.Globalization.CultureInfo.GetCultureInfo("es-GT");
            double nuevo = double.Parse(valor, formato);
            return nuevo;
        }
        public String String_conversion(Double valor)
        {
            var formato = System.Globalization.CultureInfo.GetCultureInfo("es-GT");
            String nuevo = string.Format(formato, "{0:0.0000}", valor);
            return nuevo;
        }

    public String multiplicacion(String cantidad,double valor)
    {
       var formato = System.Globalization.CultureInfo.GetCultureInfo("es-GT");
       double multiplicacion = double.Parse(cantidad, formato);
        String retorno = string.Format(formato, "{0:0.0000}",multiplicacion);
        Console.WriteLine(retorno);
        Console.WriteLine("..........");
        return retorno;
    }

        public void color_tabla(DataGridView datagridview)
        {
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
        }


        public int estado_insercion(Control panel)
        {
            int estado = 0; //no hay campos vacios

            foreach (Control caja in panel.Controls)
            {
                estado = 0;
                if (caja is TextBox)
                {
                    if (string.IsNullOrEmpty(caja.Text))
                    {
                        estado=1;
                        return 1;
                    }
                }
            }
            return estado;
        }

        public void activar_controles(Panel panel)
        {
            foreach (Control elemento in panel.Controls)
            {

                if (elemento is TextBox)
                {
                    elemento.Enabled = true;
                    elemento.Text = string.Empty;
                }
                
            }
        
        }


        public void desactivar_controles(Panel panel)
        {
            foreach (Control elemento in panel.Controls)
            {

                if (elemento is TextBox)
                {
                    elemento.Enabled = false;
                }
            }
        }

    }
}
