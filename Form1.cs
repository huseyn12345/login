using System.Drawing.Drawing2D;

namespace imageEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap original;
        Bitmap bmp;
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                original = new Bitmap(path); 
                bmp = new Bitmap(original); 

                pictureBox2.Image = bmp;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Şəkil seçilməyib !", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {


                SaveFileDialog sv = new SaveFileDialog();
                if (DialogResult.OK == sv.ShowDialog())
                {
                    string path = sv.FileName;
                    bmp.Save(path);
                    MessageBox.Show("Şəkil yadda saxlanıldı", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (original == null) return;

            bmp = new Bitmap(original);
            Graphics gr = Graphics.FromImage(bmp);

            LinearGradientBrush liner = new LinearGradientBrush(
                new Point(0, 0),
                new Point(bmp.Width, 0),
                Color.FromArgb(50, 225, 128, 172),
                Color.FromArgb(50, 52, 58, 178));

            gr.FillRectangle(liner, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (original == null) return;

            bmp = new Bitmap(original);
            Graphics gr = Graphics.FromImage(bmp);

            LinearGradientBrush liner = new LinearGradientBrush(
                new Point(0, 0),
                new Point(bmp.Width, 0),
                Color.FromArgb(80, 255, 0, 0),
                Color.FromArgb(80, 120, 0, 0));

            gr.FillRectangle(liner, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (original == null) return;

            bmp = new Bitmap(original);
            Graphics gr = Graphics.FromImage(bmp);

            LinearGradientBrush liner = new LinearGradientBrush(
                new Point(0, 0),
                new Point(bmp.Width, 0),
                Color.FromArgb(80, 0, 100, 255),
                Color.FromArgb(80, 0, 0, 120));

            gr.FillRectangle(liner, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
        } 
        private void button7_Click(object sender, EventArgs e)
        {
            if (original == null) return;

            bmp = new Bitmap(original);
            Graphics gr = Graphics.FromImage(bmp);

            LinearGradientBrush liner = new LinearGradientBrush(
                new Point(0, 0),
                new Point(bmp.Width, 0),
                Color.FromArgb(70, 255, 255, 255),
                Color.FromArgb(20, 255, 255, 255));

            gr.FillRectangle(liner, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (original == null) return;

            bmp = new Bitmap(original);
            Graphics gr = Graphics.FromImage(bmp);

            LinearGradientBrush liner = new LinearGradientBrush(
                new Point(0, 0),
                new Point(bmp.Width, 0),
                Color.FromArgb(60, 0, 255, 150),
                Color.FromArgb(60, 0, 120, 80));

            gr.FillRectangle(liner, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (original == null) return;

            bmp = new Bitmap(original);
            Graphics gr = Graphics.FromImage(bmp);

            LinearGradientBrush liner = new LinearGradientBrush(
                new Point(0, 0),
                new Point(bmp.Width, 0),
                Color.FromArgb(70, 255, 255, 0),
                Color.FromArgb(40, 255, 180, 0));

            gr.FillRectangle(liner, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
        }
    }
}
