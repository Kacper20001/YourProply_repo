using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            _view.AskQuestionClick += OnAskQuestionClick;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.BackToMenuClick += OnBackToMenuClick;

        }

        private async void OnAskQuestionClick(object sender, EventArgs e)
        {
            var question = _view.Question;
            var answer = await _openAIService.AskQuestion(question);
            _view.SetAnswer(answer);

        }
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
