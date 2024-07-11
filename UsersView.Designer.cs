namespace YourProply
{
    partial class UsersView
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
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridUsers = new DataGridView();
            btnBack = new Button();
            txtFilter = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(btnEditUser);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 588);
            panel1.TabIndex = 0;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.CornflowerBlue;
            btnDeleteUser.Location = new Point(39, 210);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(227, 40);
            btnDeleteUser.TabIndex = 11;
            btnDeleteUser.Text = "Usuń";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.CornflowerBlue;
            btnEditUser.Location = new Point(39, 152);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(227, 40);
            btnEditUser.TabIndex = 10;
            btnEditUser.Text = "Edytuj";
            btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.CornflowerBlue;
            btnAddUser.Location = new Point(39, 96);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(227, 40);
            btnAddUser.TabIndex = 9;
            btnAddUser.Text = "Dodaj";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(81, 29);
            label5.Name = "label5";
            label5.Size = new Size(148, 38);
            label5.TabIndex = 2;
            label5.Text = "NAJEMCY";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(12, 278);
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
            label1.Location = new Point(654, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 1;
            label1.Text = "Twoi najemcy";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridUsers
            // 
            dataGridUsers.BackgroundColor = Color.Black;
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.Location = new Point(385, 170);
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.RowHeadersWidth = 51;
            dataGridUsers.Size = new Size(773, 379);
            dataGridUsers.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Location = new Point(1121, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 38);
            btnBack.TabIndex = 13;
            btnBack.Text = "Powrót";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // txtFilter
            // 
            txtFilter.BackColor = Color.FromArgb(15, 15, 15);
            txtFilter.BorderStyle = BorderStyle.FixedSingle;
            txtFilter.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilter.ForeColor = Color.White;
            txtFilter.Location = new Point(496, 106);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(197, 30);
            txtFilter.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(399, 108);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 15;
            label3.Text = "Wyszukaj:";
            // 
            // UsersView
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1244, 588);
            Controls.Add(label3);
            Controls.Add(txtFilter);
            Controls.Add(btnBack);
            Controls.Add(dataGridUsers);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UsersView";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private DataGridView dataGridUsers;
        private Button btnDeleteUser;
        private Button btnEditUser;
        private Button btnAddUser;
        private Button btnBack;
        private TextBox txtFilter;
        private Label label3;
    }
}