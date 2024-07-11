using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Views
{
    public interface IChatbotView
    {
        event EventHandler AskQuestionClick;
        event EventHandler BackToMenuClick;

        string Question { get; }
        void SetAnswer(string answer);
        void Show();
        void Hide();
    }
}
