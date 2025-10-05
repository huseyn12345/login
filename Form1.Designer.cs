namespace Travel_Ticket_Modern
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private TextBox textBox3;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();

            // ComboBox1
            comboBox1.Location = new System.Drawing.Point(40, 30);
            comboBox1.Size = new System.Drawing.Size(140, 24);
            comboBox1.Items.AddRange(new object[] { "Baku", "Ganja", "Sumgait", "Lankaran" });

            // ComboBox2
            comboBox2.Location = new System.Drawing.Point(200, 30);
            comboBox2.Size = new System.Drawing.Size(140, 24);
            comboBox2.Items.AddRange(new object[] { "Baku", "Ganja", "Sumgait", "Lankaran" });

            // MaskedTextBox1 (Date)
            maskedTextBox1.Location = new System.Drawing.Point(40, 70);
            maskedTextBox1.Mask = "00/00/0000";

            // MaskedTextBox2 (Time)
            maskedTextBox2.Location = new System.Drawing.Point(200, 70);
            maskedTextBox2.Mask = "00:00";

            // Seat
            textBox1.Location = new System.Drawing.Point(40, 110);
            textBox1.PlaceholderText = "Seat No";

            // Name
            textBox2.Location = new System.Drawing.Point(200, 110);
            textBox2.PlaceholderText = "Name";

            // Zip Code
            maskedTextBox3.Location = new System.Drawing.Point(40, 150);
            maskedTextBox3.Mask = "0000";

            // Phone
            maskedTextBox4.Location = new System.Drawing.Point(200, 150);
            maskedTextBox4.Mask = "(000) 000-0000";

            // Email
            textBox3.Location = new System.Drawing.Point(40, 190);
            textBox3.Size = new System.Drawing.Size(300, 22);
            textBox3.PlaceholderText = "Email";

            // ListBox
            listBox1.Location = new System.Drawing.Point(40, 230);
            listBox1.Size = new System.Drawing.Size(300, 120);

            // Button1 (Swap)
            button1.Location = new System.Drawing.Point(360, 30);
            button1.Size = new System.Drawing.Size(90, 30);
            button1.Text = "Swap";
            button1.Click += button1_Click;

            // Button2 (Add Ticket)
            button2.Location = new System.Drawing.Point(360, 70);
            button2.Size = new System.Drawing.Size(90, 30);
            button2.Text = "Add";
            button2.Click += button2_Click;

            // Button3 (Remove)
            button3.Location = new System.Drawing.Point(360, 110);
            button3.Size = new System.Drawing.Size(90, 30);
            button3.Text = "Remove";
            button3.Click += button3_Click;

            // Button4 (Exit)
            button4.Location = new System.Drawing.Point(360, 150);
            button4.Size = new System.Drawing.Size(90, 30);
            button4.Text = "Exit";
            button4.Click += button4_Click;

            // Form1
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(480, 380);
            Controls.AddRange(new Control[] { comboBox1, comboBox2, maskedTextBox1, maskedTextBox2, textBox1, textBox2, maskedTextBox3, maskedTextBox4, textBox3, listBox1, button1, button2, button3, button4 });
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Text = "Travel Ticket Modern";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
