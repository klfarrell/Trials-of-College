using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("My Dudes!");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Create the main form
            Form1 theform = new Form1();

            //Fix the window size
            theform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            theform.ClientSize = new System.Drawing.Size(1384, 790);
            theform.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            UI.Instance.SetForm(theform);
            UI.Instance.SetDisplayContext(new Menu());
            Application.Run(theform);
        }
    }
}
