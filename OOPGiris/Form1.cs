using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home evSnf = new Home();
            evSnf.metreKare = 120;
            evSnf.odaSayisi = 4;
            evSnf.renk = "kirmizi";
            evSnf.yakit = 'E';
            /*

            label1.Text = "Renk " + evSnf.renk;
            label2.Text = "Oda Sayisi: " + evSnf.odaSayisi;
            label3.Text = "MetreKare: " + evSnf.metreKare;
            label4.Text = "Yakilan yakit: " + evSnf.yakit;
            */
            Notlar not1 = new Notlar();
            
            not1.sinav1 = Convert.ToInt32(textBox3.Text);
            not1.sinav2 = Convert.ToInt32(textBox4.Text);

            not1.ortalama = (not1.sinav1 + not1.sinav2) / 2;

            Ogrenciler ogrenci1 = new Ogrenciler();
            //ogrenci1.ad = textBox1.Text; --Private oldugu icin hata verir.
            ogrenci1.AD = textBox1.Text;
            //ogrenci1.soyad = textBox2.Text; --Private oldugu icin hata verir.
            ogrenci1.SOYAD = textBox2.Text;

            listView1.Items.Add("Ogrencinin Adi: "+ ogrenci1.AD +"Ogrencinin Soyadi: "+ogrenci1.SOYAD +"Sinav1: "+not1.sinav1+ " Sinav2: "+not1.sinav2+ " Ortalama: "+not1.ortalama);
            Test test = new Test();
        }
        class Home
        {
            public int metreKare;
            public int odaSayisi;
            public string renk;
            public char yakit;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text;
            string ses;
            //Papagan ppgn = new Papagan();
            Kanarya kanarya = new Kanarya();
            kanarya.ad = "Rifki";
            kanarya.tur = "kanarya";
            kanarya.ayak = Convert.ToInt32(textBox1.Text);
            kanarya.renk = textBox2.Text;
            kanarya.ucabiliyorMu = Convert.ToBoolean(textBox4.Text);
            ses = kanarya.sesCikart(textBox3.Text);
            if (kanarya.ucabiliyorMu)
            {
                text = "Ucabilir";
            }
            else
            {
                text = "Ucamaz";
            }

            listView1.Items.Add("Kusun turu: " + kanarya.tur 
                + "Kusun adi: " +
                kanarya.ad + "Kusun rengi: " 
                + kanarya.renk 
                + "Bu Kus turu ucabiliyor mu? "
                + text + "Cikardigi Ses: "+ ses);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
