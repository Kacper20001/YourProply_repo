using YourProply.Views;

namespace YourProply
{
    public partial class Login : Form, ILoginView
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Click += (s, e) => LoginEvent?.Invoke(this, EventArgs.Empty);
        }
        public string UserName => LoginTxt.Text;
        public string Password => PasswordTxt.Text;

        public event EventHandler LoginEvent;
        public event EventHandler RegisterClick;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
