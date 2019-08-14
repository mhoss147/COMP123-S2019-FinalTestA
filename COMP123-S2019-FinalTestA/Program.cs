using COMP123_S2019_FinalTestA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name: Mohammad S Hossain
 * Student ID: 300763479
 * Description: This is the program class for the application
 */
namespace COMP123_S2019_FinalTestA
{
    static class Program
    {
        public static AboutForm aboutForm;
        public static SplashForm splashForm;
        public static HeroGenerator heroGenerator;

        public static object HeroGenerator { get; internal set; }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            aboutForm = new AboutForm();
            splashForm = new SplashForm();
            heroGenerator = new HeroGenerator();

            Application.Run(splashForm);
        }
    }
}
// SplashForm created
//