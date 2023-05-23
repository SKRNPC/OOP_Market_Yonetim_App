using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_ProjeOdevi_Market
{
    public partial class Form2 : Form
    {
        List<Market> marketler;
        public Form2()
        {
            marketler = new List<Market>();
            InitializeComponent();
        }

        
        private Market marketBul(string subeAdi)
        {
            foreach (Market market in marketler)
            {
                if (market.subeAdi==subeAdi)
                {
                    return market;
                }
            }
            return null;
        }
        private void btnMarketEkle_Click(object sender, EventArgs e)
        {
            if (marketBul(textBoxSubeAdi.Text)==null)
            {
                marketler.Add(new Market(textBoxSubeAdi.Text, textBoxMarketAdres.Text));
                marketListele();
            }
            else
            {
                MessageBox.Show("Böyle bir şube kaydı mevcut.");
            }
        }
        private void marketListele()
        {
            dataGridMarket.Rows.Clear();
            comboBoxYeniSube.Items.Clear();
            comboBoxPersonelSubeSecim.Items.Clear();
            comboBoxUrunSubeSecim.Items.Clear();
            for(int i=0;i<marketler.Count;i++ )
            {
                dataGridMarket.Rows.Add();
                dataGridMarket.Rows[i].Cells[0].Value = marketler[i].subeAdi;
                dataGridMarket.Rows[i].Cells[1].Value = marketler[i].adres;
                dataGridMarket.Rows[i].Cells[2].Value = marketler[i].personeller.Count;
                dataGridMarket.Rows[i].Cells[3].Value = marketler[i].urunler.Count;
                comboBoxPersonelSubeSecim.Items.Add(marketler[i].subeAdi);
                comboBoxYeniSube.Items.Add(marketler[i].subeAdi);
                comboBoxUrunSubeSecim.Items.Add(marketler[i].subeAdi);
            }
        }
        private void personelListele()
        {
            dataGridViewPersonel.Rows.Clear();
            comboBoxIslemPersonel.Items.Clear();
            Market secilenMarket = marketBul(comboBoxPersonelSubeSecim.Text);
            if (secilenMarket!=null)
            {
                for (int i = 0; i < secilenMarket.personeller.Count; i++)
                {
                    dataGridViewPersonel.Rows.Add();
                    dataGridViewPersonel.Rows[i].Cells[0].Value = secilenMarket.personeller[i].adSoyad;
                    dataGridViewPersonel.Rows[i].Cells[1].Value = secilenMarket.personeller[i].pozisyon;
                    dataGridViewPersonel.Rows[i].Cells[2].Value = secilenMarket.personeller[i].maas+"₺";
                    dataGridViewPersonel.Rows[i].Cells[3].Value = secilenMarket.personeller[i].adres;
                    dataGridViewPersonel.Rows[i].Cells[4].Value = secilenMarket.personeller[i].kullanilanIzin;
                    dataGridViewPersonel.Rows[i].Cells[5].Value = secilenMarket.personeller[i].kalanYillikIzin;
                    comboBoxIslemPersonel.Items.Add(secilenMarket.personeller[i].adSoyad);
                }
            }
        }
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (comboBoxPersonelSubeSecim.Text != "")
            {
                if (textBoxPersonelAdres.Text != "")
                {
                    marketBul(comboBoxPersonelSubeSecim.Text).personeller.Add(new Personel(textBoxAdSoyad.Text, comboBoxPozisyon.Text, int.Parse(textBoxMaas.Text), textBoxPersonelAdres.Text));
                    MessageBox.Show("Personel kaydı başarılı.");
                    personelListele();
                }
                else MessageBox.Show("Personel adresi boş bırakılamaz!");
            }
            else MessageBox.Show("Şube seçiniz.");
            personelListele();

        }
        private Personel personelAra(string adSoyad)
        {
            Market secilenMarket = marketBul(comboBoxPersonelSubeSecim.Text);
            if (secilenMarket!=null)
            {
                foreach (Personel personel in secilenMarket.personeller)
                {
                    if (personel.adSoyad==adSoyad)
                    {
                        return personel;
                    }
                }
            }
            return null;
        }
        private void btnSubeDgstr_Click(object sender, EventArgs e)
        {
            if (personelAra(comboBoxIslemPersonel.Text) != null)
            {
                if (marketBul(comboBoxPersonelSubeSecim.Text) != null && marketBul(comboBoxYeniSube.Text) != null)
                {
                    marketBul(comboBoxYeniSube.Text).personeller.Add(personelAra(comboBoxIslemPersonel.Text));
                    marketBul(comboBoxPersonelSubeSecim.Text).personeller.Remove(personelAra(comboBoxIslemPersonel.Text));
                    personelListele();
                    MessageBox.Show("Transfer başarılı.");
                }
                else MessageBox.Show("Şube seçimleri geçersiz");
            }
            else MessageBox.Show("Personel seçiniz.");
        }

        private void btnZam_Click(object sender, EventArgs e)
        {
            int yeniMaas = int.Parse(textBoxZamMiktar.Text);
            if (personelAra(comboBoxIslemPersonel.Text) != null)
            {
                if (personelAra(comboBoxIslemPersonel.Text).maas < yeniMaas)
                {
                    personelAra(comboBoxIslemPersonel.Text).maas = yeniMaas;
                    MessageBox.Show("Zam işlemi başarılı.");
                    personelListele();
                }
                else MessageBox.Show("Sadece zam yapılabilir.");
            }
            else MessageBox.Show("Personel seçiniz.");
        }

        private void comboBoxPersonelSubeSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            personelListele();
        }

        private void btnTerfi_Click(object sender, EventArgs e)
        {
            if (personelAra(comboBoxIslemPersonel.Text) != null)
            {
                if (personelAra(comboBoxIslemPersonel.Text).pozisyon == "Kasiyer")
                {
                    personelAra(comboBoxIslemPersonel.Text).pozisyon = "Müdür Yardımcısı";
                    MessageBox.Show("Terfi işlemi başarılı.");
                    personelListele();
                }
                else if (personelAra(comboBoxIslemPersonel.Text).pozisyon == "Müdür Yardımcısı")
                {
                    personelAra(comboBoxIslemPersonel.Text).pozisyon = "Müdür";
                    MessageBox.Show("Terfi işlemi başarılı.");
                    personelListele();
                }
                else MessageBox.Show("Daha fazla terfi yapılamaz.");
            }
            else MessageBox.Show("Personel seçiniz.");
        }

        private void btnYillik_Click(object sender, EventArgs e)
        {
            if (personelAra(comboBoxIslemPersonel.Text) != null)
            {
                if (personelAra(comboBoxIslemPersonel.Text).kalanYillikIzin>0)
                {
                    personelAra(comboBoxIslemPersonel.Text).kalanYillikIzin--;
                    MessageBox.Show("Yıllık izin kullanma işlemi başarılı.");
                    personelListele();
                }
                else MessageBox.Show("Personelin bu yıl başka izin hakkı yok.");
            }
            else MessageBox.Show("Personel seçiniz.");
        }

        private void btnIzin_Click(object sender, EventArgs e)
        {
            if (personelAra(comboBoxIslemPersonel.Text) != null)
            {
                personelAra(comboBoxIslemPersonel.Text).kullanilanIzin++;
                MessageBox.Show("Izin kullanma işlemi başarılı.");
                personelListele();
            }
            else MessageBox.Show("Personel seçiniz.");
        }

        private void btnTedarik_Click(object sender, EventArgs e)
        {
            if (marketBul(comboBoxUrunSubeSecim.Text) != null)
            {
                marketBul(comboBoxUrunSubeSecim.Text).tedarikciler.Add(new Tedarikci(textBoxYeniKategori.Text, textBoxTedarikciAdres.Text));
                urunListele();
                MessageBox.Show("Tedarikçi sisteme kaydedildi.");
            }
            else MessageBox.Show("Şube seçiniz.");
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (comboBoxUrunKategori.Text != "")
            {
                marketBul(comboBoxUrunSubeSecim.Text).urunler.Add(new Urun(textBoxUrunAdi.Text, comboBoxUrunKategori.Text, double.Parse(textBoxUrunFiyat.Text), int.Parse(textBoxUrunStok.Text)));
                MessageBox.Show("Ürün kaydı eklendi");
                urunListele();
            }
            else MessageBox.Show("Kategori seçiniz.");
        }
        
        private void urunListele()
        {
            if (marketBul(comboBoxUrunSubeSecim.Text)!=null)
            {
                Market secilenMarket = marketBul(comboBoxUrunSubeSecim.Text);
                comboBoxIndirimKategori.Items.Clear();
                comboBoxUrunKategori.Items.Clear();
                foreach (Tedarikci tedarikci in secilenMarket.tedarikciler)
                {
                    comboBoxIndirimKategori.Items.Add(tedarikci.urunKategori);
                    comboBoxUrunKategori.Items.Add(tedarikci.urunKategori);
                }
                dataGridViewUrunler.Rows.Clear();
                for (int i = 0; i < secilenMarket.urunler.Count; i++)
                {
                    dataGridViewUrunler.Rows.Add();
                    dataGridViewUrunler.Rows[i].Cells[0].Value = secilenMarket.urunler[i].urunAdi;
                    dataGridViewUrunler.Rows[i].Cells[1].Value = secilenMarket.urunler[i].kategori;
                    dataGridViewUrunler.Rows[i].Cells[2].Value = secilenMarket.urunler[i].fiyat+"₺";
                    dataGridViewUrunler.Rows[i].Cells[3].Value = secilenMarket.urunler[i].stok;
                    dataGridViewUrunler.Rows[i].Cells[4].Value = secilenMarket.urunler[i].sonIndirimTarihi;
                }
            }
        }
        private void comboBoxUrunSubeSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            urunListele();
        }

        private void btnIndirim_Click(object sender, EventArgs e)
        {
            if (comboBoxIndirimKategori.Text != "")
            {
                int indirimOrani = int.Parse(textBoxIndirimOrani.Text);
                foreach (Urun urun in marketBul(comboBoxUrunSubeSecim.Text).urunler)
                {
                    if (urun.kategori == comboBoxIndirimKategori.Text)
                    {
                        urun.fiyat = urun.fiyat - ((urun.fiyat * indirimOrani) / 100);
                        urun.sonIndirimTarihi = DateTime.Now;
                    }
                }
                MessageBox.Show("İndirim uygulandı.");
                urunListele();
            }
            else MessageBox.Show("Kategori seçiniz.");
        }

        private void dataGridMarket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            urunListele();
        }
    }
}
