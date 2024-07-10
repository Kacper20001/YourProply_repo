namespace YourProply
{
    partial class ChangePasswordView
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
            label1 = new Label();
            label3 = new Label();
            txtConfirmNewPassword = new TextBox();
            btnSave = new Button();
            txtNewPassword = new TextBox();
            label2 = new Label();
            txtOldPassword = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(86, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(363, 32);
            label1.TabIndex = 1;
            label1.Text = "Wprowadź nowe dane";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(42, 227);
            label3.Name = "label3";
            label3.Size = new Size(191, 23);
            label3.TabIndex = 3;
            label3.Text = "Potwierdź nowe hasło:";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtConfirmNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmNewPassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmNewPassword.ForeColor = Color.White;
            txtConfirmNewPassword.Location = new Point(242, 225);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(242, 30);
            txtConfirmNewPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CornflowerBlue;
            btnSave.Location = new Point(378, 281);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Zmień";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.White;
            txtNewPassword.Location = new Point(242, 184);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(242, 30);
            txtNewPassword.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(126, 184);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 8;
            label2.Text = "Nowe hasło:";
            // 
            // txtOldPassword
            // 
            txtOldPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtOldPassword.BorderStyle = BorderStyle.FixedSingle;
            txtOldPassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOldPassword.ForeColor = Color.White;
            txtOldPassword.Location = new Point(242, 141);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(242, 30);
            txtOldPassword.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(131, 141);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 10;
            label4.Text = "Stare hasło:";
            // 
            // ChangePasswordView
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(523, 380);
            Controls.Add(txtOldPassword);
            Controls.Add(label4);
            Controls.Add(txtNewPassword);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChangePasswordView";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private TextBox LoginTxt;
        private TextBox PasswordTxt;
        private Label registerBtn;
        private PictureBox pictureBox1;
        private Button btnSave;
        private TextBox txtNewPassword;
        private Label label2;
        private TextBox txtOldPassword;
        private Label label4;
        private Label label5;
        private TextBox txtConfirmNewPassword;
    }
}