namespace tuan_2_1
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
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 37);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 0;
            label1.Text = "Giải phương trình bậc 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 137);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 1;
            label2.Text = "Hệ số A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 205);
            label3.Name = "label3";
            label3.Size = new Size(101, 32);
            label3.TabIndex = 2;
            label3.Text = "Hệ số B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 269);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 3;
            label4.Text = "Hệ số C:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 328);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 4;
            label5.Text = "Kết quả:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 404);
            label6.Name = "label6";
            label6.Size = new Size(105, 32);
            label6.TabIndex = 5;
            label6.Text = "Nghiệm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(496, 39);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(496, 39);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(246, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(496, 39);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(246, 321);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(496, 39);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(246, 397);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(496, 39);
            textBox5.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(152, 524);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 11;
            button1.Text = "Giải";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(417, 524);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 12;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(679, 524);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 13;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 681);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
