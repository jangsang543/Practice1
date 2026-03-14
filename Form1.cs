namespace Practice1_namecard_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgButton_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.루피;
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/jangsang543",
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void bgButton_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            // 0~255 사이의R, G, B 값을무작위로생성하여배경색에적용
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
