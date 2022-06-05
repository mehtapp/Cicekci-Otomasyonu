using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CicekciProje4
{
    public partial class Raporlar : Form
    {
        Model1Container cicekci = new Model1Container();
        public Raporlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label11.Text = cicekci.musteriSet.Count(m => m.MusAdres).ToString();
            lbl_topMusSay.Text = cicekci.SiparisSet.Sum(m => m.Tutar).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl_enPahUrun.Text = cicekci.UrunSet.Max(m => m.UrunFiyat).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sorgu = from urun1 in cicekci.UrunSet
                        join siparis1 in cicekci.SiparisSet on urun1.Urun_id equals
siparis1.Urun_id join musteri1 in cicekci.musteriSet on siparis1.mus_id equals musteri1.Mus_id
                        select new
                        {

                            urun1.Urun_id,
                            urun1.UrunAd,
                            urun1.UrunFiyat,
                            musteri1.MusteriAd,
                            musteri1.MusAdres,
                            siparis1.Sip_id,
                            siparis1.SipAdres
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }


        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sorgu = from urun1 in cicekci.UrunSet
                        join siparis1 in cicekci.SiparisSet on
urun1.Urun_id equals siparis1.Urun_id
                        join musteri1 in cicekci.musteriSet on
siparis1.mus_id equals musteri1.Mus_id where siparis1.SipAdres == "Ümraniye" || siparis1.SipAdres == "ümraniye"
                        select new
                        {
                            musteri1.MusteriAd,
                            siparis1.SipAdres,
                            urun1.UrunAd,
                            urun1.UrunFiyat,
                            siparis1.Adet,
                            siparis1.Tutar

                        };
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbl_topSipSay.Text = cicekci.SiparisSet.Count().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblOrtUrunFiyat.Text = cicekci.UrunSet.Average(u => u.UrunFiyat).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var sorgu = from siparis1 in cicekci.SiparisSet join musteri1 in cicekci.musteriSet 
                        on siparis1.mus_id equals musteri1.Mus_id
                        group musteri1 by musteri1.MusteriAd into grup
                        select new
                        {
                            MüşteriAd = grup.Key,
                            
                            SiparişAdet = grup.Count()
                         };
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cicekci.musteriSet.OrderByDescending(m => m.Mus_id).Take(5).ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var sorgu = from urun1 in cicekci.UrunSet
                        where urun1.UrunAd.Contains("papatya")
                        select new
                        {
                            urun1.Urun_id,
                            urun1.UrunAd,
                            urun1.UrunFiyat

                        };
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            //Önemli Eşleşmeyen Veriler için kullandım. 1.tabloda olup 2. tabloda eşleşen karşılığı olmmayan
            // yani hiç sipariş edilmeyen ürünler 
            dataGridView1.DataSource = cicekci.UrunSet.Where(p => !cicekci.SiparisSet.Select(i => i.Urun_id).Contains(p.Urun_id)).ToList() ;

        }



    }
}
