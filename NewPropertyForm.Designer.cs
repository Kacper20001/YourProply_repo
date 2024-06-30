namespace YourProply
{
    partial class NewPropertyForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtType = new TextBox();
            btnAddProperty = new Button();
            txtArea = new TextBox();
            txtRooms = new TextBox();
            label4 = new Label();
            label7 = new Label();
            txtStreet = new TextBox();
            txtAvailability = new TextBox();
            label9 = new Label();
            txtDescription = new TextBox();
            label10 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtNumber = new TextBox();
            label11 = new Label();
            txtState = new TextBox();
            label12 = new Label();
            txtProvince = new TextBox();
            txtCity = new TextBox();
            label13 = new Label();
            btnReturn = new Button();
            label8 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtPostalCode = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 763);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(38, 158);
            label6.Name = "label6";
            label6.Size = new Size(214, 33);
            label6.TabIndex = 3;
            label6.Text = "NIERUCHOMOŚCI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(68, 115);
            label5.Name = "label5";
            label5.Size = new Size(161, 33);
            label5.TabIndex = 2;
            label5.Text = "DODAWANIE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(12, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(385, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(623, 32);
            label1.TabIndex = 1;
            label1.Text = "Wprowadź dane nowej nieruchomości";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(512, 84);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 2;
            label2.Text = "Nazwa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(468, 262);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 3;
            label3.Text = "Dostępność:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(15, 15, 15);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(601, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 30);
            txtName.TabIndex = 4;
            // 
            // txtType
            // 
            txtType.BackColor = Color.FromArgb(15, 15, 15);
            txtType.BorderStyle = BorderStyle.FixedSingle;
            txtType.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtType.ForeColor = Color.White;
            txtType.Location = new Point(601, 127);
            txtType.Name = "txtType";
            txtType.Size = new Size(242, 30);
            txtType.TabIndex = 5;
            // 
            // btnAddProperty
            // 
            btnAddProperty.BackColor = Color.CornflowerBlue;
            btnAddProperty.Location = new Point(617, 695);
            btnAddProperty.Name = "btnAddProperty";
            btnAddProperty.Size = new Size(99, 46);
            btnAddProperty.TabIndex = 7;
            btnAddProperty.Text = "Dodaj";
            btnAddProperty.UseVisualStyleBackColor = false;
            btnAddProperty.Click += btnAddProperty_Click;
            // 
            // txtArea
            // 
            txtArea.BackColor = Color.FromArgb(15, 15, 15);
            txtArea.BorderStyle = BorderStyle.FixedSingle;
            txtArea.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArea.ForeColor = Color.White;
            txtArea.Location = new Point(601, 217);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(242, 30);
            txtArea.TabIndex = 11;
            // 
            // txtRooms
            // 
            txtRooms.BackColor = Color.FromArgb(15, 15, 15);
            txtRooms.BorderStyle = BorderStyle.FixedSingle;
            txtRooms.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRooms.ForeColor = Color.White;
            txtRooms.Location = new Point(601, 172);
            txtRooms.Name = "txtRooms";
            txtRooms.Size = new Size(242, 30);
            txtRooms.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(464, 217);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 9;
            label4.Text = "Powierzchnia:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(512, 127);
            label7.Name = "label7";
            label7.Size = new Size(69, 23);
            label7.TabIndex = 8;
            label7.Text = "Rodzaj:";
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(15, 15, 15);
            txtStreet.BorderStyle = BorderStyle.FixedSingle;
            txtStreet.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStreet.ForeColor = Color.White;
            txtStreet.Location = new Point(601, 307);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(242, 30);
            txtStreet.TabIndex = 15;
            // 
            // txtAvailability
            // 
            txtAvailability.BackColor = Color.FromArgb(15, 15, 15);
            txtAvailability.BorderStyle = BorderStyle.FixedSingle;
            txtAvailability.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAvailability.ForeColor = Color.White;
            txtAvailability.Location = new Point(601, 262);
            txtAvailability.Name = "txtAvailability";
            txtAvailability.Size = new Size(242, 30);
            txtAvailability.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.CornflowerBlue;
            label9.Location = new Point(464, 174);
            label9.Name = "label9";
            label9.Size = new Size(116, 23);
            label9.TabIndex = 12;
            label9.Text = "Liczba pokoi:";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(15, 15, 15);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(601, 579);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(242, 102);
            txtDescription.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.CornflowerBlue;
            label10.Location = new Point(525, 579);
            label10.Name = "label10";
            label10.Size = new Size(51, 23);
            label10.TabIndex = 16;
            label10.Text = "Opis:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtNumber
            // 
            txtNumber.BackColor = Color.FromArgb(15, 15, 15);
            txtNumber.BorderStyle = BorderStyle.FixedSingle;
            txtNumber.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumber.ForeColor = Color.White;
            txtNumber.Location = new Point(601, 347);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(242, 30);
            txtNumber.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.CornflowerBlue;
            label11.Location = new Point(417, 349);
            label11.Name = "label11";
            label11.Size = new Size(163, 23);
            label11.TabIndex = 19;
            label11.Text = "Numer mieszkania:";
            // 
            // txtState
            // 
            txtState.BackColor = Color.FromArgb(15, 15, 15);
            txtState.BorderStyle = BorderStyle.FixedSingle;
            txtState.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtState.ForeColor = Color.White;
            txtState.Location = new Point(601, 528);
            txtState.Name = "txtState";
            txtState.Size = new Size(242, 30);
            txtState.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.CornflowerBlue;
            label12.Location = new Point(536, 530);
            label12.Name = "label12";
            label12.Size = new Size(47, 23);
            label12.TabIndex = 25;
            label12.Text = "Kraj:";
            // 
            // txtProvince
            // 
            txtProvince.BackColor = Color.FromArgb(15, 15, 15);
            txtProvince.BorderStyle = BorderStyle.FixedSingle;
            txtProvince.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProvince.ForeColor = Color.White;
            txtProvince.Location = new Point(601, 484);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(242, 30);
            txtProvince.TabIndex = 24;
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.FromArgb(15, 15, 15);
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.ForeColor = Color.White;
            txtCity.Location = new Point(601, 392);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(242, 30);
            txtCity.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.CornflowerBlue;
            label13.Location = new Point(451, 484);
            label13.Name = "label13";
            label13.Size = new Size(130, 23);
            label13.TabIndex = 22;
            label13.Text = "Województwo:";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.CornflowerBlue;
            btnReturn.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(731, 695);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(99, 46);
            btnReturn.TabIndex = 27;
            btnReturn.Text = "Powrót";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.CornflowerBlue;
            label8.Location = new Point(522, 307);
            label8.Name = "label8";
            label8.Size = new Size(54, 23);
            label8.TabIndex = 28;
            label8.Text = "Ulica:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.CornflowerBlue;
            label14.Location = new Point(512, 392);
            label14.Name = "label14";
            label14.Size = new Size(69, 23);
            label14.TabIndex = 29;
            label14.Text = "Miasto:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.CornflowerBlue;
            label15.Location = new Point(454, 439);
            label15.Name = "label15";
            label15.Size = new Size(129, 23);
            label15.TabIndex = 31;
            label15.Text = "Kod pocztowy:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = Color.FromArgb(15, 15, 15);
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPostalCode.ForeColor = Color.White;
            txtPostalCode.Location = new Point(601, 437);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(242, 30);
            txtPostalCode.TabIndex = 30;
            // 
            // NewPropertyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1053, 763);
            Controls.Add(label15);
            Controls.Add(txtPostalCode);
            Controls.Add(label14);
            Controls.Add(label8);
            Controls.Add(btnReturn);
            Controls.Add(txtState);
            Controls.Add(label12);
            Controls.Add(txtProvince);
            Controls.Add(txtCity);
            Controls.Add(label13);
            Controls.Add(txtNumber);
            Controls.Add(label11);
            Controls.Add(txtDescription);
            Controls.Add(label10);
            Controls.Add(txtStreet);
            Controls.Add(txtAvailability);
            Controls.Add(label9);
            Controls.Add(txtArea);
            Controls.Add(txtRooms);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(btnAddProperty);
            Controls.Add(txtType);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "NewPropertyForm";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewPropertyForm";
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
        private TextBox txtName;
        private TextBox txtType;
        private PictureBox pictureBox1;
        private Button btnAddProperty;
        private Label label6;
        private Label label5;
        private TextBox txtArea;
        private TextBox txtRooms;
        private Label label4;
        private Label label7;
        private TextBox txtStreet;
        private TextBox txtAvailability;
        private Label label9;
        private TextBox txtDescription;
        private Label label10;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtNumber;
        private Label label11;
        private TextBox txtState;
        private Label label12;
        private TextBox txtProvince;
        private TextBox txtCity;
        private Label label13;
        private Button btnReturn;
        private Label label8;
        private Label label14;
        private Label label15;
        private TextBox txtPostalCode;
    }
}