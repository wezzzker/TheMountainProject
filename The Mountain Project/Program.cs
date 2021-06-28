using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Mountain_Project
{
    class Mount
    {
        public string name { get; set; }
        public int hight { get; set; }
        public string sh { get; set; }
        public string dol { get; set; }
        public int god { get; set; }
        public string materik { get; set; }
        public string alp { get; set; }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Animation());
        }

    }
}
