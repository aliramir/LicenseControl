using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LicenseControl.Views;
using DevExpress.LookAndFeel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LicenseControl
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.HighContrast, "High Contrast #1");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}