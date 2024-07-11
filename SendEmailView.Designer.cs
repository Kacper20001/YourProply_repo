namespace YourProply
{
    partial class SendEmailView
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
            txtSubject = new TextBox();
            txtBody = new TextBox();
            btnSendEmail = new Button();
            label4 = new Label();
            cmbTenants = new ComboBox();
            btnBack = new Button();
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
            panel1.Size = new Size(312, 532);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(47, 43);
            label5.Name = "label5";
            label5.Size = new Size(197, 38);
            label5.TabIndex = 2;
            label5.Text = "WIADOMOSC";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(12, 148);
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
            label1.Location = new Point(567, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 32);
            label1.TabIndex = 1;
            label1.Text = "Utwórz wiadomość";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(334, 134);
            label2.Name = "label2";
            label2.Size = new Size(177, 23);
            label2.TabIndex = 2;
            label2.Text = "Nazwa użytkownika:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(442, 180);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 3;
            label3.Text = "Temat:";
            // 
            // txtSubject
            // 
            txtSubject.BackColor = Color.FromArgb(15, 15, 15);
            txtSubject.BorderStyle = BorderStyle.FixedSingle;
            txtSubject.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubject.ForeColor = Color.White;
            txtSubject.Location = new Point(546, 180);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(450, 30);
            txtSubject.TabIndex = 4;
            // 
            // txtBody
            // 
            txtBody.BackColor = Color.FromArgb(15, 15, 15);
            txtBody.BorderStyle = BorderStyle.FixedSingle;
            txtBody.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBody.ForeColor = Color.White;
            txtBody.Location = new Point(446, 242);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(550, 238);
            txtBody.TabIndex = 5;
            // 
            // btnSendEmail
            // 
            btnSendEmail.BackColor = Color.CornflowerBlue;
            btnSendEmail.Location = new Point(839, 486);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new Size(157, 30);
            btnSendEmail.TabIndex = 7;
            btnSendEmail.Text = "Wyślij";
            btnSendEmail.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(446, 216);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 9;
            label4.Text = "Treść:";
            // 
            // cmbTenants
            // 
            cmbTenants.BackColor = Color.FromArgb(15, 15, 15);
            cmbTenants.FlatStyle = FlatStyle.Popup;
            cmbTenants.ForeColor = Color.White;
            cmbTenants.FormattingEnabled = true;
            cmbTenants.Items.AddRange(new object[] { "true", "false" });
            cmbTenants.Location = new Point(546, 131);
            cmbTenants.Name = "cmbTenants";
            cmbTenants.Size = new Size(450, 31);
            cmbTenants.TabIndex = 34;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Location = new Point(932, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(108, 39);
            btnBack.TabIndex = 35;
            btnBack.Text = "Wróć";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // SendEmailView
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1071, 532);
            Controls.Add(btnBack);
            Controls.Add(cmbTenants);
            Controls.Add(label4);
            Controls.Add(btnSendEmail);
            Controls.Add(txtBody);
            Controls.Add(txtSubject);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SendEmailView";
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
        private TextBox txtSubject;
        private TextBox txtBody;
        private PictureBox pictureBox1;
        private Button btnSendEmail;
        private Label label5;
        private Label label4;
        private ComboBox cmbTenants;
        private Button btnBack;
    }
}