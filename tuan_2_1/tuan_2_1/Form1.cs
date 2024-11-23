namespace tuan_2_1
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
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);

                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                            textBox4.Text = "Phương trình có vô số nghiệm.";
                        else
                            textBox4.Text = "Phương trình vô nghiệm.";
                    }
                    else
                    {
                        double x = -c / b;
                        textBox4.Text = $"Phương trình có nghiệm ";
                        textBox5.Text = $"x = {x}";

                    }
                }
                else
                {
                    double delta = b * b - 4 * a * c;

                    if (delta < 0)
                    {
                        textBox4.Text = "Phương trình vô nghiệm.";
                    }
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        textBox4.Text = $"Phương trình có nghiệm kép ";
                        textBox5.Text = $"x = {x}";

                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        textBox4.Text = $"Phương trình có hai nghiệm:\n x1 = {x1}, x2 = {x2}";
                        textBox5.Text = $" x1 = {x1}, x2 = {x2}";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng số liệu!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
