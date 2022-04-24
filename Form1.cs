namespace Form_Ders_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "100$";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "100£";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "100TL";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1 + "/nkiraplarrr";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1 + " /n " + dateTimePicker1.Text + "/n" + trackBar1.Value;
        }
    }
}