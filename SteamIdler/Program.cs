using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steamworks;

namespace SteamIdler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Form1 form1;
        [STAThread]
        static void Main()
        {
            form1 = new Form1();
            Application.Run(form1);
        }
    }
}
