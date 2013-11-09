using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ODBCConnect;

namespace WindowsFormsApplication1
{
    class class_calculo_comision
    {
        private void consultar(int no_factura, int serie, int bodega, int id_vendedor)
        {
            string tipo_comision = ("select idtbm_tipo_comision from tbm_vendedor where idtbm_vendedor ="+ id_vendedor);
            
            if (tipo_comision == "1" )

            {
                string porcentaje = ("select procentaje_tipo_comision from tbm_tipo_comision where "+ tipo_comision +"= idtbm_tipo_comision");
                string total = ("select total from tbm_factura where serie_factura ="+ no_factura +" and no_factura ="+ no_factura +" and idtbm_bodega = " +bodega +"");
                
                int t = Convert.ToInt32(total);
                int p = Convert.ToInt32(porcentaje);
                int calc_comision= (t * p);
            }
        }
    }
}
