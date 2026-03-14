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
            imageButton = new Button();
            githubButton = new Button();
            bgButton = new Button();
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
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
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
            // imageButton
            // 
            imageButton.BackColor = SystemColors.ActiveCaption;
            imageButton.FlatStyle = FlatStyle.Popup;
            imageButton.Font = new Font("휴먼편지체", 26F, FontStyle.Bold, GraphicsUnit.Point, 129);
            imageButton.ForeColor = SystemColors.ActiveCaptionText;
            imageButton.Location = new Point(61, 588);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(370, 126);
            imageButton.TabIndex = 8;
            imageButton.Text = "사진 바꾸기";
            imageButton.UseVisualStyleBackColor = false;
            imageButton.Click += imageButton_Click;
            // 
            // githubButton
            // 
            githubButton.BackColor = Color.FromArgb(255, 192, 128);
            githubButton.Font = new Font("휴먼편지체", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            githubButton.Location = new Point(862, 127);
            githubButton.Name = "githubButton";
            githubButton.Size = new Size(171, 154);
            githubButton.TabIndex = 9;
            githubButton.Text = "GitHub";
            githubButton.UseVisualStyleBackColor = false;
            githubButton.Click += githubButton_Click;
            // 
            // bgButton
            // 
            bgButton.BackColor = Color.Green;
            bgButton.Font = new Font("휴먼편지체", 28F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bgButton.ForeColor = Color.White;
            bgButton.Location = new Point(554, 546);
            bgButton.Name = "bgButton";
            bgButton.Size = new Size(546, 168);
            bgButton.TabIndex = 10;
            bgButton.Text = "배경색 랜덤 변경";
            bgButton.UseVisualStyleBackColor = false;
            bgButton.Click += bgButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 723);
            Controls.Add(bgButton);
            Controls.Add(githubButton);
            Controls.Add(imageButton);
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
        private Button imageButton;
        private Button githubButton;
        private Button bgButton;
    }
}
