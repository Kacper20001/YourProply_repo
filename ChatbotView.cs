using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourProply.Views;

namespace YourProply
{
    public partial class ChatbotView : Form, IChatbotView
    {
        public ChatbotView()
        {
            InitializeComponent();
            btnAsk.Click += (s, e) => AskQuestionClick?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler AskQuestionClick;

        public string Question => txtQuestion.Text;

        public void SetAnswer(string answer)
        {
            txtAnswer.Text = answer;
        }

        public new void Show()
        {
            base.Show();
        }

        public new void Hide()
        {
            base.Hide();
        }
    }
}
