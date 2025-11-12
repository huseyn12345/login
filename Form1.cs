namespace Bomba
{
    public partial class Form1 : Form
    {
        int time = 0;
        Random rand = new Random();
        List<PictureBox> bombs = new List<PictureBox>();
        bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!gameOver)
                pictureBox5.Location = new Point(pictureBox5.Location.X + 10, pictureBox5.Location.Y);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!gameOver)
                pictureBox5.Location = new Point(pictureBox5.Location.X - 10, pictureBox5.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameOver) return;

            if (time % 5 == 0)
            {
                PictureBox bomb = new PictureBox();
                bomb.Image = Properties.Resources.grenade;
                bomb.SizeMode = PictureBoxSizeMode.StretchImage;
                bomb.Size = new Size(40, 40);
                bomb.BackColor = Color.Transparent;
                bomb.Location = new Point(rand.Next(0, this.ClientSize.Width - bomb.Width), 0);
                bombs.Add(bomb);
                this.Controls.Add(bomb);
                bomb.BringToFront();
            }

            for (int i = bombs.Count - 1; i >= 0; i--)
            {
                bombs[i].Top += 10;

                if (bombs[i].Bounds.IntersectsWith(pictureBox5.Bounds))
                {
                    timer1.Stop();
                    gameOver = true;
                    MessageBox.Show("Oyun bitdi");
                    return;
                }

                if (bombs[i].Top > this.ClientSize.Height)
                {
                    this.Controls.Remove(bombs[i]);
                    bombs.RemoveAt(i);
                }
            }

            time++;
        }
    }
}
