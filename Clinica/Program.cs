using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using Clinica.Database;

namespace Clinica
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(
                ConnectionHelper.ConnectionString, AutoCreateOption.DatabaseAndSchema);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
        }
    }
}
