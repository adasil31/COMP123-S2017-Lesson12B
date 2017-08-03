using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Alessandro Santos
 * Student Id: 300927354
 * Date: Augusto 03-2017
 * Description: Demo application windows form
 * version 0.1 - Project was created*/
namespace COMP123_S2017_Lesson12B
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
            Application.Run(new DemoForm());
        }
    }
}
