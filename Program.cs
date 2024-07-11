using QuestPDF.Infrastructure;
using System;
using System.Windows.Forms;
using YourProply.Entities;
using YourProply.Presenters;

namespace YourProply
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var context = new YourProplyDbContext();
            var loginView = new Login();
            var loginPresenter = new LoginPresenter(loginView, context);

            Application.Run(loginView);
        }
    }
}
