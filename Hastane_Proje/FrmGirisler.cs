﻿using System;
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
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {

            FrmHastaGiris fr=new FrmHastaGiris();
            fr.Show();
            this.Hide();

        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr=new FrmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr=new FrmSekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void FrmGirisler_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMisyon fr=new FrmMisyon();
            fr.Show();
           this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmvizyon fr = new Frmvizyon();
            fr.Show();
            this.Hide();
        }
    }
}
