namespace YourProply
{
    partial class ChatbotView
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
            label3 = new Label();
            txtQuestion = new TextBox();
            txtAnswer = new TextBox();
            btnAsk = new Button();
            label4 = new Label();
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
            panel1.Size = new Size(312, 549);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(92, 63);
            label5.Name = "label5";
            label5.Size = new Size(100, 38);
            label5.TabIndex = 2;
            label5.Text = "AI Bot";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(3, 182);
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
            label1.Location = new Point(578, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 32);
            label1.TabIndex = 1;
            label1.Text = "Zadaj pytanie";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(363, 136);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 3;
            label3.Text = "Pyatnie:";
            // 
            // txtQuestion
            // 
            txtQuestion.BackColor = Color.FromArgb(15, 15, 15);
            txtQuestion.BorderStyle = BorderStyle.FixedSingle;
            txtQuestion.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestion.ForeColor = Color.White;
            txtQuestion.Location = new Point(443, 134);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(437, 37);
            txtQuestion.TabIndex = 4;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = Color.FromArgb(15, 15, 15);
            txtAnswer.BorderStyle = BorderStyle.FixedSingle;
            txtAnswer.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer.ForeColor = Color.White;
            txtAnswer.Location = new Point(443, 205);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ReadOnly = true;
            txtAnswer.Size = new Size(555, 264);
            txtAnswer.TabIndex = 5;
            // 
            // btnAsk
            // 
            btnAsk.BackColor = Color.CornflowerBlue;
            btnAsk.Location = new Point(908, 134);
            btnAsk.Name = "btnAsk";
            btnAsk.Size = new Size(90, 37);
            btnAsk.TabIndex = 7;
            btnAsk.Text = "Zapytaj";
            btnAsk.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(328, 205);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 9;
            label4.Text = "Odpowiedź:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Location = new Point(993, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 37);
            btnBack.TabIndex = 10;
            btnBack.Text = "Wróć";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // ChatbotView
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1095, 549);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(btnAsk);
            Controls.Add(txtAnswer);
            Controls.Add(txtQuestion);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChatbotView";
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
        private Label label3;
        private TextBox txtQuestion;
        private TextBox txtAnswer;
        private PictureBox pictureBox1;
        private Button btnAsk;
        private Label label5;
        private Label label4;
        private Button btnBack;
    }
}