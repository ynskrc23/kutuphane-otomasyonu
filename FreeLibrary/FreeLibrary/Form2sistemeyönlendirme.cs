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
    public partial class Form2sistemeyönlendirme : Form
    {
        public Form2sistemeyönlendirme()
        {
            InitializeComponent();
        }

        private void Form2sistemeyönlendirme_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 20;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Form3anamenü frm = new Form3anamenü();
                frm.Show();
                this.Hide();
            }
        }
    }
}
