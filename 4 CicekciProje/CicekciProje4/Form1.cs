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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_urun_Click(object sender, EventArgs e)
        {
            UrunS urunN = new UrunS();
            urunN.Show();
            this.Hide();
        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            Musteriler mus = new Musteriler();
            mus.Show();
            this.Hide();

        }

        private void btn_sip_Click(object sender, EventArgs e)
        {
            Siparisler sip = new Siparisler();
            sip.Show();
            this.Hide();

        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            Raporlar rap = new Raporlar();
            rap.Show();
            this.Hide();
        }
    }
}
