namespace form_ornegi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button yeniButton = new Button();
            yeniButton.Text = "Yeni";
            yeniButton.Location = new Point(100, 100);
            yeniButton.Size = new Size(50,50);
            yeniButton.BackColor = Color.Red;
            this.Controls.Add(yeniButton);
        }
    }
}