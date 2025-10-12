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


int counter1=0,counter2=0,counter3=0,counter4=0;


private void button1_Click(object sender, EventArgs e) { StartTimer(maskedTextBox1, textBox1, textBox2, groupBox1, ref counter1, timer1); }
private void timer1_Tick(object sender, EventArgs e) { TimerTick(ref counter1, textBox2, groupBox1, textBox1, maskedTextBox1); }


private void button2_Click(object sender, EventArgs e) { StartTimer(maskedTextBox2, textBox4, textBox3, groupBox2, ref counter2, timer2); }
private void timer2_Tick(object sender, EventArgs e) { TimerTick(ref counter2, textBox3, groupBox2, textBox4, maskedTextBox2); }


private void button3_Click(object sender, EventArgs e) { StartTimer(maskedTextBox3, textBox6, textBox5, groupBox3, ref counter3, timer3); }
private void timer3_Tick(object sender, EventArgs e) { TimerTick(ref counter3, textBox5, groupBox3, textBox6, maskedTextBox3); }


private void button4_Click(object sender, EventArgs e) { StartTimer(maskedTextBox4, textBox8, textBox7, groupBox4, ref counter4, timer4); }
private void timer4_Tick(object sender, EventArgs e) { TimerTick(ref counter4, textBox7, groupBox4, textBox8, maskedTextBox4); }



private void StartTimer(MaskedTextBox durationBox, TextBox groupBoxCodeBox, TextBox counterBox, GroupBox group, ref int counter, System.Windows.Forms.Timer timer)
{
if(durationBox.Text == "") { MessageBox.Show("Zəhmət olmasa müddət daxil edin"); return; }
if(groupBoxCodeBox.Text == "") { MessageBox.Show("Zəhmət olmasa qrup kodu daxil edin"); return; }
counter = Convert.ToInt32(durationBox.Text);
counterBox.Text = counter.ToString();
group.BackColor = Color.Red;
timer.Tick += (s,e) => { TimerTick(ref counter, counterBox, group, groupBoxCodeBox, durationBox); };
timer.Start();
}


private void TimerTick(ref int counter, TextBox counterBox, GroupBox group, TextBox groupBoxCodeBox, MaskedTextBox durationBox)
{
counter--;
counterBox.Text = counter.ToString();
if(counter==0)
{
var t = group.BackColor;
counterBox.Clear();
groupBoxCodeBox.Clear();
durationBox.Clear();
group.BackColor = Color.Green;
}
}
}
}
