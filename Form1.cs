using System.Numerics;

namespace arkonoid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        Random randY = new Random();
        Random randX = new Random();
        Random randT = new Random();
        int T = 0;
        int x = 0;
        int y = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && panel1.Location.X > 0)
            {
                panel1.Location = new Point(panel1.Location.X - 10, panel1.Location.Y);
            }
            if (e.KeyCode == Keys.Right && panel1.Location.X <= 730)
            {
                panel1.Location = new Point(panel1.Location.X + 10, panel1.Location.Y);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            if (pictureBox1.Bounds.IntersectsWith(panel1.Bounds))
            {
                counter++;
                T = randT.Next(3, 10);
                x = randX.Next(-50, 50);
                y = randY.Next(10, 100);
                timer2.Start();
            }
            else if(pictureBox1.Location.X <=0)
            {
                T = randT.Next(3, 10);
                x = randX.Next(0, 50);
                y = randY.Next(-50, 50);
                timer2.Start();
            }
            else if (pictureBox1.Location.X >=800)
            {
                T = randT.Next(3, 10);
                x = randX.Next(-50, 0);
                y = randY.Next(-50, 50);
                timer2.Start();
            }
            else if(pictureBox1.Location.Y==0)
            {
                T = randT.Next(3, 10);
                x = randX.Next(-50, 50);
                y = randY.Next(0, 50);
                timer2.Start();
            }
            else if (pictureBox1.Location.Y > this.Height)
            {
             
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Game Over! Your score: " + counter);
                DialogResult dr = MessageBox.Show("Do you want to play again?", "Restart", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (T > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + x, pictureBox1.Location.Y - y);
 
                T--;
            }
        }
    }
}
