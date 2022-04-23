namespace form_örnek_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBoxBirinciSayi.Text);
            sayi2 = Convert.ToDouble(textBoxİkinciSayi.Text);
            sonuc = (sayi1 + sayi2) / 2;
            label3.Text = "Hesap sonucu: " + sonuc;
        }
  
    }   
}