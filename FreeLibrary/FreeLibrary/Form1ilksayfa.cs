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
    public partial class Form1ilksayfa : Form
    {
        public Form1ilksayfa()
        {
            InitializeComponent();
        }
        KütüphaneEntities3 db=new KütüphaneEntities3();

        private void Form1ilksayfa_Load(object sender, EventArgs e)
        {
            cmbxkullanıcı.DataSource = db.Ayarlars.ToList();
            cmbxkullanıcı.ValueMember = "Id";
            cmbxkullanıcı.DisplayMember = "Kullanıcı_Adı";

        }
        private void pcbxgiris_Click(object sender, EventArgs e)
        {
            string kulllanıcı, sifre;
            kulllanıcı = cmbxkullanıcı.Text;
            sifre = txtsifre.Text;

            if (kulllanıcı == cmbxkullanıcı.Text && sifre == txtsifre.Text)
            {
                Form2sistemeyönlendirme frm = new Form2sistemeyönlendirme();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Sifre Yanlış");
            }

        }

    }
}
