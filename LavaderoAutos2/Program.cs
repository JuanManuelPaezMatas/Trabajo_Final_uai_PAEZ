using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LavaderoAutos2.UI;

namespace LavaderoAutos2
{
    internal static class Program
    {
        /// <summary>
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCRUDVehicles());
        }
    }
}

