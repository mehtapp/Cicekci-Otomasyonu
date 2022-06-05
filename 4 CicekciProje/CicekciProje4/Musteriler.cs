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
    public partial class Musteriler : Form
    {
        Model1Container cicekci= new Model1Container();
        public Musteriler()
        {
            InitializeComponent();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            MusList();
        }
        public void MusList()
        {
            dataGridView1.DataSource = cicekci.musteriSet.ToList();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            musteri mus1= new musteri();
            mus1.MusteriAd = txt_MusAdSoyad.Text;
            mus1.MusAdres = txt_Adres.Text;
            mus1.MusTel = txtTel.Text;
            cicekci.musteriSet.Add(mus1);
            cicekci.SaveChanges();
            MusList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_MusAdSoyad.Tag);
            musteri mus1 = cicekci.musteriSet.SingleOrDefault(c => c.Mus_id == id);
           
            mus1.MusteriAd = txt_MusAdSoyad.Text;
            mus1.MusTel= txtTel.Text;
            mus1.MusAdres= txt_Adres.Text;
            cicekci.SaveChanges();
            MusList();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_MusAdSoyad.Tag);
            musteri mus1 = cicekci.musteriSet.SingleOrDefault(c => c.Mus_id== id);
            cicekci.musteriSet.Remove(mus1);
            cicekci.SaveChanges();
            MusList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txt_MusAdSoyad.Tag = satir.Cells["Mus_id"].Value.ToString();
            txt_MusAdSoyad.Text = satir.Cells["MusteriAd"].Value.ToString();
            txtTel.Text = satir.Cells["MusTel"].Value.ToString();
            txt_Adres.Text = satir.Cells["MusAdres"].Value.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cicekci.musteriSet.Where(m => m.MusteriAd.ToLower().Contains(txt_MusAdSoyad.Text) ||
             m.MusteriAd.ToUpper().Contains(txt_MusAdSoyad.Text)).ToList();
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
    }
}
