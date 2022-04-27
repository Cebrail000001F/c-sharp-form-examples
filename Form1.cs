namespace form_tekrar_1
{
    public partial class Form1 : Form
    {
        

     
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            for (int i = sayi1; i < sayi2; i++)
            {
                if (i%2 == 1)
                {
                    richTextBox1.Text = richTextBox1.Text + i + " ";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            for (int i = sayi1; i < sayi2; i++)
            {
                if (i % 2 == 0)
                {
                    richTextBox2.Text = richTextBox2.Text + i + " ";
                }
            }
        }

        
    }
}