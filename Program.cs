using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_k_WF
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var a = Path.GetDirectoryName(Application.ExecutablePath);
            string currentDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            if (!File.Exists($"{currentDirectory}\\databasefile.db"))
                new DB("Data Source=databasefile.db;Version=3; ").InitializeDatabase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm1());

           
        }
    }
}
