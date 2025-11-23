using System.Media;

namespace samolyot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer enis = new SoundPlayer(@"C:\Users\mikoq\Downloads\inishazirliklari.wav");
        SoundPlayer turbulans = new SoundPlayer(@"C:\Users\mikoq\Downloads\turbulans.wav");
        SoundPlayer tsk = new SoundPlayer(@"C:\Users\mikoq\Downloads\tesekkurler.wav");
        SoundPlayer beep = new SoundPlayer(@"C:\Users\mikoq\Downloads\beep.wav");
        SoundPlayer isikacmakapama = new SoundPlayer(@"C:\Users\mikoq\Downloads\isikacmakapamasesi.wav");
        SoundPlayer kemerler = new SoundPlayer(@"C:\Users\mikoq\Downloads\kemerler.wav");


        private void button2_Click(object sender, EventArgs e)
        {
            turbulans.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enis.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            isikacmakapama.Play();
            if (pictureBox2.Visible)
            {
                pictureBox2.Visible = false;
            }
            else pictureBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kemerler.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tsk.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            beep.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 10);
            if (pictureBox1.Location.Y <= 0) {
                timer1.Stop();
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
    } 
}
