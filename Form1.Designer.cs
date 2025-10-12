namespace Classroom_rezerv
{
    partial class Form1
    {
  
        private System.ComponentModel.IContainer components = null;

   
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

   
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            button3 = new Button();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            button4 = new Button();
            label10 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            maskedTextBox4 = new MaskedTextBox();
            label11 = new Label();
            label12 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
       
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 82, 95);
            ClientSize = new Size(720, 680);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ForeColor = Color.WhiteSmoke;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Classroom rezerv";
       
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(40, 30);
            groupBox1.Margin = new Padding(10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(12);
            groupBox1.Size = new Size(300, 250);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sinif A";
            groupBox1.BackColor = Color.FromArgb(46, 204, 113); 
          
            button1.BackColor = Color.FromArgb(25, 111, 61);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 90, 50);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 130, 70);
            button1.Location = new Point(160, 190);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(120, 36);
            button1.TabIndex = 6;
            button1.Text = "Rezerv et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.ForeColor = Color.White;
        
            label3.AutoSize = true;
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Qalan müddət:";
            label3.ForeColor = Color.WhiteSmoke;
         
            textBox2.Location = new Point(160, 142);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(120, 27);
            textBox2.TabIndex = 4;
         
            textBox1.Location = new Point(160, 98);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 27);
            textBox1.TabIndex = 3;
          
            maskedTextBox1.Location = new Point(160, 46);
            maskedTextBox1.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox1.Mask = "00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(120, 27);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.ValidatingType = typeof(int);
         
            label2.AutoSize = true;
            label2.Location = new Point(120, 101);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Qrup:";
            label2.ForeColor = Color.WhiteSmoke;
           
            label1.AutoSize = true;
            label1.Location = new Point(100, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Müddət:";
            label1.ForeColor = Color.WhiteSmoke;
          
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(380, 30);
            groupBox2.Margin = new Padding(10);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(12);
            groupBox2.Size = new Size(300, 250);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sinif B";
            groupBox2.BackColor = Color.FromArgb(52, 152, 219); 
        
            button2.BackColor = Color.FromArgb(18, 88, 137);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 70, 110);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 110, 170);
            button2.Location = new Point(160, 190);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(120, 36);
            button2.TabIndex = 12;
            button2.Text = "Rezerv et";
            button2.UseVisualStyleBackColor = false;
            button2.Click+= button2_Click;
            button2.ForeColor = Color.White;
          
            label4.AutoSize = true;
            label4.Location = new Point(12, 148);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 11;
            label4.Text = "Qalan müddət:";
            label4.ForeColor = Color.WhiteSmoke;
         
            textBox3.Location = new Point(160, 142);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(120, 27);
            textBox3.TabIndex = 10;
         
            textBox4.Location = new Point(160, 98);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(120, 27);
            textBox4.TabIndex = 9;
        
            maskedTextBox2.Location = new Point(160, 46);
            maskedTextBox2.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox2.Mask = "00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(120, 27);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(int);
       
            label5.AutoSize = true;
            label5.Location = new Point(120, 101);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 7;
            label5.Text = "Qrup:";
            label5.ForeColor = Color.WhiteSmoke;
        
            label6.AutoSize = true;
            label6.Location = new Point(100, 50);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 6;
            label6.Text = "Müddət:";
            label6.ForeColor = Color.WhiteSmoke;
        
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(maskedTextBox3);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(40, 320);
            groupBox3.Margin = new Padding(10);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(12);
            groupBox3.Size = new Size(300, 250);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sinif C";
            groupBox3.BackColor = Color.FromArgb(155, 89, 182);
         
            button3.BackColor = Color.FromArgb(113, 54, 131);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 45, 110);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 65, 140);
            button3.Location = new Point(160, 190);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(120, 36);
            button3.TabIndex = 12;
            button3.Text = "Rezerv et";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.ForeColor = Color.White;
            
            label7.AutoSize = true;
            label7.Location = new Point(12, 148);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 11;
            label7.Text = "Qalan müddət:";
            label7.ForeColor = Color.WhiteSmoke;
        
            textBox5.Location = new Point(160, 142);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(120, 27);
            textBox5.TabIndex = 10;
          
            textBox6.Location = new Point(160, 98);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 27);
            textBox6.TabIndex = 9;
          
            maskedTextBox3.Location = new Point(160, 46);
            maskedTextBox3.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox3.Mask = "00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(120, 27);
            maskedTextBox3.TabIndex = 8;
            maskedTextBox3.ValidatingType = typeof(int);
           
            label8.AutoSize = true;
            label8.Location = new Point(120, 101);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 7;
            label8.Text = "Qrup:";
            label8.ForeColor = Color.WhiteSmoke;
         
            label9.AutoSize = true;
            label9.Location = new Point(100, 50);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 6;
            label9.Text = "Müddət:";
            label9.ForeColor = Color.WhiteSmoke;
            
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(textBox7);
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(maskedTextBox4);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(380, 320);
            groupBox4.Margin = new Padding(10);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(12);
            groupBox4.Size = new Size(300, 250);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sinif D";
            groupBox4.BackColor = Color.FromArgb(243, 156, 18);
         
            button4.BackColor = Color.FromArgb(195, 120, 10);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 100, 8);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 130, 12);
            button4.Location = new Point(160, 190);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(120, 36);
            button4.TabIndex = 12;
            button4.Text = "Rezerv et";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            button4.ForeColor = Color.White;
            
            label10.AutoSize = true;
            label10.Location = new Point(12, 148);
            label10.Name = "label10";
            label10.Size = new Size(107, 20);
            label10.TabIndex = 11;
            label10.Text = "Qalan müddət:";
            label10.ForeColor = Color.WhiteSmoke;
         
            textBox7.Location = new Point(160, 142);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(120, 27);
            textBox7.TabIndex = 10;
        
            textBox8.Location = new Point(160, 98);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(120, 27);
            textBox8.TabIndex = 9;
         
            maskedTextBox4.Location = new Point(160, 46);
            maskedTextBox4.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox4.Mask = "00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(120, 27);
            maskedTextBox4.TabIndex = 8;
            maskedTextBox4.ValidatingType = typeof(int);
        
            label11.AutoSize = true;
            label11.Location = new Point(120, 101);
            label11.Name = "label11";
            label11.Size = new Size(45, 20);
            label11.TabIndex = 7;
            label11.Text = "Qrup:";
            label11.ForeColor = Color.WhiteSmoke;
          
            label12.AutoSize = true;
            label12.Location = new Point(100, 50);
            label12.Name = "label12";
            label12.Size = new Size(64, 20);
            label12.TabIndex = 6;
            label12.Text = "Müddət:";
            label12.ForeColor = Color.WhiteSmoke;
         
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private MaskedTextBox maskedTextBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox6;
        private MaskedTextBox maskedTextBox3;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox7;
        private TextBox textBox8;
        private MaskedTextBox maskedTextBox4;
        private Label label11;
        private Label label12;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}
