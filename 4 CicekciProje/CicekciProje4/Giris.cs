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
    public partial class Giris : Form
    {
        Model1Container cicekci= new Model1Container();

        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool girisİslemi =cicekci.kullaniciSet.Any(k => k.kulAd == log_username.Text && k.kulSifre == log_password.Text);
            if (girisİslemi)
            {
                Form1 anasayfa = new Form1();
                anasayfa.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Kullanıcı adı yada şifre hatalı. Tekrar Deneyiniz.");
                
            }
            log_username.Clear();
            log_password.Clear();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            try
            {
                kullanici yenikullanici = new kullanici();
                yenikullanici.kulAd = txt_userName.Text;
                bool kontrol= cicekci.kullaniciSet.Any(k => k.kulAd == txt_userName.Text);
                yenikullanici.kulSifre = txtPssword.Text;
                
               
                if (kontrol)
                {
                    MessageBox.Show("Bu kullanıcı adı alınmış. Başka bir kullanıcı adı seçiniz.");
                }
                else
                {
                    MessageBox.Show("Giriş yapabilirsin.", "Yardım", MessageBoxButtons.OK);
                    cicekci.kullaniciSet.Add(yenikullanici);
                    cicekci.SaveChanges();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex + " Hata oluştu. Sorunu çözüp tekrar deneyebilirsin.");
            }
        }

        private void btnKaydaGit_Click(object sender, EventArgs e)
        {
            gBox_KayitOl.Visible = true;
            gBoxGirisYap.Visible = false;
        }

        private void btn_GiriseGit_Click(object sender, EventArgs e)
        {
            gBoxGirisYap.Visible = true;
            gBox_KayitOl.Visible = false;
        }
    }
}
