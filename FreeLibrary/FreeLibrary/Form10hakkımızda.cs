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
    public partial class Form10hakkımızda : Form
    {
        public Form10hakkımızda()
        {
            InitializeComponent();
        }

        KütüphaneEntities3 db = new KütüphaneEntities3();
        private void Form10hakkımızda_Load(object sender, EventArgs e)
        {
          
        }

        private void pcbxkyadet_Click(object sender, EventArgs e)
        {
            Ayarlar m = new Ayarlar();
            m.Kullanıcı_Adı = txtkullanıcı.Text;
            m.Sifre = txtsifre.Text;
            db.Ayarlars.Add(m);
            db.SaveChanges();
            MessageBox.Show("Bilgileriniz Başarılı Şekilde Kaydedildi....");
            dataGridView1.DataSource = db.Ayarlars.ToList();
        }

        private void pcbxgeri_Click(object sender, EventArgs e)
        {
            Form3anamenü frm = new Form3anamenü();
            frm.Show();
            this.Hide();
        }
    }
}
