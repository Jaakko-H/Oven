using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Subject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Oven());
        }

        /*public static void startPullObserver()
        {
            Application.Run(new PullObserver(oven));
        }

        public static void startPushObserver()
        {

        }*/
    }
}
