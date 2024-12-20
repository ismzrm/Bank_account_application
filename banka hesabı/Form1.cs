using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace banka_hesabı
{
    public partial class Form1 : Form
    {
        private BankaHesabi hesap;
        public Form1()
        {
            InitializeComponent();
            hesap = new BankaHesabi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bakiyeniz: " + hesap.Bakiye.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal miktar;
            if (decimal.TryParse(textBox1.Text, out miktar))
            {
                if (miktar > 0)
                {
                    hesap.ParaYatir(miktar);
                    MessageBox.Show(miktar + " TL başarıyla yatırıldı.");
                    label1.Text = "Bakiyeniz: " + hesap.Bakiye.ToString() + " TL";
                }
                else
                {
                    MessageBox.Show("Geçerli bir miktar girin.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.");
            }
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal miktar;
            if (decimal.TryParse(textBox1.Text, out miktar))
            {
                if (miktar > 0)
                {
                    if (hesap.ParaCek(miktar))
                    {
                        MessageBox.Show(miktar + " TL başarıyla çekildi.");
                        label1.Text = "Bakiyeniz: " + hesap.Bakiye.ToString() + " TL";
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye!");
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir miktar girin.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.");
            }
            textBox1.Text = "";

        }
    
    }
}
