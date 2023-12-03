using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Yazar> yazars = new List<Yazar>();
        List<Kitap> kitaps = new List<Kitap>();
        List<Musteri> musteris = new List<Musteri>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar();
            yazar.YazarAdi = txtyazar.Text;
            yazar.YazarDogum = dtpyazar.Value;
            yazar.Nobel = chknobel.Checked;
            yazars.Add(yazar);
            cmbyazar.Items.Add(yazar);
            cmbyazar.DisplayMember = "YazarAdi";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap kitap= new Kitap();
            kitap.KitapSayfasi = Convert.ToInt32(txtsayfa.Text);
            kitap.KitapAdi = txtkitapadi.Text;
            kitap.Fiyat=decimal.Parse(txtfiyat.Text);
            kitap.yazari = (Yazar)cmbyazar.SelectedItem;
            kitap.KitapTürü = cmbkitaptürü.SelectedItem.ToString();
            kitaps.Add(kitap);
            cmbkitap.Items.Add(kitap);
            cmbkitap.DisplayMember = "KitapAdi";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Musteriadi = txtmusteriadi.Text;
            musteri.Meslegi = txtmeslegi.Text;
            musteri.kitap = (Kitap)cmbkitap.SelectedItem;
            musteris.Add(musteri);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (Musteri musteri in musteris)
            {
                Veriler.Items.Add(musteri.Meslegi + " "+ musteri.kitap.yazari.YazarAdi +" "+ musteri.kitap.Fiyat);
            }
        }
    }
}
