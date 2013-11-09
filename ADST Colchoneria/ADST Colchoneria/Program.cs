using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ADST_Colchoneria.Forms.Areas.Finanzas;
namespace ADST_Colchoneria
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new frm_login());
            Application.Run(new frm_login());
        }
    }
}
