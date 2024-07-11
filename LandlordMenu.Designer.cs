namespace YourProply
{
    partial class LandlordMenu
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
            btnLogout = new Button();
            btnYourProperties = new Button();
            btnYourAccount = new Button();
            btnManageUsers = new Button();
            btnGenerateLeaseAgreement = new Button();
            btnSendEmail = new Button();
            btnChatAI = new Button();
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
            panel1.Size = new Size(312, 484);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(109, 53);
            label5.Name = "label5";
            label5.Size = new Size(101, 38);
            label5.TabIndex = 2;
            label5.Text = "MENU";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(12, 159);
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
            label1.Location = new Point(626, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 1;
            label1.Text = "Wybierz";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.CornflowerBlue;
            btnLogout.Location = new Point(957, 26);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 36);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Wyloguj";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += ntnLogout_Click;
            // 
            // btnYourProperties
            // 
            btnYourProperties.BackColor = Color.CornflowerBlue;
            btnYourProperties.Location = new Point(411, 136);
            btnYourProperties.Name = "btnYourProperties";
            btnYourProperties.Size = new Size(149, 118);
            btnYourProperties.TabIndex = 8;
            btnYourProperties.Text = "Twoje nieruchomości";
            btnYourProperties.UseVisualStyleBackColor = false;
            // 
            // btnYourAccount
            // 
            btnYourAccount.BackColor = Color.CornflowerBlue;
            btnYourAccount.Location = new Point(861, 136);
            btnYourAccount.Name = "btnYourAccount";
            btnYourAccount.Size = new Size(149, 118);
            btnYourAccount.TabIndex = 9;
            btnYourAccount.Text = "Panel użytkownika";
            btnYourAccount.UseVisualStyleBackColor = false;
            // 
            // btnManageUsers
            // 
            btnManageUsers.BackColor = Color.CornflowerBlue;
            btnManageUsers.Location = new Point(636, 136);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(149, 118);
            btnManageUsers.TabIndex = 10;
            btnManageUsers.Text = "Twoi najemcy";
            btnManageUsers.UseVisualStyleBackColor = false;
            // 
            // btnGenerateLeaseAgreement
            // 
            btnGenerateLeaseAgreement.BackColor = Color.CornflowerBlue;
            btnGenerateLeaseAgreement.Location = new Point(411, 291);
            btnGenerateLeaseAgreement.Name = "btnGenerateLeaseAgreement";
            btnGenerateLeaseAgreement.Size = new Size(149, 118);
            btnGenerateLeaseAgreement.TabIndex = 11;
            btnGenerateLeaseAgreement.Text = "Generuj umowe";
            btnGenerateLeaseAgreement.UseVisualStyleBackColor = false;
            btnGenerateLeaseAgreement.Click += btnGenerateLeaseAgreement_Click;
            // 
            // btnSendEmail
            // 
            btnSendEmail.BackColor = Color.CornflowerBlue;
            btnSendEmail.Location = new Point(636, 291);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new Size(149, 118);
            btnSendEmail.TabIndex = 12;
            btnSendEmail.Text = "Wyślij email";
            btnSendEmail.UseVisualStyleBackColor = false;
            // 
            // btnChatAI
            // 
            btnChatAI.BackColor = Color.CornflowerBlue;
            btnChatAI.Location = new Point(861, 291);
            btnChatAI.Name = "btnChatAI";
            btnChatAI.Size = new Size(149, 118);
            btnChatAI.TabIndex = 13;
            btnChatAI.Text = "Wirtualny asystent";
            btnChatAI.UseVisualStyleBackColor = false;
            // 
            // LandlordMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1121, 484);
            Controls.Add(btnChatAI);
            Controls.Add(btnSendEmail);
            Controls.Add(btnGenerateLeaseAgreement);
            Controls.Add(btnManageUsers);
            Controls.Add(btnYourAccount);
            Controls.Add(btnYourProperties);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LandlordMenu";
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
        private PictureBox pictureBox1;
        private Label label5;
        private Button btnLogout;
        private Button btnYourProperties;
        private Button btnYourAccount;
        private Button btnManageUsers;
        private Button btnGenerateLeaseAgreement;
        private Button btnSendEmail;
        private Button btnChatAI;
    }
}