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
    public partial class Form5kitapekleme : Form
    {
        public Form5kitapekleme()
        {
            InitializeComponent();
        }
        KütüphaneEntities3 db = new KütüphaneEntities3();
        private void btnkydet_Click(object sender, EventArgs e)
        {
            Kitap_Ekleme m = new Kitap_Ekleme();
            m.Kitabın_Adı = txtktpad.Text;
            m.Kitabın_Yazarı = txtktpyazar.Text;
            m.Yayın_Evi = txtyayın.Text;
            m.Kitabın_Türü = cmbxktptür.Text;
            m.Basım_Tarihi = datebasım.Value;
            m.Sayfa_Sayısı = Convert.ToInt16(txtsayfa.Text);
            m.Raf_Sırası = cmbxraf.Text;
            db.Kitap_Eklemes.Add(m);
            db.SaveChanges();
            MessageBox.Show("Bilgileriniz Başarılı Şekilde Kaydedildi....");
           
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtktpad.Clear();
            txtktpyazar.Clear();
            txtsayfa.Clear();
            txtyayın.Clear();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Form3anamenü frm = new Form3anamenü();
            frm.Show();
            this.Hide();
        }
    }
}
