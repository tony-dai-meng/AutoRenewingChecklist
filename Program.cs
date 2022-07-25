using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRenewingChecklist
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static AutoChecklist ac;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ac = new AutoChecklist();
            Application.Run(ac);
        }

        //Autochecklist 
        public static AutoChecklist getAutoChecklist()
        {
            return ac;
        }
    }
}