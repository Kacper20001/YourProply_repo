using System;
using System.Threading.Tasks;
using YourProply.Entities;
using YourProply.Services;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class ChatbotPresenter
    {
        private readonly IChatbotView _view;
        private readonly OpenAIService _openAIService;
        private readonly User _loggedInUser;
        private readonly YourProplyDbContext _context;

        public ChatbotPresenter(IChatbotView view, OpenAIService openAIService, YourProplyDbContext context, User loggedInUser)
        {
            _view = view;
            _openAIService = openAIService;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.AskQuestionClick += OnAskQuestionClick;
            _view.BackToMenuClick += OnBackToMenuClick;
        }

        /// <summary>
        /// Metoda obsługująca zadawanie pytania przez użytkownika.
        /// </summary>
        private async void OnAskQuestionClick(object sender, EventArgs e)
        {
            try
            {
                var question = _view.Question;
                var answer = await _openAIService.AskQuestion(question);
                _view.SetAnswer(answer);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Błąd: {ex.Message}");
            }
        }

        /// <summary>
        /// Metoda obsługująca powrót do menu.
        /// </summary>
        private void OnBackToMenuClick(object sender, EventArgs e)
        {
            var landlordMenu = new LandlordMenu(_loggedInUser);
            var landlordMenuPresenter = new LandlordMenuPresenter(landlordMenu, _context, _loggedInUser, _openAIService);
            _view.Hide();
            landlordMenu.FormClosed += (s, args) => _view.Show();
            landlordMenu.Show();
        }
    }
}
