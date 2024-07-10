namespace YourProply
{
    partial class PropertiesView
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
            btnDeleteProperty = new Button();
            btnEditProperty = new Button();
            btnAddProperty = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridProperties = new DataGridView();
            btnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridProperties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(btnDeleteProperty);
            panel1.Controls.Add(btnEditProperty);
            panel1.Controls.Add(btnAddProperty);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 588);
            panel1.TabIndex = 0;
            // 
            // btnDeleteProperty
            // 
            btnDeleteProperty.BackColor = Color.CornflowerBlue;
            btnDeleteProperty.Location = new Point(39, 210);
            btnDeleteProperty.Name = "btnDeleteProperty";
            btnDeleteProperty.Size = new Size(227, 40);
            btnDeleteProperty.TabIndex = 11;
            btnDeleteProperty.Text = "Usuń";
            btnDeleteProperty.UseVisualStyleBackColor = false;
            // 
            // btnEditProperty
            // 
            btnEditProperty.BackColor = Color.CornflowerBlue;
            btnEditProperty.Location = new Point(39, 152);
            btnEditProperty.Name = "btnEditProperty";
            btnEditProperty.Size = new Size(227, 40);
            btnEditProperty.TabIndex = 10;
            btnEditProperty.Text = "Edytuj";
            btnEditProperty.UseVisualStyleBackColor = false;
            // 
            // btnAddProperty
            // 
            btnAddProperty.BackColor = Color.CornflowerBlue;
            btnAddProperty.Location = new Point(39, 96);
            btnAddProperty.Name = "btnAddProperty";
            btnAddProperty.Size = new Size(227, 40);
            btnAddProperty.TabIndex = 9;
            btnAddProperty.Text = "Dodaj";
            btnAddProperty.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 19);
            label5.Name = "label5";
            label5.Size = new Size(250, 38);
            label5.TabIndex = 2;
            label5.Text = "NIERUCHOMOSCI";
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
            label1.Location = new Point(530, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(355, 32);
            label1.TabIndex = 1;
            label1.Text = "Twoje nieruchomości";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridProperties
            // 
            dataGridProperties.BackgroundColor = Color.Black;
            dataGridProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProperties.Location = new Point(363, 96);
            dataGridProperties.Name = "dataGridProperties";
            dataGridProperties.RowHeadersWidth = 51;
            dataGridProperties.Size = new Size(845, 462);
            dataGridProperties.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Location = new Point(986, 19);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 38);
            btnBack.TabIndex = 13;
            btnBack.Text = "Powrót";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // PropertiesView
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1244, 588);
            Controls.Add(btnBack);
            Controls.Add(dataGridProperties);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PropertiesView";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridProperties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private DataGridView dataGridProperties;
        private Button btnDeleteProperty;
        private Button btnEditProperty;
        private Button btnAddProperty;
        private Button btnBack;
    }
}