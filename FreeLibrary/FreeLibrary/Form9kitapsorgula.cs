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
    public partial class Form9kitapsorgula : Form
    {
        public Form9kitapsorgula()
        {
            InitializeComponent();
        }
        KütüphaneEntities3 db = new KütüphaneEntities3();
        private void Form9kitapsorgula_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
            dataGridView1.DataSource = db.Kitap_Eklemes.ToList();
        }
        private void btnara_Click(object sender, EventArgs e)
        {
            string m = txtarama.Text;
            var ara = from u in db.Kitap_Eklemes where u.Kitabın_Adı.Contains(m) select u;
            dataGridView1.DataSource = ara.ToList();
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            Form3anamenü frm = new Form3anamenü();
            frm.Show();
            this.Hide();
        }
    }
}
