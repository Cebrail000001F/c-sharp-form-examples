namespace form_ders_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("bmw");
            listBox1.Items.Add("Wv");
            listBox1.Items.Add("Audi");
            listBox1.Items.Add("mercedes");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "defter + kitap  " + "kalem"+ "cizgi" + "kare";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        
    }
}