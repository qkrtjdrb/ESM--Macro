namespace ESM광고Macro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            button5 = new Button();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            PassWord = new DataGridViewTextBoxColumn();
            ONOFF = new DataGridViewTextBoxColumn();
            button8 = new Button();
            button6 = new Button();
            button9 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button10 = new Button();
            button11 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "ESMstart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(137, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "ON";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(223, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "OFF";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button4
            // 
            button4.Location = new Point(12, 81);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "On예약";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(223, 81);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "Off예약";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(223, 52);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 6;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(223, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(223, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 154);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 11;
            textBox5.Text = "ID 추가";
            // 
            // button7
            // 
            button7.Location = new Point(12, 214);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 13;
            button7.Text = "추가";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, PassWord, ONOFF });
            dataGridView1.Location = new Point(12, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(411, 150);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 130;
            // 
            // PassWord
            // 
            PassWord.HeaderText = "Password";
            PassWord.Name = "PassWord";
            PassWord.ReadOnly = true;
            PassWord.Width = 130;
            // 
            // ONOFF
            // 
            ONOFF.HeaderText = "ON/OFF";
            ONOFF.Name = "ONOFF";
            // 
            // button8
            // 
            button8.Location = new Point(223, 153);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 16;
            button8.Text = "불러오기";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Location = new Point(520, 12);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 17;
            button6.Text = "All Off";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // button9
            // 
            button9.Location = new Point(439, 12);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 18;
            button9.Text = "All ON";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(439, 58);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 19;
            label1.Text = "페이지 로딩 타이머";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(556, 58);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 20;
            label2.Text = "리스트 조회 타이머";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(439, 82);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "30";
            textBox6.Size = new Size(61, 23);
            textBox6.TabIndex = 21;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(556, 81);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "5";
            textBox7.Size = new Size(61, 23);
            textBox7.TabIndex = 22;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button10
            // 
            button10.Location = new Point(439, 111);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 23;
            button10.Text = "설정 저장";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(439, 140);
            button11.Name = "button11";
            button11.Size = new Size(92, 23);
            button11.TabIndex = 24;
            button11.Text = "설정 불러오기";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 409);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(dataGridView1);
            Controls.Add(button7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "ESM매크로";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Button button5;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button7;
        private DataGridView dataGridView1;
        private Button button8;
        private Button button6;
        private Button button9;
        private Label label1;
        private Label label2;
        private TextBox textBox6;
        private TextBox textBox7;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PassWord;
        private DataGridViewTextBoxColumn ONOFF;
        private Button button10;
        private Button button11;
    }
}
