namespace tuan_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int sodaonguoc = dns(a);
                textBox2.Text = sodaonguoc.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("vui lòng nhập lại");   
            }
        }

        private int dns(int n)
        {
            bool so_am = n < 0;
            n = Math.Abs(n);

            int s = 0;

            while (n != 0) {
                int t = n % 10;
                s = s * 10 + t;
                n = n / 10;
            }
            if (so_am) {
                s = -s;
            }
            return s;
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
