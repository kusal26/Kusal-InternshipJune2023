using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            //Application.Run(new Login());
            //Application.Run(new MovieForm());
            //  Application.Run(new Cart());
            Application.Run(new Welcome());
            // Application.Run(new AdminForm());
           //  Application.Run(new ViewForm());
           //  Application.Run(new LoadMovie());
             //Application.Run(new PImageList());


        }
    }
}
