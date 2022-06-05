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
    public partial class UrunS : Form
    {
        Model1Container cicekci= new Model1Container();
        public UrunS()
        {
            InitializeComponent();
        }

        public void UrunList()
        {
            dataGridView1.DataSource = cicekci.UrunSet.ToList();
        }
        private void UrunS_Load(object sender, EventArgs e)
        {

        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            UrunList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Urun u1 = new Urun();
            u1.UrunAd = txt_urunAd.Text;
            u1.UrunFiyat = Convert.ToInt32(txt_fiyat.Text);
            cicekci.UrunSet.Add(u1);
            cicekci.SaveChanges();
            UrunList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txt_urunAd.Tag);
            Urun u1 = cicekci.UrunSet.SingleOrDefault(c => c.Urun_id == id);
            u1.UrunAd = txt_urunAd.Text;
            u1.UrunFiyat = Convert.ToInt32(txt_fiyat.Text);
            cicekci.SaveChanges();
            UrunList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txt_urunAd.Tag = satir.Cells["Urun_id"].Value.ToString();
            txt_urunAd.Text = satir.Cells["UrunAd"].Value.ToString();
            txt_fiyat.Text = satir.Cells["UrunFiyat"].Value.ToString();

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_urunAd.Tag);
            Urun u1 = cicekci.UrunSet.SingleOrDefault(c => c.Urun_id == id);
            cicekci.UrunSet.Remove(u1);
            cicekci.SaveChanges();
            UrunList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = cicekci.UrunSet.Where(c => c.UrunAd.ToLower().Contains(txt_urunAd.Text) || 
            c.UrunAd.ToUpper().Contains(txt_urunAd.Text)).ToList();
            
            //dataGridView1.DataSource = cicekci.UrunSet.SingleOrDefault(c => c.UrunAd ==);

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }
    }
}
