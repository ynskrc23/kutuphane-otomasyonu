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
    public partial class Form3anamenü : Form
    {
        public Form3anamenü()
        {
            InitializeComponent();
        }

        private void yeniÜyeEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4üyeekleme frm = new Form4üyeekleme();
            frm.Show();
            this.Hide();
        }

        private void kitapEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5kitapekleme frm = new Form5kitapekleme();
            frm.Show();
            this.Hide();
        }

        private void ödünçKitapVermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6ödünckitap frm = new Form6ödünckitap();
            frm.Show();
            this.Hide();
        }

        private void ödünçVerilenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7ödüncverilen frm = new Form7ödüncverilen();
            frm.Show();
            this.Hide();
        }

        private void üyeSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8üyesorgula frm = new Form8üyesorgula();
            frm.Show();
            this.Hide();
        }

        private void kitapSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9kitapsorgula frm = new Form9kitapsorgula();
            frm.Show();
            this.Hide();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10hakkımızda frm = new Form10hakkımızda();
            frm.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
