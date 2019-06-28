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
    public partial class Form7ödüncverilen : Form
    {
        public Form7ödüncverilen()
        {
            InitializeComponent();
        }
        KütüphaneEntities3 db = new KütüphaneEntities3();
        private void Form7ödüncverilen_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
            dataGridView1.DataSource = db.Ödünç_Kitap_Verme.ToList();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Form3anamenü frm = new Form3anamenü();
            frm.Show();
            this.Hide();
        }
    }
}
