namespace VP_Homework4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double times = double.Parse(textBox1.Text);

            if (times > 0)
            {
                double result = 1;

                for (int i = 1; i <= times; i++)
                {
                    result = result * i;
                }

                label2.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Insert nonnegative integer or greater than 0!");
            }

        }
    }
}