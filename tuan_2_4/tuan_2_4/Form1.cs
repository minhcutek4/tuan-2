namespace tuan_2_4
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
            try
            {
                int n = int.Parse(textBox1.Text);

                if (n <= 1)
                {
                    MessageBox.Show("Nhập lại");
                    return;
                }

                string snt = "";  
                int s = 0;  

                for (int i = 2; i <= n; i++)
                {
                    if (so_nguye_to(i))  
                    {
                        snt += i + ", ";  
                        s += i;  
                    }
                }

                textBox2.Text = snt;
                textBox3.Text = s.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập lại");
            }
        }

        private bool so_nguye_to(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;  
            if (n % 2 == 0) return false;  

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
