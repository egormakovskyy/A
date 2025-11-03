using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQLApp
{
    public static class Data
    {
        public static int pass = 1111;
        public static int TotalFloors { get; set; }
        public static List<HumanData> Humans { get; set; } = new List<HumanData>();
        public static int people_created { get; set; } = 0;
    }
    public class HumanData
    {
        public int TargetFloor { get; set; }
        public int Weight { get; set; }
    }
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome_menu());
        }
    }
}
