using QuestPDF.Infrastructure;
using System;
using System.Windows.Forms;
using YourProply.Entities;
using YourProply.Presenters;
using YourProply.Services;

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
            var apiKey = "sk-proj-l97TQGzYmQGSjGti1qpVT3BlbkFJwmst3yQbT91eL7xNNEUW";
            var openAIService = new OpenAIService(apiKey);
            var loginView = new Login();
            var loginPresenter = new LoginPresenter(loginView, context, openAIService);

            Application.Run(loginView);
        }
    }
}
