namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int RandomNumber;
        int count = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            RandomNumber = random.Next(1, 100);
            count = 0;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            int myNumber = Convert.ToInt32(maskedTextBox1.Text);
            if(myNumber == RandomNumber)
            {
                MessageBox.Show("Congratulations! You guessed the number.");
                listBox1.Items.Add("You guessed the number "+RandomNumber+" in " +(count + 1)+" attempts.");
            }
            else if(myNumber < RandomNumber)
            {
                MessageBox.Show("Try a higher number!");
                count++;
            }
            else 
            {
                MessageBox.Show("Try a lower number!");
                count++;
            }
        }
    }
}
