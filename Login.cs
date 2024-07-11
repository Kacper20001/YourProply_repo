using YourProply.Views;

namespace YourProply
{
    public partial class Login : Form, ILoginView
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Click += (s, e) => LoginEvent?.Invoke(this, EventArgs.Empty);
            registerBtn.Click += (s, e) => RegisterClick?.Invoke(this, EventArgs.Empty);
            btnCloseApp.Click += (s, e) => CloseAppClick?.Invoke(this, EventArgs.Empty); 

        }
        public string UserName => LoginTxt.Text;
        public string Password => PasswordTxt.Text;

        public event EventHandler LoginEvent;
        public event EventHandler RegisterClick;
        public event EventHandler CloseAppClick; 

        public new void Show()
        {
            base.Show();
        }

        public new void Hide()
        {
            base.Hide();
        }
        public new void Close()
        {
            base.Close();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
