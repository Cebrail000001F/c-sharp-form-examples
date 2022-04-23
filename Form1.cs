namespace form_ornegi_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //yenibir list box olusturma yöntemi
        private void button1_Click(object sender, EventArgs e)
        {
            ListBox YeniListbox=new ListBox();
            YeniListbox.Items.Add("araba");
            YeniListbox.Items.AddRange(new object[] { 5, 4, 6, 8});
            this.Controls.Add(YeniListbox);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBox YeniListbox2 = new ListBox();
            YeniListbox2.Location = new System.Drawing.Point(5, 100);        
            this.Controls.Add(YeniListbox2);
        }
    }
}