namespace YourProply
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LoginTxt = new TextBox();
            PasswordTxt = new TextBox();
            registerBtn = new Label();
            btnLogin = new Button();
            btnCloseApp = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 470);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(47, 43);
            label5.Name = "label5";
            label5.Size = new Size(185, 38);
            label5.TabIndex = 2;
            label5.Text = "LOGOWANIE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(12, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(387, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(587, 32);
            label1.TabIndex = 1;
            label1.Text = "Wprowadź swoje dane do logowania";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(450, 158);
            label2.Name = "label2";
            label2.Size = new Size(177, 23);
            label2.TabIndex = 2;
            label2.Text = "Nazwa użytkownika:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(568, 222);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 3;
            label3.Text = "Hasło:";
            // 
            // LoginTxt
            // 
            LoginTxt.BackColor = Color.FromArgb(15, 15, 15);
            LoginTxt.BorderStyle = BorderStyle.FixedSingle;
            LoginTxt.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginTxt.ForeColor = Color.White;
            LoginTxt.Location = new Point(633, 156);
            LoginTxt.Name = "LoginTxt";
            LoginTxt.Size = new Size(242, 30);
            LoginTxt.TabIndex = 4;
            // 
            // PasswordTxt
            // 
            PasswordTxt.BackColor = Color.FromArgb(15, 15, 15);
            PasswordTxt.BorderStyle = BorderStyle.FixedSingle;
            PasswordTxt.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTxt.ForeColor = Color.White;
            PasswordTxt.Location = new Point(633, 220);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.Size = new Size(242, 30);
            PasswordTxt.TabIndex = 5;
            // 
            // registerBtn
            // 
            registerBtn.AutoSize = true;
            registerBtn.BorderStyle = BorderStyle.FixedSingle;
            registerBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.CornflowerBlue;
            registerBtn.Location = new Point(570, 355);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(305, 22);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Nie masz konta? Kliknij, aby się zarejstrować";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.Location = new Point(450, 268);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(425, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Zaloguj";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnCloseApp
            // 
            btnCloseApp.BackColor = Color.CornflowerBlue;
            btnCloseApp.Location = new Point(914, 12);
            btnCloseApp.Name = "btnCloseApp";
            btnCloseApp.Size = new Size(108, 32);
            btnCloseApp.TabIndex = 8;
            btnCloseApp.Text = "Zamknij";
            btnCloseApp.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1034, 470);
            Controls.Add(btnCloseApp);
            Controls.Add(btnLogin);
            Controls.Add(registerBtn);
            Controls.Add(PasswordTxt);
            Controls.Add(LoginTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LoginTxt;
        private TextBox PasswordTxt;
        private Label registerBtn;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private Label label5;
        private Button btnCloseApp;
    }
}
