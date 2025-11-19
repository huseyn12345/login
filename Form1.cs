namespace AllFileCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //read file
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Files (*.*) | *.*";
            op.ShowDialog();

            //read
            richTextBox1.Text = File.ReadAllText(op.FileName);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Files (*.*) | *.*";
            op.ShowDialog();
            //append
            File.AppendAllText(op.FileName, richTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Open Dialog
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Files (*.*) | *.*";
            //op.FileName = "document";
            op.ShowDialog();

            //delete file
            DialogResult dr = MessageBox.Show("Are you sure to delete this file?", "Delete File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                File.Delete(op.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //write file
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "All Files (*.*) | *.*";
            sd.ShowDialog();

            //write
            File.WriteAllText(sd.FileName, richTextBox1.Text);

        }

   
    }
}
