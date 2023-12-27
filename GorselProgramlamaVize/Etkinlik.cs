using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GorselProgramlamaVize
{
    public partial class Etkinlik : Form
    {
        private int toplamDeger = 0;
        private List<string> sabitRezerveKoltuklar = new List<string> { "A8", "A9", "A10", "A11", "A12", "A13", "B3", "B4", "B7", "B8", "B9", "B15", "B16", "C9", "C10", "C11", "C12", "C15", "C17", "D1", "D2", "D4", "D5", "D7", "D8", "D9", "D10", "D11", "D14", "D15", "E1", "E3", "E4", "E5", "E7", "E8", "E9", "E10", "E11", "E12", "E13", "E14", "F3", "F4", "F5", "F8", "F9", "G2", "G3", "G4", "G5", "G6", "G10", "G11", "G12", "G13" };
        private List<string> secilenKoltuklar = new List<string>();

        public Etkinlik()
        {
            InitializeComponent();
        }

        private void Etkinlik_Load(object sender, EventArgs e)
        {
            foreach (Control control in panel2.Controls)
            {
                if (control is System.Windows.Forms.Button)
                {
                    ((System.Windows.Forms.Button)control).Click += Button_Click;
                }
            }
            LnkRezervasyon.LinkClicked += LnkRezervasyon_LinkClicked;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            string buttonText = clickedButton.Text;

            if (sabitRezerveKoltuklar.Contains(buttonText))
            {
                MessageBox.Show("Bu koltuk rezerve edilmiştir, lütfen boş koltuklardan seçim yapınız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (secilenKoltuklar.Contains(buttonText))
                {
                    clickedButton.BackColor = Color.FromArgb(238, 147, 64);
                    clickedButton.ForeColor = Color.FromArgb(15, 15, 15);
                    secilenKoltuklar.Remove(buttonText);

                    toplamDeger -= 500;
                }
                else
                {
                    clickedButton.BackColor = Color.FromArgb(33, 156, 144);
                    clickedButton.ForeColor = Color.FromArgb(255, 255, 255);
                    secilenKoltuklar.Add(buttonText);

                    toplamDeger += 500;
                }

                textBox2.Text = string.Join(", ", secilenKoltuklar);
                textBox1.Text = toplamDeger.ToString("C");
            }
        }

        private void LnkRezervasyon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string isim = textBox3.Text;
            string rezerve = textBox2.Text;

            if (string.IsNullOrWhiteSpace(isim))
            {
                MessageBox.Show("Lütfen isminizi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(rezerve))
            {
                MessageBox.Show("Lütfen koltuk seçiminizi yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kullaniciAdi = textBox3.Text;
            string rezerveEdilenKoltuklar = textBox2.Text;
            string rezervasyonBilgisi = $"Sayın {kullaniciAdi}, {rezerveEdilenKoltuklar} numaralı koltuklar için rezervasyonunuz oluşturulmuştur!";

            DialogResult result = MessageBox.Show(rezervasyonBilgisi, "Rezervasyon Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void Etkinlik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void C12_Click(object sender, EventArgs e)
        {

        }

        private void F8_Click(object sender, EventArgs e)
        {

        }

        private void F5_Click(object sender, EventArgs e)
        {

        }

        private void F4_Click(object sender, EventArgs e)
        {

        }

        private void F3_Click(object sender, EventArgs e)
        {

        }

        private void E14_Click(object sender, EventArgs e)
        {

        }

        private void E13_Click(object sender, EventArgs e)
        {

        }

        private void E12_Click(object sender, EventArgs e)
        {

        }

        private void E11_Click(object sender, EventArgs e)
        {

        }

        private void E10_Click(object sender, EventArgs e)
        {

        }

        private void E8_Click(object sender, EventArgs e)
        {

        }

        private void E7_Click(object sender, EventArgs e)
        {

        }

        private void E5_Click(object sender, EventArgs e)
        {

        }

        private void E4_Click(object sender, EventArgs e)
        {

        }

        private void E3_Click(object sender, EventArgs e)
        {

        }

        private void E1_Click(object sender, EventArgs e)
        {

        }

        private void D15_Click(object sender, EventArgs e)
        {

        }

        private void D14_Click(object sender, EventArgs e)
        {

        }

        private void D11_Click(object sender, EventArgs e)
        {

        }

        private void D10_Click(object sender, EventArgs e)
        {

        }

        private void D9_Click(object sender, EventArgs e)
        {

        }

        private void D8_Click(object sender, EventArgs e)
        {

        }

        private void D7_Click(object sender, EventArgs e)
        {

        }

        private void D5_Click(object sender, EventArgs e)
        {

        }

        private void D4_Click(object sender, EventArgs e)
        {

        }

        private void D2_Click(object sender, EventArgs e)
        {

        }

        private void D1_Click(object sender, EventArgs e)
        {

        }

        private void F9_Click(object sender, EventArgs e)
        {

        }

        private void C15_Click(object sender, EventArgs e)
        {

        }

        private void C17_Click(object sender, EventArgs e)
        {

        }

        private void C11_Click(object sender, EventArgs e)
        {

        }

        private void C10_Click(object sender, EventArgs e)
        {

        }

        private void C9_Click(object sender, EventArgs e)
        {

        }

        private void B16_Click(object sender, EventArgs e)
        {

        }

        private void B15_Click(object sender, EventArgs e)
        {

        }

        private void B9_Click(object sender, EventArgs e)
        {

        }

        private void B8_Click(object sender, EventArgs e)
        {

        }

        private void B4_Click(object sender, EventArgs e)
        {

        }

        private void B3_Click(object sender, EventArgs e)
        {

        }

        private void A13_Click(object sender, EventArgs e)
        {

        }

        private void A12_Click(object sender, EventArgs e)
        {

        }

        private void A11_Click(object sender, EventArgs e)
        {

        }

        private void A10_Click(object sender, EventArgs e)
        {

        }

        private void A9_Click(object sender, EventArgs e)
        {

        }

        private void A8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void E9_Click(object sender, EventArgs e)
        {

        }
    }
}
