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
    public partial class Form4üyeekleme : Form
    {
        public Form4üyeekleme()
        {
            InitializeComponent();
        }
        KütüphaneEntities3 db = new KütüphaneEntities3();

        private void btnkydet_Click(object sender, EventArgs e)
        {
            Üye_Ekleme m = new Üye_Ekleme(); 
            m.Tc = txttc.Text;
            m.İsim = txtisim.Text;
            m.Soyisim = txtsoy.Text;
            m.Cinsiyet = cmbxcins.Text;
            m.Dogum_Yeri = txtdogum.Text;
            m.Dogum_Tarihi = datedogum.Value;
            m.Cep_No = txtcep.Text;
            m.Adres = txtadres.Text;
            m.E_posta = txtposta.Text;
            m.Eğitim = cmbxegtim.Text;
            m.Üyelik_Tarihi = dateüyelik.Value;
            db.Üye_Ekleme.Add(m);
            db.SaveChanges();
            MessageBox.Show("Bilgileriniz Başarılı Şekilde Kaydedildi....");
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txttc.Clear();
            txtisim.Clear();
            txtsoy.Clear();
            txtdogum.Clear();
            txtcep.Clear();
            txtadres.Clear();
            txtposta.Clear();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Form3anamenü frm = new Form3anamenü();
            frm.Show();
            this.Hide();
        }
    }
}
