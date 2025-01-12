using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, yanlısSayisi = 0, dogruSayisi = 0, saniye = 0;
        string DogruCevap;
       

        private void buttonAktiflestirme()
        {
            Abutton.Enabled = true;
            Bbutton.Enabled = true;
            Cbutton.Enabled = true;
            Dbutton.Enabled = true;
            sorugetirButton.Enabled = false;
        }
        private void buttonDeAktiflestirme()
        {
            Abutton.Enabled = false;
            Bbutton.Enabled = false;
            Cbutton.Enabled = false;
            Dbutton.Enabled = false;
            sorugetirButton.Enabled = true;
        }
        private void Abutton_Click(object sender, EventArgs e)
        {
            yanlisPictureBox.Visible = false;
            dogruPictureBox.Visible = false;
            if (DogruCevap == Abutton.Text)
            {
                dogruSayisi++;
                dogruSayisiLabel.Text = dogruSayisi.ToString();
                dogruPictureBox.Visible = true;
            }
            else
            {
                yanlısSayisi++;
                yanlısSayisiLabel.Text = yanlısSayisi.ToString();
                yanlisPictureBox.Visible = true;
            }
            buttonDeAktiflestirme();
        }
        private void Bbutton_Click(object sender, EventArgs e)
        {
            yanlisPictureBox.Visible = false;
            dogruPictureBox.Visible = false;

            if (DogruCevap == Bbutton.Text)
            {
                dogruSayisi++;
                dogruSayisiLabel.Text = dogruSayisi.ToString();
                dogruPictureBox.Visible = true;
            }
            else
            {
                yanlısSayisi++;
                yanlısSayisiLabel.Text = yanlısSayisi.ToString();
                yanlisPictureBox.Visible = true;
            }
            buttonDeAktiflestirme();
        }
        private void Cbutton_Click(object sender, EventArgs e)
        {
            yanlisPictureBox.Visible = false;
            dogruPictureBox.Visible = false;

            if (DogruCevap == Cbutton.Text)
            {
                dogruSayisi++;
                dogruSayisiLabel.Text = dogruSayisi.ToString();
                dogruPictureBox.Visible = true;
            }
            else
            {
                yanlısSayisi++;
                yanlısSayisiLabel.Text = yanlısSayisi.ToString();
                yanlisPictureBox.Visible = true;
            }
            buttonDeAktiflestirme();  
        }
        
        private void Dbutton_Click(object sender, EventArgs e)
        {
            yanlisPictureBox.Visible = false;
            dogruPictureBox.Visible = false;

            if (DogruCevap == Dbutton.Text)
            {
                dogruSayisi++;
                dogruSayisiLabel.Text = dogruSayisi.ToString();
                dogruPictureBox.Visible = true;
            }
            else
            {
                yanlısSayisi++;
                yanlısSayisiLabel.Text = yanlısSayisi.ToString();
                yanlisPictureBox.Visible = true;
            }
            buttonDeAktiflestirme();
         }
       
        private void harcananSureTimer_Tick(object sender, EventArgs e)
        {
            saniye++;
            harcananSureSayisiLabel.Text = saniye.ToString();
        }
        private void sorugetirButton_Click(object sender, EventArgs e)
        {
            soruNo++; 
            buttonAktiflestirme();
            yanlisPictureBox.Visible = false;
            dogruPictureBox.Visible = false;

            if (soruNo == 1)
            {
                richTextBox1.Text = "şubat ayı kaç yılda bir 29 çeker ?";
                Abutton.Text = "5";
                Bbutton.Text = "3";
                Cbutton.Text = "4";
                Dbutton.Text = "6";
                DogruCevap = "4";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "üçgenin iç açıları toplamı kaçtır ?";
                Abutton.Text = "180";
                Bbutton.Text = "200";
                Cbutton.Text = "90";
                Dbutton.Text = "60";
                DogruCevap = "180";
    
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "bir voleybol maçında toplam kaç kişi oynar ?";
                Abutton.Text = "17";
                Bbutton.Text = "10";
                Cbutton.Text = "16";
                Dbutton.Text = "12";
                DogruCevap = "12";
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "türkiye 2020 olimpiyatlarında kaç tane altın madalya kazandı ?";
                Abutton.Text = "6";
                Bbutton.Text = "7";
                Cbutton.Text = "8";
                Dbutton.Text = "9";
                DogruCevap = "6";
            }
            if (soruNo == 5)
            {
                buttonDeAktiflestirme();
                sorugetirButton.Enabled = false;//soru sayısını aştığımda soru getir butonunu kapattırdım
            }
        }
    }
}
