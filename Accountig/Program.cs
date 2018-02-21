using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Accountig
{
    static class Program
    {
        
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dire = Directory.GetCurrentDirectory();
            //dire = System.IO.Path.GetDirectoryName(dire);
            //dire = System.IO.Path.GetDirectoryName(dire);
            Console.WriteLine("This is local dir: "+dire);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
