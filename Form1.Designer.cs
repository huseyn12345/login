namespace UserCheck
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            titleLabel = new Label();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // Form
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(540, 530);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Add";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // Title Label
            titleLabel.Text = "User Registration Panel";
            titleLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(114, 137, 218);
            titleLabel.AutoSize = false;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Height = 60;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;

            // DataGridView
            dataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(114, 137, 218);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(153, 170, 181);
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Username, Password, Date });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Height = 200;

            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.Width = 160;

            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.Width = 160;

            Date.HeaderText = "Registration Date";
            Date.Name = "Date";
            Date.Width = 180;

            // Label1
            label1.Text = "Username";
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 230);
            label1.AutoSize = true;

            // TextBox1
            textBox1.Location = new Point(20, 260);
            textBox1.Size = new Size(490, 30);
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.BackColor = Color.FromArgb(64, 68, 75);
            textBox1.ForeColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;

            // Label2
            label2.Text = "Password";
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 305);
            label2.AutoSize = true;

            // TextBox2
            textBox2.Location = new Point(20, 335);
            textBox2.Size = new Size(490, 30);
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.BackColor = Color.FromArgb(64, 68, 75);
            textBox2.ForeColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;

            // Button1
            button1.Text = "Add User";
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.Size = new Size(490, 40);
            button1.Location = new Point(20, 385);
            button1.BackColor = Color.FromArgb(46, 204, 113);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Click += button1_Click;

            // Button2
            button2.Text = "Go to User Check Page";
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.Size = new Size(490, 40);
            button2.Location = new Point(20, 440);
            button2.BackColor = Color.FromArgb(52, 152, 219);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.Click += button2_Click;

            // Add Controls
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(titleLabel);

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Date;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
