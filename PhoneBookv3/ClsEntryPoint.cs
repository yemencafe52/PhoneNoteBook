namespace PhoneBookv3
{
    using DBIOLib;
    using PersonViewer;
    using System;
    using System.Windows.Forms;
    static class ClsEntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain(new PeopleViewController(new DBDS(Constants.ConnectionString))));
        }
    }
}
