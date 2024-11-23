namespace tuan_2_4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 44);
            label1.Name = "label1";
            label1.Size = new Size(505, 41);
            label1.TabIndex = 0;
            label1.Text = "Liệt kê và tính tổng các số nguyên tố";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 141);
            label2.Name = "label2";
            label2.Size = new Size(122, 41);
            label2.TabIndex = 1;
            label2.Text = "Nhập n:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 241);
            label3.Name = "label3";
            label3.Size = new Size(111, 41);
            label3.TabIndex = 2;
            label3.Text = "Liệt kê:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 342);
            label4.Name = "label4";
            label4.Size = new Size(94, 41);
            label4.TabIndex = 3;
            label4.Text = "Tổng:";
            // 
            // button1
            // 
            button1.Location = new Point(112, 469);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 4;
            button1.Text = "Kết quả";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(399, 469);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 5;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(665, 469);
            button3.Name = "button3";
            button3.Size = new Size(188, 58);
            button3.TabIndex = 6;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(501, 47);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(501, 47);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(266, 342);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(501, 47);
            textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 666);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "bai 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
