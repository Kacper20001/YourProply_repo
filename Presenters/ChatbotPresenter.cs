using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProply.Services;
using YourProply.Views;

namespace YourProply.Presenters
{
    public class ChatbotPresenter
    {
        private readonly IChatbotView _view;
        private readonly OpenAIService _openAIService;
        public ChatbotPresenter(IChatbotView view, OpenAIService openAIService)
        {
            _view = view;
            _openAIService = openAIService;
            _view.AskQuestionClick += OnAskQuestionClick;
        }

        private async void OnAskQuestionClick(object sender, EventArgs e)
        {
            var question = _view.Question;
            var answer = await _openAIService.AskQuestion(question);
            _view.SetAnswer(answer);
        }

    }
}
