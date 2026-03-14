namespace Practice1_namecard_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            nameLabel = new Label();
            majorLabel = new Label();
            pictureBox1 = new PictureBox();
            emailLabel = new Label();
            phoneLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("휴먼편지체", 40F, FontStyle.Bold, GraphicsUnit.Point, 129);
            nameLabel.Location = new Point(485, 127);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(356, 93);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "이름: 장상";
            nameLabel.Click += label1_Click;
            // 
            // majorLabel
            // 
            majorLabel.AutoSize = true;
            majorLabel.Font = new Font("휴먼편지체", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            majorLabel.Location = new Point(485, 255);
            majorLabel.Name = "majorLabel";
            majorLabel.Size = new Size(332, 47);
            majorLabel.TabIndex = 4;
            majorLabel.Text = "학과: 컴퓨터sw학과";
            majorLabel.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(28, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 534);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("휴먼편지체", 20F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 129);
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.Location = new Point(485, 337);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(472, 47);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "이메일: wkdtkd@gmail.com";
            emailLabel.Click += label1_Click_1;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("휴먼편지체", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            phoneLabel.ForeColor = Color.Fuchsia;
            phoneLabel.Location = new Point(485, 432);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(493, 47);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "연락처: 010 - 1234 - 5678";
            phoneLabel.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 723);
            Controls.Add(phoneLabel);
            Controls.Add(emailLabel);
            Controls.Add(pictureBox1);
            Controls.Add(majorLabel);
            Controls.Add(nameLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label nameLabel;
        private Label majorLabel;
        private PictureBox pictureBox1;
        private Label emailLabel;
        private Label phoneLabel;
    }
}
