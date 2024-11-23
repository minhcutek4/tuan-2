namespace tuan_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            if (n < 1)
            {
                MessageBox.Show("Giá trị n phải nhỏ hơn hoặc bằng 1");
                return;
            }

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            textBox2.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
