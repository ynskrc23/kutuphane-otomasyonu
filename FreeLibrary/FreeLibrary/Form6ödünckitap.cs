using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeLibrary
{
    public partial class Form6ödünckitap : Form
    {
        public Form6ödünckitap()
        {
            InitializeComponent();
        }
        KütüphaneEntities3 db = new KütüphaneEntities3();

        private void Form6ödünckitap_Load(object sender, EventArgs e)
        {
            cmbxüye.DataSource = db.Üye_Ekleme.ToList();
            cmbxüye.ValueMember = "Id";
            cmbxüye.DisplayMember = "İsim";

            cmbxktpad.DataSource = db.Kitap_Eklemes.ToList();
            cmbxktpad.ValueMember = "Id";
            cmbxktpad.DisplayMember = "Kitabın_Adı";
        }
        private void btnkydet_Click(object sender, EventArgs e)
        {
            Ödünç_Kitap_Verme m = new Ödünç_Kitap_Verme();
            m.Üye_Adı = cmbxüye.Text;
            m.Kitabın_Adı = cmbxktpad.Text;
            m.Veriliş_Tarihi = dateverilis.Value;
            m.Kitabı_Veren = cmbxveren.Text;
            m.Geri_Geldimi = cmbxgeri.Text;
            m.Geliş_Tarihi = dategeliş.Value;
            m.Teslim_Alan = cmbxteslim.Text;
            db.Ödünç_Kitap_Verme.Add(m);
            db.SaveChanges();
            MessageBox.Show("Bilgileriniz Başarılı Şekilde Kaydedildi....");
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Form3anamenü frm = new Form3anamenü();
            frm.Show();
            this.Hide();
        }
    }
}
