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
    public partial class Siparisler : Form
    {
        Model1Container cicekci = new Model1Container();
        public Siparisler()
        {
            InitializeComponent();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            SipListele();
        }
        public void SipListele()
        {
            //dataGridView1.DataSource = cicekci.SiparisSet.ToList() ;
            var sorgu= from mus in cicekci.musteriSet join sip1 in cicekci.SiparisSet on
                       mus.Mus_id equals sip1.mus_id join urun1 in cicekci.UrunSet on sip1.Urun_id 
                       equals urun1.Urun_id
                       select new
                       {
                           mus.MusteriAd,
                           sip1.Sip_id,
                           urun1.UrunAd,
                           sip1.SipAdres,
                           sip1.Adet,
                           sip1.Tutar
                           //sip1.mus_id,
                           //sip1.Urun_id
                       };
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Siparis sip1 = new Siparis();
            sip1.SipAdres= txt_SipAdres.Text;
            sip1.Adet = Convert.ToInt32(txt_Adet.Text);
            sip1.Tutar = Convert.ToInt32(txtTutar.Text);
            sip1.mus_id = Convert.ToInt32(cb_musNo.SelectedValue);
            sip1.Urun_id= Convert.ToInt32(cb_urunNo.SelectedValue);
            cicekci.SiparisSet.Add(sip1);
            cicekci.SaveChanges();
            SipListele();
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            cb_musNo.DataSource= cicekci.musteriSet.ToList();
            cb_musNo.ValueMember = "Mus_id";
            cb_musNo.DisplayMember = "MusteriAd";
            cb_urunNo.DataSource = cicekci.UrunSet.ToList();
            cb_urunNo.ValueMember = "Urun_id";
            cb_urunNo.DisplayMember = "UrunAd";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txt_SipAdres.Tag = satir.Cells["Sip_id"].Value.ToString();
            txt_SipAdres.Text = satir.Cells["SipAdres"].Value.ToString();
            txt_Adet.Text= satir.Cells["Adet"].Value.ToString();
            txtTutar.Text = satir.Cells["Tutar"].Value.ToString();
            cb_musNo.Text = satir.Cells["MusteriAd"].Value.ToString();
            //cb_musNo.Tag= satir.Cells["mus_id"].Value.ToString();
            //cb_urunNo.Tag = satir.Cells["Urun_id"].Value.ToString();
            cb_urunNo.Text = satir.Cells["UrunAd"].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_SipAdres.Tag);
            Siparis sip1 = cicekci.SiparisSet.SingleOrDefault(c => c.Sip_id == id);
            
            sip1.SipAdres = txt_SipAdres.Text;
            sip1.Adet = Convert.ToInt32(txt_Adet.Text);
            sip1.Tutar = Convert.ToInt32(txtTutar.Text);
            sip1.mus_id = Convert.ToInt32(cb_musNo.SelectedValue);
            sip1.Urun_id = Convert.ToInt32(cb_urunNo.SelectedValue);
            cicekci.SaveChanges();
            SipListele();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int sip_id = Convert.ToInt32(txt_SipAdres.Tag);
            Siparis sip1 = cicekci.SiparisSet.SingleOrDefault(c => c.Sip_id == sip_id);
            cicekci.SiparisSet.Remove(sip1);
            cicekci.SaveChanges();
            SipListele();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int musId = Convert.ToInt32(cb_musNo.SelectedValue);
            int urunId= Convert.ToInt32(cb_urunNo.SelectedValue);
            dataGridView1.DataSource = cicekci.SiparisSet.Where(s => s.mus_id == musId && s.Urun_id == urunId).ToList() ;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
