using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MyFirstGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arg)
        {
            ConMainForm cn;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            switch(arg.Length )
            {
                case 0: cn = new ConMainForm(); break;
                case 1: cn = new ConMainForm(Convert.ToInt32(arg[0], new System .Globalization .CultureInfo("En", true)));break;
                case 2: cn = new ConMainForm(Convert.ToInt32(arg[0], new System.Globalization.CultureInfo("En", true)), Convert.ToInt32(arg[1], new System.Globalization.CultureInfo("En", true))); break;
                case 3: cn = new ConMainForm(Convert.ToInt32(arg[0], new System.Globalization.CultureInfo("En", true)), Convert.ToInt32(arg[1], new System.Globalization.CultureInfo("En", true)), Convert.ToInt32(arg[2], new System.Globalization.CultureInfo("En", true))); break;
                case 4: cn = new ConMainForm(Convert.ToInt32(arg[0], new System.Globalization.CultureInfo("En", true)), Convert.ToInt32(arg[1], new System.Globalization.CultureInfo("En", true)), Convert.ToInt32(arg[2], new System.Globalization.CultureInfo("En", true)), Convert.ToInt32(arg[3], new System.Globalization.CultureInfo("En", true))); break;
                default: cn = new ConMainForm(); break;
            }
            Application.Run(cn);
        }
    }
}
