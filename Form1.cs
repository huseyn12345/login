namespace MPL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked) gender = radioButton1.Text;
            else if (radioButton2.Checked) gender = radioButton2.Text;
            else if (radioButton3.Checked) gender = radioButton3.Text;
            else gender = "N/A";

            string programmingLanguages = "";
            if (checkBox1.Checked) programmingLanguages += checkBox1.Text + " ";
            if (checkBox2.Checked) programmingLanguages += checkBox2.Text + " ";
            if (checkBox3.Checked) programmingLanguages += checkBox3.Text + " ";
            if (programmingLanguages == "") programmingLanguages = "N/A";

            string country = "";
            if (comboBox1.SelectedItem != null) country = comboBox1.SelectedItem.ToString();
            else country = "N/A";

            string city = "";
            if (listBox1.SelectedItem != null) city = listBox1.SelectedItem.ToString();
            else city = "N/A";

            MessageBox.Show("Gender: " + gender +
                            "\nCountry: " + country +
                            "\nCity: " + city +
                            "\nProgramming Languages: " + programmingLanguages);
        }
    }
}
