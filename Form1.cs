namespace CarSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        bool isGameOver = false;
        bool isCounted1 = false;
        bool isCounted2 = false;
        bool isCounted3 = false;
        bool isCounted4 = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand1 = new Random();
            Random rand2 = new Random();
            Random rand3 = new Random();
            Random rand4 = new Random();
            Random rand5 = new Random();
            Random rand6 = new Random();
            Random rand7 = new Random();
            Random rand8 = new Random();
            textBox1.Text = "0";

            pictureBox6.Location = new Point(rand1.Next(0, 120), rand2.Next(360, 480));
            pictureBox7.Location = new Point(rand3.Next(200, 320), rand4.Next(200, 280));
            pictureBox8.Location = new Point(rand5.Next(0, 120), rand6.Next(30, 130));
            pictureBox9.Location = new Point(rand7.Next(200, 320), rand8.Next(0, 110));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isGameOver) return;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isGameOver) return;
            timer1.Stop();
            timer2.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isGameOver) return;
            if (pictureBox1.Location.X < 310)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isGameOver) return;
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 20, pictureBox1.Location.Y);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (isGameOver) return;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);

            if (pictureBox1.Location.Y < 0) timer1.Stop();

            if (pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox7.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox8.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                timer1.Stop();
                pictureBox5.Visible = true;
                isGameOver = true;
            }

            if (!isCounted1 && pictureBox1.Location.Y < pictureBox6.Location.Y)
            {
                count++;
                textBox1.Text = count.ToString();
                isCounted1 = true;
            }

            if (!isCounted2 && pictureBox1.Location.Y < pictureBox7.Location.Y)
            {
                count++;
                textBox1.Text = count.ToString();
                isCounted2 = true;
            }

            if (!isCounted3 && pictureBox1.Location.Y < pictureBox8.Location.Y)
            {
                count++;
                textBox1.Text = count.ToString();
                isCounted3 = true;
            }

            if (!isCounted4 && pictureBox1.Location.Y < pictureBox9.Location.Y)
            {
                count++;
                textBox1.Text = count.ToString();
                isCounted4 = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
            if (pictureBox1.Location.Y > 410) timer2.Stop();
            
            if (pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox7.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox8.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                timer2.Stop();
                pictureBox5.Visible = true;
                isGameOver = true;
            }
        }

    }
}
