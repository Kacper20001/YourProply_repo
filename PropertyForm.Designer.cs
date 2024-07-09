namespace YourProply
{
    partial class PropertyForm
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
            txtPropertyName = new TextBox();
            txtPropertyDescription = new TextBox();
            btnSave = new Button();
            txtProvince = new TextBox();
            label14 = new Label();
            txtState = new TextBox();
            label17 = new Label();
            label16 = new Label();
            txtCity = new TextBox();
            label15 = new Label();
            txtPostalCode = new TextBox();
            label13 = new Label();
            txtStreet = new TextBox();
            label12 = new Label();
            txtHouseNumber = new TextBox();
            label4 = new Label();
            comboBoxAvailability = new ComboBox();
            txtRooms = new TextBox();
            label6 = new Label();
            txtArea = new TextBox();
            label7 = new Label();
            btnReturn = new Button();
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
            label5.Location = new Point(5, 76);
            label5.Name = "label5";
            label5.Size = new Size(307, 38);
            label5.TabIndex = 1;
            label5.Text = "Edytuj nieruchomosci ";
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
            label1.Location = new Point(394, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(520, 32);
            label1.TabIndex = 1;
            label1.Text = "Wprowadź dane nieruchomości";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(436, 110);
            label2.Name = "label2";
            label2.Size = new Size(191, 23);
            label2.TabIndex = 2;
            label2.Text = "Nazwa nieruchomości:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(576, 146);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 3;
            label3.Text = "Opis:";
            // 
            // txtPropertyName
            // 
            txtPropertyName.BackColor = Color.FromArgb(15, 15, 15);
            txtPropertyName.BorderStyle = BorderStyle.FixedSingle;
            txtPropertyName.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPropertyName.ForeColor = Color.White;
            txtPropertyName.Location = new Point(633, 108);
            txtPropertyName.Name = "txtPropertyName";
            txtPropertyName.Size = new Size(242, 30);
            txtPropertyName.TabIndex = 4;
            // 
            // txtPropertyDescription
            // 
            txtPropertyDescription.BackColor = Color.FromArgb(15, 15, 15);
            txtPropertyDescription.BorderStyle = BorderStyle.FixedSingle;
            txtPropertyDescription.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPropertyDescription.ForeColor = Color.White;
            txtPropertyDescription.Location = new Point(633, 146);
            txtPropertyDescription.Multiline = true;
            txtPropertyDescription.Name = "txtPropertyDescription";
            txtPropertyDescription.Size = new Size(242, 109);
            txtPropertyDescription.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CornflowerBlue;
            btnSave.Location = new Point(450, 622);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(425, 45);
            btnSave.TabIndex = 7;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtProvince
            // 
            txtProvince.BackColor = Color.FromArgb(15, 15, 15);
            txtProvince.BorderStyle = BorderStyle.FixedSingle;
            txtProvince.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProvince.ForeColor = Color.White;
            txtProvince.Location = new Point(633, 408);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(242, 30);
            txtProvince.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.CornflowerBlue;
            label14.Location = new Point(497, 410);
            label14.Name = "label14";
            label14.Size = new Size(130, 23);
            label14.TabIndex = 23;
            label14.Text = "Województwo:";
            // 
            // txtState
            // 
            txtState.BackColor = Color.FromArgb(15, 15, 15);
            txtState.BorderStyle = BorderStyle.FixedSingle;
            txtState.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtState.ForeColor = Color.White;
            txtState.Location = new Point(633, 444);
            txtState.Name = "txtState";
            txtState.Size = new Size(242, 30);
            txtState.TabIndex = 31;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.CornflowerBlue;
            label17.Location = new Point(580, 446);
            label17.Name = "label17";
            label17.Size = new Size(47, 23);
            label17.TabIndex = 30;
            label17.Text = "Kraj:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.CornflowerBlue;
            label16.Location = new Point(558, 338);
            label16.Name = "label16";
            label16.Size = new Size(69, 23);
            label16.TabIndex = 20;
            label16.Text = "Miasto:";
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.FromArgb(15, 15, 15);
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.ForeColor = Color.White;
            txtCity.Location = new Point(633, 336);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(242, 30);
            txtCity.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.CornflowerBlue;
            label15.Location = new Point(498, 374);
            label15.Name = "label15";
            label15.Size = new Size(129, 23);
            label15.TabIndex = 22;
            label15.Text = "Kod pocztowy:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = Color.FromArgb(15, 15, 15);
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPostalCode.ForeColor = Color.White;
            txtPostalCode.Location = new Point(633, 372);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(242, 30);
            txtPostalCode.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.CornflowerBlue;
            label13.Location = new Point(573, 264);
            label13.Name = "label13";
            label13.Size = new Size(54, 23);
            label13.TabIndex = 26;
            label13.Text = "Ulica:";
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(15, 15, 15);
            txtStreet.BorderStyle = BorderStyle.FixedSingle;
            txtStreet.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStreet.ForeColor = Color.White;
            txtStreet.Location = new Point(633, 264);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(242, 30);
            txtStreet.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.CornflowerBlue;
            label12.Location = new Point(464, 300);
            label12.Name = "label12";
            label12.Size = new Size(163, 23);
            label12.TabIndex = 28;
            label12.Text = "Numer mieszkania:";
            // 
            // txtHouseNumber
            // 
            txtHouseNumber.BackColor = Color.FromArgb(15, 15, 15);
            txtHouseNumber.BorderStyle = BorderStyle.FixedSingle;
            txtHouseNumber.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHouseNumber.ForeColor = Color.White;
            txtHouseNumber.Location = new Point(633, 300);
            txtHouseNumber.Name = "txtHouseNumber";
            txtHouseNumber.Size = new Size(242, 30);
            txtHouseNumber.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(514, 486);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 32;
            label4.Text = "Dostępność:";
            // 
            // comboBoxAvailability
            // 
            comboBoxAvailability.BackColor = Color.FromArgb(15, 15, 15);
            comboBoxAvailability.FlatStyle = FlatStyle.Popup;
            comboBoxAvailability.ForeColor = Color.White;
            comboBoxAvailability.FormattingEnabled = true;
            comboBoxAvailability.Location = new Point(633, 483);
            comboBoxAvailability.Name = "comboBoxAvailability";
            comboBoxAvailability.Size = new Size(242, 31);
            comboBoxAvailability.TabIndex = 33;
            // 
            // txtRooms
            // 
            txtRooms.BackColor = Color.FromArgb(15, 15, 15);
            txtRooms.BorderStyle = BorderStyle.FixedSingle;
            txtRooms.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRooms.ForeColor = Color.White;
            txtRooms.Location = new Point(633, 562);
            txtRooms.Name = "txtRooms";
            txtRooms.Size = new Size(242, 30);
            txtRooms.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(511, 562);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 36;
            label6.Text = "Liczba pokoi:";
            // 
            // txtArea
            // 
            txtArea.BackColor = Color.FromArgb(15, 15, 15);
            txtArea.BorderStyle = BorderStyle.FixedSingle;
            txtArea.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArea.ForeColor = Color.White;
            txtArea.Location = new Point(633, 526);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(242, 30);
            txtArea.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(463, 528);
            label7.Name = "label7";
            label7.Size = new Size(169, 23);
            label7.TabIndex = 34;
            label7.Text = "Powierzchnia w m2:";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.CornflowerBlue;
            btnReturn.Location = new Point(935, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(87, 38);
            btnReturn.TabIndex = 38;
            btnReturn.Text = "Powrót";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // PropertyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1034, 708);
            Controls.Add(btnReturn);
            Controls.Add(txtRooms);
            Controls.Add(label6);
            Controls.Add(txtArea);
            Controls.Add(label7);
            Controls.Add(comboBoxAvailability);
            Controls.Add(label4);
            Controls.Add(txtState);
            Controls.Add(label17);
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
            Controls.Add(btnSave);
            Controls.Add(txtPropertyDescription);
            Controls.Add(txtPropertyName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PropertyForm";
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
        private TextBox txtPropertyName;
        private TextBox txtPropertyDescription;
        private PictureBox pictureBox1;
        private Button btnSave;
        private Label label5;
        private TextBox txtProvince;
        private Label label14;
        private TextBox txtState;
        private Label label17;
        private Label label16;
        private TextBox txtCity;
        private Label label15;
        private TextBox txtPostalCode;
        private Label label13;
        private TextBox txtStreet;
        private Label label12;
        private TextBox txtHouseNumber;
        private Label label4;
        private ComboBox comboBoxAvailability;
        private TextBox txtRooms;
        private Label label6;
        private TextBox txtArea;
        private Label label7;
        private Button btnReturn;
    }
}