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
            ntnLogout = new Button();
            btnYourProperties = new Button();
            btnYourAccount = new Button();
            btnAddTenant = new Button();
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
            panel1.Size = new Size(312, 636);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(103, 99);
            label5.Name = "label5";
            label5.Size = new Size(101, 38);
            label5.TabIndex = 2;
            label5.Text = "MENU";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(12, 236);
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
            // ntnLogout
            // 
            ntnLogout.BackColor = Color.CornflowerBlue;
            ntnLogout.Location = new Point(957, 26);
            ntnLogout.Name = "ntnLogout";
            ntnLogout.Size = new Size(142, 36);
            ntnLogout.TabIndex = 7;
            ntnLogout.Text = "Wyloguj";
            ntnLogout.UseVisualStyleBackColor = false;
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
            // btnAddTenant
            // 
            btnAddTenant.BackColor = Color.CornflowerBlue;
            btnAddTenant.Location = new Point(636, 136);
            btnAddTenant.Name = "btnAddTenant";
            btnAddTenant.Size = new Size(149, 118);
            btnAddTenant.TabIndex = 10;
            btnAddTenant.Text = "Dodaj Najemce";
            btnAddTenant.UseVisualStyleBackColor = false;
            // 
            // LandlordMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1111, 636);
            Controls.Add(btnAddTenant);
            Controls.Add(btnYourAccount);
            Controls.Add(btnYourProperties);
            Controls.Add(ntnLogout);
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
        private Button ntnLogout;
        private Button btnYourProperties;
        private Button btnYourAccount;
        private Button btnAddTenant;
    }
}