namespace Classroom_rezerv
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer3.Interval = 1000;
            timer4.Interval = 1000;
        }
        int counter1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Equals("")) MessageBox.Show("Zəhmət olmasa müddət daxil edin");
            else if (textBox1.Text.Equals("")) MessageBox.Show("Zəhmət olmasa qrup kodu daxil edin");
            else { 
                timer1.Start();
            counter1=Convert.ToInt32(maskedTextBox1.Text);
            textBox2.Text = counter1.ToString();
            groupBox1.BackColor = Color.Red;
            timer1.Tick += timer1_Tick;
        }}
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1--; 
            textBox2.Text = counter1.ToString();

            if (counter1 == 0)
            {
                timer1.Stop(); 
                groupBox1.BackColor = Color.Green;
                textBox1.Clear();
                maskedTextBox1.Clear();
                textBox2.Clear();
            }
        }
        int counter2 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text.Equals("")) MessageBox.Show("Zəhmət olmasa müddət daxil edin");
            else if (textBox4.Text.Equals("")) MessageBox.Show("Zəhmət olmasa qrup kodu daxil edin");
            else
            {
                timer2.Start();
                counter2 = Convert.ToInt32(maskedTextBox2.Text);
                textBox3.Text = counter2.ToString();
                groupBox2.BackColor = Color.Red;
                timer2.Tick += timer2_Tick;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            counter2--;
            textBox3.Text = counter2.ToString();

            if (counter2 == 0)
            {
                timer2.Stop();
                groupBox2.BackColor = Color.Green;
                textBox4.Clear();
                maskedTextBox2.Clear();
                textBox3.Clear();
            }
        }
        int counter3 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (maskedTextBox3.Text.Equals("")) MessageBox.Show("Zəhmət olmasa müddət daxil edin");
            else if (textBox6.Text.Equals("")) MessageBox.Show("Zəhmət olmasa qrup kodu daxil edin");
            else
            {
                timer3.Start();
                counter3 = Convert.ToInt32(maskedTextBox3.Text);
                textBox5.Text = counter3.ToString();
                groupBox3.BackColor = Color.Red;
                timer3.Tick += timer3_Tick;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            counter3--;
            textBox5.Text = counter3.ToString();

            if (counter3 == 0)
            {
                timer3.Stop();
                groupBox3.BackColor = Color.Green;
                textBox6.Clear();
                maskedTextBox3.Clear();
                textBox5.Clear();
            }
        }
        int counter4 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (maskedTextBox4.Text.Equals("")) MessageBox.Show("Zəhmət olmasa müddət daxil edin");
            else if (textBox8.Text.Equals("")) MessageBox.Show("Zəhmət olmasa qrup kodu daxil edin");
            else
            {
                timer4.Start();
                counter4 = Convert.ToInt32(maskedTextBox4.Text);
                textBox7.Text = counter4.ToString();
                groupBox4.BackColor = Color.Red;
                timer4.Tick += timer4_Tick;
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            counter4--;
            textBox7.Text = counter4.ToString();

            if (counter4 == 0)
            {
                timer4.Stop();
                groupBox4.BackColor = Color.Green;
                textBox8.Clear();
                maskedTextBox4.Clear();
                textBox7.Clear();
            }
        }

    }
}
