using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaVize
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            linkLabel6.LinkClicked += linkLabel6_LinkClicked;
            linkLabel7.LinkClicked += linkLabel7_LinkClicked;
            linkLabel8.LinkClicked += linkLabel8_LinkClicked;
            linkLabel9.LinkClicked += linkLabel9_LinkClicked;
            linkLabel10.LinkClicked += linkLabel10_LinkClicked;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Yaşamaya Dair'i seçtiniz. Şimdi lütfen koltuk seçiminizi yapınız." , "Bilgilendirme");

            Etkinlik etkinlikForm = new Etkinlik();
            etkinlikForm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Fikri Karayel'i seçtiniz. Şimdi lütfen koltuk seçiminizi yapınız.", "Bilgilendirme");

            Etkinlik etkinlikForm = new Etkinlik();
            etkinlikForm.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Mahşer-i Cümbüş'ü seçtiniz. Şimdi lütfen koltuk seçiminizi yapınız.", "Bilgilendirme");

            Etkinlik etkinlikForm = new Etkinlik();
            etkinlikForm.Show();
            this.Hide();
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Roma'da Bir Cinayet'i seçtiniz. Şimdi lütfen koltuk seçiminizi yapınız.", "Bilgilendirme");

            Etkinlik etkinlikForm = new Etkinlik();
            etkinlikForm.Show();
            this.Hide();
        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Fazıl Say'ı seçtiniz. Şimdi lütfen koltuk seçiminizi yapınız.", "Bilgilendirme");

            Etkinlik etkinlikForm = new Etkinlik();
            etkinlikForm.Show();
            this.Hide();
        }
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Ben Rosa Luxemburg'u seçtiniz. Şimdi lütfen koltuk seçiminizi yapınız.", "Bilgilendirme");

            Etkinlik etkinlikForm = new Etkinlik();
            etkinlikForm.Show();
            this.Hide();
        }
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Lepidus Ensemble'yi seçtiniz. Şimdi lütfen koltuk seçiminizi yapınız.", "Bilgilendirme");

            Etkinlik etkinlikForm = new Etkinlik();
            etkinlikForm.Show();
            this.Hide();
        }
        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Yan Rol'ü seçtiniz. Şimdi lütfen koltuk seçiminizi yapınız.", "Bilgilendirme");

            Etkinlik etkinlikForm = new Etkinlik();
            etkinlikForm.Show();
            this.Hide();
        }
        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Orkestraikü Kronopop Gecesi'ni seçtiniz. Şimdi lütfen koltuk seçiminizi yapınız.", "Bilgilendirme");

            Etkinlik etkinlikForm = new Etkinlik();
            etkinlikForm.Show();
            this.Hide();
        }
        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("80 Günde Dünya Turu'nu seçtiniz. Şimdi lütfen koltuk seçiminizi yapınız.","Bilgilendirme");
            Etkinlik etkinlikForm = new Etkinlik();
            etkinlikForm.Show();
            this.Hide();
            
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
            private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel10_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
