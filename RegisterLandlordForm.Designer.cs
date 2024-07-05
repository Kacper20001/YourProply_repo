using System.Windows.Forms;

namespace YourProply
{
    partial class RegisterLandlordForm
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
            txtUserName = new TextBox();
            txtFirstName = new TextBox();
            LoginBtn = new Label();
            btnRegister = new Button();
            txtLastName = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtIdNumber = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtHouseNumber = new TextBox();
            label12 = new Label();
            txtStreet = new TextBox();
            label13 = new Label();
            txtProvince = new TextBox();
            txtPostalCode = new TextBox();
            label14 = new Label();
            label15 = new Label();
            txtCity = new TextBox();
            label16 = new Label();
            txtState = new TextBox();
            label17 = new Label();
            dtpBirthDate = new DateTimePicker();
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
            panel1.Size = new Size(312, 708);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(56, 119);
            label5.Name = "label5";
            label5.Size = new Size(196, 38);
            label5.TabIndex = 1;
            label5.Text = "REJESTRACJA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(12, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(358, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(637, 32);
            label1.TabIndex = 1;
            label1.Text = "Wprowadź dane, aby się zarejestrować";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(448, 78);
            label2.Name = "label2";
            label2.Size = new Size(177, 23);
            label2.TabIndex = 2;
            label2.Text = "Nazwa użytkownika:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(574, 114);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 3;
            label3.Text = "Imię:";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(15, 15, 15);
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(631, 76);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(242, 30);
            txtUserName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(15, 15, 15);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.ForeColor = Color.White;
            txtFirstName.Location = new Point(631, 112);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(242, 30);
            txtFirstName.TabIndex = 5;
            // 
            // LoginBtn
            // 
            LoginBtn.AutoSize = true;
            LoginBtn.BorderStyle = BorderStyle.FixedSingle;
            LoginBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.CornflowerBlue;
            LoginBtn.Location = new Point(448, 662);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(195, 22);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Masz już konto? Zaloguj się";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.CornflowerBlue;
            btnRegister.Location = new Point(448, 601);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(425, 45);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Zarejestruj";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(15, 15, 15);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = Color.White;
            txtLastName.Location = new Point(631, 148);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(242, 30);
            txtLastName.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(534, 150);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 8;
            label6.Text = "Nazwisko:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(15, 15, 15);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(631, 255);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 30);
            txtEmail.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(566, 257);
            label7.Name = "label7";
            label7.Size = new Size(59, 23);
            label7.TabIndex = 10;
            label7.Text = "Email:";
            // 
            // txtIdNumber
            // 
            txtIdNumber.BackColor = Color.FromArgb(15, 15, 15);
            txtIdNumber.BorderStyle = BorderStyle.FixedSingle;
            txtIdNumber.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdNumber.ForeColor = Color.White;
            txtIdNumber.Location = new Point(631, 219);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(242, 30);
            txtIdNumber.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.CornflowerBlue;
            label8.Location = new Point(392, 221);
            label8.Name = "label8";
            label8.Size = new Size(233, 23);
            label8.TabIndex = 18;
            label8.Text = "Numer dowodu osobistego:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.CornflowerBlue;
            label9.Location = new Point(488, 185);
            label9.Name = "label9";
            label9.Size = new Size(137, 23);
            label9.TabIndex = 16;
            label9.Text = "Data urodzenia:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.White;
            txtConfirmPassword.Location = new Point(631, 327);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(242, 30);
            txtConfirmPassword.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(631, 291);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(242, 30);
            txtPassword.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.CornflowerBlue;
            label10.Location = new Point(479, 334);
            label10.Name = "label10";
            label10.Size = new Size(146, 23);
            label10.TabIndex = 13;
            label10.Text = "Potwierdź Hasło:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.CornflowerBlue;
            label11.Location = new Point(566, 298);
            label11.Name = "label11";
            label11.Size = new Size(59, 23);
            label11.TabIndex = 12;
            label11.Text = "Hasło:";
            // 
            // txtHouseNumber
            // 
            txtHouseNumber.BackColor = Color.FromArgb(15, 15, 15);
            txtHouseNumber.BorderStyle = BorderStyle.FixedSingle;
            txtHouseNumber.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHouseNumber.ForeColor = Color.White;
            txtHouseNumber.Location = new Point(631, 399);
            txtHouseNumber.Name = "txtHouseNumber";
            txtHouseNumber.Size = new Size(242, 30);
            txtHouseNumber.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.CornflowerBlue;
            label12.Location = new Point(462, 401);
            label12.Name = "label12";
            label12.Size = new Size(163, 23);
            label12.TabIndex = 28;
            label12.Text = "Numer mieszkania:";
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(15, 15, 15);
            txtStreet.BorderStyle = BorderStyle.FixedSingle;
            txtStreet.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStreet.ForeColor = Color.White;
            txtStreet.Location = new Point(631, 363);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(242, 30);
            txtStreet.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.CornflowerBlue;
            label13.Location = new Point(571, 370);
            label13.Name = "label13";
            label13.Size = new Size(54, 23);
            label13.TabIndex = 26;
            label13.Text = "Ulica:";
            // 
            // txtProvince
            // 
            txtProvince.BackColor = Color.FromArgb(15, 15, 15);
            txtProvince.BorderStyle = BorderStyle.FixedSingle;
            txtProvince.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProvince.ForeColor = Color.White;
            txtProvince.Location = new Point(631, 507);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(242, 30);
            txtProvince.TabIndex = 25;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = Color.FromArgb(15, 15, 15);
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPostalCode.ForeColor = Color.White;
            txtPostalCode.Location = new Point(631, 471);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(242, 30);
            txtPostalCode.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.CornflowerBlue;
            label14.Location = new Point(496, 509);
            label14.Name = "label14";
            label14.Size = new Size(130, 23);
            label14.TabIndex = 23;
            label14.Text = "Województwo:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.CornflowerBlue;
            label15.Location = new Point(496, 471);
            label15.Name = "label15";
            label15.Size = new Size(129, 23);
            label15.TabIndex = 22;
            label15.Text = "Kod pocztowy:";
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.FromArgb(15, 15, 15);
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.ForeColor = Color.White;
            txtCity.Location = new Point(631, 435);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(242, 30);
            txtCity.TabIndex = 21;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.CornflowerBlue;
            label16.Location = new Point(556, 437);
            label16.Name = "label16";
            label16.Size = new Size(69, 23);
            label16.TabIndex = 20;
            label16.Text = "Miasto:";
            // 
            // txtState
            // 
            txtState.BackColor = Color.FromArgb(15, 15, 15);
            txtState.BorderStyle = BorderStyle.FixedSingle;
            txtState.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtState.ForeColor = Color.White;
            txtState.Location = new Point(631, 543);
            txtState.Name = "txtState";
            txtState.Size = new Size(242, 30);
            txtState.TabIndex = 31;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.CornflowerBlue;
            label17.Location = new Point(578, 545);
            label17.Name = "label17";
            label17.Size = new Size(47, 23);
            label17.TabIndex = 30;
            label17.Text = "Kraj:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CalendarForeColor = Color.White;
            dtpBirthDate.CalendarMonthBackground = Color.Black;
            dtpBirthDate.CalendarTitleBackColor = Color.AntiqueWhite;
            dtpBirthDate.CalendarTitleForeColor = Color.White;
            dtpBirthDate.CalendarTrailingForeColor = Color.Green;
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(631, 183);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(242, 30);
            dtpBirthDate.TabIndex = 32;
            // 
            // RegisterLandlordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1034, 708);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtState);
            Controls.Add(label17);
            Controls.Add(LoginBtn);
            Controls.Add(txtHouseNumber);
            Controls.Add(label12);
            Controls.Add(txtStreet);
            Controls.Add(label13);
            Controls.Add(txtProvince);
            Controls.Add(txtPostalCode);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(txtCity);
            Controls.Add(label16);
            Controls.Add(txtIdNumber);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtLastName);
            Controls.Add(label6);
            Controls.Add(btnRegister);
            Controls.Add(txtFirstName);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegisterLandlordForm";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterLandlordForm";
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
        private TextBox txtUserName;
        private TextBox txtFirstName;
        private Label LoginBtn;
        private PictureBox pictureBox1;
        private Button btnRegister;
        private Label label5;
        private TextBox txtLastName;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtIdNumber;
        private Label label8;
        private Label label9;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private Label label10;
        private Label label11;
        private TextBox txtHouseNumber;
        private Label label12;
        private TextBox txtStreet;
        private Label label13;
        private TextBox txtProvince;
        private TextBox txtPostalCode;
        private Label label14;
        private Label label15;
        private TextBox txtCity;
        private Label label16;
        private TextBox txtState;
        private Label label17;
        private DateTimePicker dtpBirthDate;
    }
}