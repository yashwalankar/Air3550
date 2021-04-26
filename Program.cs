using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air3550
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);

             Application.Run(new Login());*/

            flight fl = FormDatabaseHelper.getFlight_fromFlightsTable(150);

           Console.WriteLine( FormDatabaseHelper.uploadFlight_bookedFlightsTable(fl));
           
            
        }
    }
}
