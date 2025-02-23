using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
    public partial class FrmMisyon : Form
    {
        public FrmMisyon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           FrmGirisler fr=new FrmGirisler();
            fr.Show();
            this.Hide();
        }
    }
}
